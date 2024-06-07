using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Query;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.QueryHandler;

public class CursoGetByIdQueryHandler : IRequestHandler<CursoGetByIdQuery, Result<GetCursoViewModel>>
{
    public ICursoRepository _cursoRepository { get; set; }

    public CursoGetByIdQueryHandler(ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }

    public async Task<Result<GetCursoViewModel>> Handle(CursoGetByIdQuery request, CancellationToken cancellationToken)
    {
        Curso curso = _cursoRepository.GetById(request._Id);

        GetCursoViewModel result = new GetCursoViewModel()
        {
            Id = curso.Id,
            Titulo = curso.Titulo,
            Descricao = curso.Descricao,
            NomeInstrutor = curso.NomeInstrutor,
            Preco = curso.Preco,
            QtdAulas = curso.QtdAulas
        };

        return result;
    }
}
