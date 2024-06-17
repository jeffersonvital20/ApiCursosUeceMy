using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query.AulaQueries
{
    public class GetAulasCursoQuery : IRequest<Result<List<GetAulaViewModel>>>, IValidatable
    {
        public Guid _Id { get; set; }
        public GetAulasCursoQuery(Guid Id) => _Id = Id;
    }
}