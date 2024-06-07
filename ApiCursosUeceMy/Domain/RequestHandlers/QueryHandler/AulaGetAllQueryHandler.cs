using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Query;
using ApiCursosUeceMy.Infra.Repositories;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.QueryHandler;


public class AulaGetAllQueryHandler : IRequestHandler<AulaGetAllQuery, Result<List<GetAulaViewModel>>>
{
    private readonly IAulaRepository _aulaRepository;
    public AulaGetAllQueryHandler(IAulaRepository aulaRepository)
    {
        _aulaRepository = aulaRepository;
    }
    public async Task<Result<List<GetAulaViewModel>>> Handle(AulaGetAllQuery request, CancellationToken cancellationToken)
    {
        List<Aula> resultAula = _aulaRepository.GetAll().ToList();
        List<GetAulaViewModel> result = new List<GetAulaViewModel>();
        foreach (var aula in resultAula)
        {
            result.Add(new GetAulaViewModel()
            {
                Id = aula.Id,
                Titulo = aula.Titulo,
                Duracao = aula.Duracao,
                Ordem = aula.Ordem,
                IdRecursoStream = aula.IdRecursoStream,
                CursoId = aula.CursoId
            });
        }
        return Result.Success(result);
    }
}
