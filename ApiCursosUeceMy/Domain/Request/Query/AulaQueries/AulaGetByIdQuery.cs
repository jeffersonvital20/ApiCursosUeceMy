using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query.AulaQueries;

public class AulaGetByIdQuery : IRequest<Result<GetAulaViewModel>>, IValidatable
{
    public Guid _Id { get; set; }
    public AulaGetByIdQuery(Guid Id) => _Id = Id;
}