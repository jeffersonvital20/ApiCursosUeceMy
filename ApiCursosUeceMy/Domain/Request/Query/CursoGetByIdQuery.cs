using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query
{
    public class CursoGetByIdQuery : IRequest<Result<GetCursoViewModel>>, IValidatable
    {
        public Guid _Id { get; set; }
        public CursoGetByIdQuery(Guid Id) => _Id = Id;
    }
}
