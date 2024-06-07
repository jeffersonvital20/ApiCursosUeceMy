using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Command;


public class CreateAulaRequest : IRequest<Result<Aula>>, IValidatable
{
    public CreateAulaViewModel _aula { get; set; }
    public CreateAulaRequest(CreateAulaViewModel aula)
    {
        _aula = aula;
    }
}

