using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Services.BaseRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Feedbacks
{
    public class FeedbackService : BaseReadService<FeedbackDto, Feedback, object>, IFeedbackService
    {
        public FeedbackService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
