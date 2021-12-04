using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.ArticleTranslations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleTranslationController : BaseCRUDController<ArticleTranslationDto, ArticleTranslationSearchRequest, ArticleTranslationUpsertRequest, ArticleTranslationUpsertRequest>
    {
        public ArticleTranslationController(IArticleTranslationService articleTranslationService)
           : base(articleTranslationService)
        {
        }
    }
}