using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Query.AulaQueries;
using ApiCursosUeceMy.Domain.Services.Interface;
using ApiCursosUeceMy.Domain.Services.Results;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;
using Steeltoe.Extensions.Configuration;

namespace ApiCursosUeceMy.Domain.RequestHandlers.QueryHandler;


public class AulaGetAllQueryHandler : IRequestHandler<AulaGetAllQuery, Result<List<GetAulaViewModel>>>
{
    private readonly IAulaRepository _aulaRepository;
    private readonly IStreamServices _streamServices;

    public AulaGetAllQueryHandler(IAulaRepository aulaRepository,IStreamServices streamServices)
    {
        _aulaRepository = aulaRepository;
        _streamServices = streamServices;
    }
    public async Task<Result<List<GetAulaViewModel>>> Handle(AulaGetAllQuery request, CancellationToken cancellationToken)
    {
        List<Aula> resultAula = _aulaRepository.GetAll().ToList();
        List<GetAulaViewModel> result = new List<GetAulaViewModel>();
        foreach (var aula in resultAula)
        {
            var recurso = _streamServices.BuscarRecurso(Guid.Parse(aula.IdRecursoStream));
            result.Add(new GetAulaViewModel()
            {
                Id = aula.Id,
                Titulo = aula.Titulo,
                Duracao = aula.Duracao,
                Ordem = aula.Ordem,
                CursoId = aula.CursoId,
                Recurso = new StreamResult()
                {
                    id = recurso.Result.id,
                    arquivo = recurso.Result.arquivo,
                    link = recurso.Result.link,
                    tipo = recurso.Result.tipo
                }
            });
        }
        return Result.Success(result);
    }
}
