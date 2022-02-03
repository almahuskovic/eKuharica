using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using eKuharica.Services.BaseRead;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Recipes
{
    public class RecipeService : BaseCRUDService<RecipeDto,Recipe,RecipeSearchObject, RecipeUpsertRequest, RecipeUpsertRequest>, IRecipeService
    {
        public RecipeService(Context context, IMapper mapper):base(context,mapper)
        {
        }
        public override IEnumerable<RecipeDto> Get(RecipeSearchObject search = null)
        {
            var entity = Context.Set<Recipe>().AsQueryable();

            if (!search.ByUsers)
            {
                if (search.IsFavouriteRecipeSearch && search.RecipeIds == null)
                {
                    return new List<RecipeDto>();
                }
                if(search.MyRecipes)//prikazi sve recepte od korisnika
                {
                    entity = entity.Where(x => x.UserId == search.LoggedUserId && x.IsSent);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(search?.Title))
                    {
                        entity = entity.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
                    }
                    if (search.PreparationTimeCategory.HasValue)
                    {
                        entity = entity.Where(x => x.PreparationTimeCategory == search.PreparationTimeCategory);
                    }
                    if (search.WeightOfPreparation.HasValue)
                    {
                        entity = entity.Where(x => x.WeightOfPreparation == search.WeightOfPreparation);
                    }
                    if (search.MealType.HasValue)
                    {
                        entity = entity.Where(x => x.MealType == search.MealType);
                    }
                    if (search.RecipeIds != null && search.RecipeIds.Any())
                    {
                        entity = entity.Where(x => search.RecipeIds.Contains(x.Id));
                    }
                }

                entity = entity.Where(x => x.IsApproved);
            }
            else
            {
                entity = entity.Where(x => !x.IsApproved && x.IsSent);
            }

            if (!search.LoggedUserHasPermissions)
                entity = entity.Where(x => x.IsTranslated);

            var list = entity.ToList();
            var mappedList = _mapper.Map<List<RecipeDto>>(list);
            mappedList.ForEach(x => x.IsCreatedByLoggedUser = (x.UserId == search.LoggedUserId));

            return mappedList;
        }

        private static MLContext mlContext = null;
        private static ITransformer model = null;
        public List<RecipeDto> Recommend(int id)
        {
            if (mlContext == null)
            {
                mlContext = new MLContext();
                var tmpData = Context.UserRecipeRating.Where(x => x.UserId == id && x.Rating >= 3).ToList();
                var data = new List<RecipeEntry>();

                foreach (var x in tmpData)
                {
                    data.Add(new RecipeEntry()
                    {
                        userId = (uint)x.UserId,
                        recipeId = (uint)x.RecipeId
                    });
                }

                var traindata = mlContext.Data.LoadFromEnumerable(data);

                var dataProcessingPipeline = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "userIdEncoded", inputColumnName: nameof(RecipeEntry.userId))
                           .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "recipeIdEncoded", inputColumnName: nameof(RecipeEntry.recipeId)));

                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = "userIdEncoded";
                options.MatrixRowIndexColumnName = "recipeIdEncoded";
                options.LabelColumnName = "Label";
                options.NumberOfIterations = 20;
                options.ApproximationRank = 100;

                //STEP 4: Create the training pipeline
                var trainingPipeLine = dataProcessingPipeline.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));

               model = trainingPipeLine.Fit(traindata);
            }

            var allItems = Context.Recipe.Include("UserRecipeRatings");

            var predictionResult = new List<Tuple<Recipe, float>>();

            foreach (var item in allItems)
            {
                foreach (var itemR in item.UserRecipeRatings)
                {
                    if (itemR.UserId != id)
                    {
                        var predictionEngine =
                        mlContext.Model.CreatePredictionEngine<RecipeEntry, RecipePrediction>(model);

                        var prediction = predictionEngine.Predict(new RecipeEntry()
                        {
                            recipeId = item.Id,
                            userId = id
                        });
                        predictionResult.Add(new Tuple<Recipe, float>(item, prediction.Score));
                    }
                }
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
              .Select(x => x.Item1).Take(3).ToList();

            return _mapper.Map<List<RecipeDto>>(finalResult);
        }
    }

    public class RecipeEntry
    {
        public float recipeId;

        public float userId;

        //public bool isLiked;

        public float Label;//rating
    }

    class RecipePrediction
    {
        public float Label;

        public float Score;
    }
}
