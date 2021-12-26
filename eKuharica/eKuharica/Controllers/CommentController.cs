using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.Comments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : BaseCRUDController<CommentDto, CommentSearchRequest, CommentUpsertRequest, CommentUpsertRequest>
    {
        public CommentController(ICommentService commentService)
          : base(commentService)
        {
        }
    }
}