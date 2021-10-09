using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Model.DTO;
using eKuharica.Services.BaseRead;
using eKuharica.Services.Feedbacks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKuharica.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FeedbackController : BaseReadController<FeedbackDto,object>
    {
        public FeedbackController(IFeedbackService service) : base(service)
        {
        }
    }
}