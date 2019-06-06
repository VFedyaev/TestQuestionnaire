using Questionnaire.Data.Entities;
using Questionnaire.Data.Enums;
using System;

namespace Questionnaire.Service.Interfaces
{
    public interface IAnswerService : IBaseQueryService<Answer, AnswerModel, SortType>
    {
        void AddAnswer(AnswerModel answer);
        AnswerModel GetAnswerById(Guid id);
    }
}
