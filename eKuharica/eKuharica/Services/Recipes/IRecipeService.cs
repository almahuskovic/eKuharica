using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using eKuharica.Services.BaseRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Recipes
{
    public interface IRecipeService:IBaseCRUDService<RecipeDto, RecipeSearchObject, RecipeUpsertRequest, RecipeUpsertRequest>
    {
        public List<RecipeDto> Recommend(int id);
    }
}
