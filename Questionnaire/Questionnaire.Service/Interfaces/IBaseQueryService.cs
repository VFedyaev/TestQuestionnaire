using Questionnaire.Data.Interfaces;
using Questionnaire.Service.Query;

namespace Questionnaire.Service.Interfaces
{
    public interface IBaseQueryService<TEntity, TModel, TSortType>
        where TEntity : class, IEntityBase, new()
    {
        QueryResponse<TModel> Get(QueryRequest<TSortType> query);
    }
}
