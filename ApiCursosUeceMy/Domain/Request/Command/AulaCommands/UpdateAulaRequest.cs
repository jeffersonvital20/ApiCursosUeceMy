using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Command.AulaCommands;

public class UpdateAulaRequest : IRequest<Result<UpdateAulaViewModel>>, IValidatable
{
    public UpdateAulaViewModel _aula { get; set; }
    public UpdateAulaRequest(UpdateAulaViewModel aula)
    {
        _aula = aula;
    }
}
