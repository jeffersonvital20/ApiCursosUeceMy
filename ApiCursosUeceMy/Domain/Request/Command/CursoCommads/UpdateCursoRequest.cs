using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.CursoViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Command.CursoCommands;

public class UpdateCursoRequest : IRequest<Result<bool>>, IValidatable
{
    public GetCursoViewModel _getCursoViewModel { get; set; }

    public UpdateCursoRequest(GetCursoViewModel getCursoViewModel)
    {
        _getCursoViewModel = getCursoViewModel;
    }
}
