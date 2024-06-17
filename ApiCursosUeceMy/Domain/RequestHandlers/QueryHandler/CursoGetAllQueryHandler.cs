using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Query.CursoQueries;
using ApiCursosUeceMy.ViewModels.CursoViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.QueryHandler;

public class CursoGetAllQueryHandler : IRequestHandler<CursoGetAllQuery, Result<List<GetCursoViewModel>>>
{
    private readonly ICursoRepository _cursoRepository;

    public CursoGetAllQueryHandler(ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }
    public Task<Result<List<GetCursoViewModel>>> Handle(CursoGetAllQuery request, CancellationToken cancellationToken)
    {
        List<Curso> resultCurso = _cursoRepository.GetAll().ToList();
        List<GetCursoViewModel> result = new List<GetCursoViewModel>();
        foreach (var curso in resultCurso)
        {
            result.Add(new GetCursoViewModel()
            {
                Id = curso.Id,
                Descricao = curso.Descricao,
                NomeInstrutor = curso.NomeInstrutor,
                Preco = curso.Preco,
                QtdAulas = curso.QtdAulas,
                Titulo = curso.Titulo
            });
        }
        return Result.Success(result);
    }
}
