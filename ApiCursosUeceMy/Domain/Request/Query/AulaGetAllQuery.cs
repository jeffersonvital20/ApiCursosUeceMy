using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query
{
    public class AulaGetAllQuery : IRequest<Result<List<GetAulaViewModel>>>, IValidatable
    {
    }
}
