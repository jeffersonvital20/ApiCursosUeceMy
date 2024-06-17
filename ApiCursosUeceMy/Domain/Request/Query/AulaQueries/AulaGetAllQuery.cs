using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query.AulaQueries
{
    public class AulaGetAllQuery : IRequest<Result<List<GetAulaViewModel>>>, IValidatable
    {
    }
}
