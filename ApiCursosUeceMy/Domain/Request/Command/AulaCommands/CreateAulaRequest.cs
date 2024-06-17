using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Command.AulaCommands;


public class CreateAulaRequest : IRequest<Result<GetAulaViewModel>>, IValidatable
{
    public CreateAulaViewModel _aula { get; set; }
    public CreateAulaRequest(CreateAulaViewModel aula)
    {
        _aula = aula;
    }
}

