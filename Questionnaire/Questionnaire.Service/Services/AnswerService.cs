using AutoMapper;
using Questionnaire.Data.Entities;
using Questionnaire.Data.Enums;
using Questionnaire.Data.Interfaces;
using Questionnaire.Service.Extensions;
using Questionnaire.Service.Interfaces;
using Questionnaire.Service.Query;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Service.Services
{
    public class AnswerService : BaseQueryService<Answer, AnswerModel, SortType>, IAnswerService
    {
        public AnswerService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper) { }


        public async Task AddAnswerAsync(AnswerModel answerModel)
        {
            var answer = _uow.GetRepository<Answer>().All().FirstOrDefault(x => x.Name == answerModel.Name
                                                                            && x.UserId == answerModel.UserId);
            if (answer != null)
            {
                throw new NotImplementedException();
            }

            answer = _mapper.Map<Answer>(answerModel);
            await _uow.GetRepository<Answer>().InsertAsync(answer);
            await _uow.SaveChangesAsync();
        }

        public async Task<AnswerModel> GetAnswerByIdAsync(Guid id)
        {
            var answer = await _uow.GetRepository<Answer>().GetByIdAsync(id);
            return _mapper.Map<AnswerModel>(answer);
        }

        protected override IQueryable<Answer> Order(IQueryable<Answer> items, bool isFirst, QueryOrder<SortType> order)
        {
            switch (order.OrderType)
            {
                case SortType.Name:
                    return items.OrderWithDirectionBy(isFirst, order.Direction, x => x.Name);
            }

            throw new ArgumentOutOfRangeException(nameof(order.OrderType));
        }

        protected override IQueryable<Answer> Paging(IQueryable<Answer> items, int? start, int? length)
        {
            return items.Skip(start.Value).Take(length.Value);
        }

        protected override IQueryable<Answer> Search(IQueryable<Answer> items, QuerySearch search)
        {
            if (!string.IsNullOrEmpty(search?.Value))
            {
                return items.Where(x => x.Name.Contains(search.Value));
            }
            return items;
        }

    }
}
