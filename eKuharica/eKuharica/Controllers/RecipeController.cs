using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.Services.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : BaseCRUDController<RecipeDto, RecipeSearchObject, RecipeUpsertRequest, RecipeUpsertRequest>
    {
        public RecipeController(IRecipeService recipeService)
            :base(recipeService)
        {
        }
    }
}