using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query;

public class AulaGetByIdQuery : IRequest<Result<GetAulaViewModel>>, IValidatable
{
    public Guid _Id { get; set; }
    public AulaGetByIdQuery(Guid Id) => _Id = Id;
}