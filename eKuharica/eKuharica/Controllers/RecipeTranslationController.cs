using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Models;
using eKuharica.Model.Requests;
using eKuharica.Services.RecipeTranslations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeTranslationController : BaseCRUDController<RecipeTranslationDto, RecipeTranslationSearchRequest, RecipeTranslationUpsertRequest, RecipeTranslationUpsertRequest>
    {
        public RecipeTranslationController(IRecipeTranslationService recipeTranslationService)
            : base(recipeTranslationService)
        {
        }
    }
}