using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.CursoViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query.CursoQueries
{
    public class CursoGetByIdQuery : IRequest<Result<GetCursoViewModel>>, IValidatable
    {
        public Guid _Id { get; set; }
        public CursoGetByIdQuery(Guid Id) => _Id = Id;
    }
}
