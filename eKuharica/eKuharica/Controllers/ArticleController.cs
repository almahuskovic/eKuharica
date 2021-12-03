using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.Articles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : BaseCRUDController<ArticleDto, ArticleSearchRequest, ArticleUpsertRequest, ArticleUpsertRequest>
    {
        public ArticleController(IArticleService articleService)
           : base(articleService)
        {
        }
    }
}