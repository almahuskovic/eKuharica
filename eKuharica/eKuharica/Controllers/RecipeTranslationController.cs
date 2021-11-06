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
    [Route("[controller]")]
    [ApiController]
    public class RecipeTranslationController : BaseCRUDController<RecipeTranslationDto, RecipeTranslationSearchRequest, RecipeInsertRequest, RecipeUpdateRequest>
    {
        public RecipeTranslationController(IRecipeTranslationService recipeTranslationService)
            : base(recipeTranslationService)
        {
        }
    }
}