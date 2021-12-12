using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using eKuharica.Services.BaseRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Feedbacks
{
    public interface IFeedbackService : IBaseCRUDService<FeedbackDto, FeedbackSearchRequest, FeedbackUpsertRequest, FeedbackUpsertRequest>
    {
    }
}
