using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Request.Command.CursoCommands;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.CommandHandler.CursoCommandsHandler;

public class UpdateCursoRequestHandler : IRequestHandler<UpdateCursoRequest, Result<bool>>
{
    public ICursoRepository _cursoRepository { get; set; }
    public UpdateCursoRequestHandler(ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }

    public Task<Result<bool>> Handle(UpdateCursoRequest request, CancellationToken cancellationToken)
    {
        var curso = _cursoRepository.GetById(request._getCursoViewModel.Id);
        if (curso == null)
            return Result.Success(false);
        curso.Preco = request._getCursoViewModel.Preco;
        curso.Titulo = request._getCursoViewModel.Titulo;
        curso.QtdAulas = request._getCursoViewModel.QtdAulas;
        curso.Descricao = request._getCursoViewModel.Descricao;
        curso.NomeInstrutor = request._getCursoViewModel.NomeInstrutor;

        _cursoRepository.Update(curso);
        return Result.Success(true);
    }
}
