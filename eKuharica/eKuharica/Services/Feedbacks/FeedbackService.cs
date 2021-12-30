using AutoMapper;
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
    public class FeedbackService : BaseCRUDService<FeedbackDto, Feedback, FeedbackSearchRequest, FeedbackUpsertRequest, FeedbackUpsertRequest>, IFeedbackService
    {
        public FeedbackService(Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<FeedbackDto> Get(FeedbackSearchRequest search = null)
        {
            var query = Context.Feedback.AsQueryable();
            var users = Context.User.AsQueryable();

            if (search.Rating > 0)
                query = query.Where(x => x.Rating == search.Rating);

            if (!string.IsNullOrWhiteSpace(search.Username))
            {
                var userId = users
                    .Where(x => x.Username.ToLower() == search.Username.ToLower())
                    .Select(x => x.Id)
                    .FirstOrDefault();

                query = query.Where(x => x.UserId == userId);
            }

            var list = query.ToList();
            var mappedList = _mapper.Map<List<FeedbackDto>>(list);

            mappedList.ForEach(x => x.Username = users.Where(u => u.Id == x.UserId).Select(u => u.Username).FirstOrDefault());

            return mappedList;
        }
    }
}
