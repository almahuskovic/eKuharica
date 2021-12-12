using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseRead;
using eKuharica.Services.Feedbacks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedbackController : BaseCRUDController<FeedbackDto, FeedbackSearchRequest, FeedbackUpsertRequest, FeedbackUpsertRequest>
    {
        public FeedbackController(IFeedbackService service) : base(service)
        {
        }
    }
}