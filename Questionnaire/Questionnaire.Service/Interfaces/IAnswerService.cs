using Questionnaire.Data.Entities;
using Questionnaire.Data.Enums;
using System;
using System.Threading.Tasks;

namespace Questionnaire.Service.Interfaces
{
    public interface IAnswerService : IBaseQueryService<Answer, AnswerModel, SortType>
    {
        Task AddAnswerAsync(AnswerModel answer);
        Task<AnswerModel> GetAnswerByIdAsync(Guid id);
    }
}
