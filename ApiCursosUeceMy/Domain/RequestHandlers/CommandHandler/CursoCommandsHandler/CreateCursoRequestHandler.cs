using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Command.CursoCommands;
using ApiCursosUeceMy.ViewModels.CursoViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.CommandHandler.CursoCommandsHandler;

public class CreateCursoRequestHandler : IRequestHandler<CreateCursoRequest, Result<CreateCursoViewModel>>
{
    private readonly ICursoRepository _cursoRepository;
    public CreateCursoRequestHandler(ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }
    public async Task<Result<CreateCursoViewModel>> Handle(CreateCursoRequest request, CancellationToken cancellationToken)
    {
        Curso entity = new Curso()
        {
            Titulo = request._createCursoViewModel.Titulo,
            Descricao = request._createCursoViewModel.Descricao,
            NomeInstrutor = request._createCursoViewModel.NomeInstrutor,
            Preco = request._createCursoViewModel.Preco,
            QtdAulas = request._createCursoViewModel.QtdAulas
        };

        await _cursoRepository.Create(entity).ConfigureAwait(false);
        Curso curso = _cursoRepository.GetById(entity.Id);

        CreateCursoViewModel result = new CreateCursoViewModel()
        {
            Titulo = curso.Titulo,
            Descricao = curso.Descricao,
            NomeInstrutor = curso.NomeInstrutor,
            Preco = curso.Preco,
            QtdAulas = curso.QtdAulas
        };

        return result;
    }
}
