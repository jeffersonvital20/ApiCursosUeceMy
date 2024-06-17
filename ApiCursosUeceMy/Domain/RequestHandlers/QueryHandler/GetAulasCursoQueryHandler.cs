using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Query.AulaQueries;
using ApiCursosUeceMy.Domain.Services.Interface;
using ApiCursosUeceMy.Domain.Services.Results;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.QueryHandler
{
    public class GetAulasCursoQueryHandler : IRequestHandler<GetAulasCursoQuery, Result<List<GetAulaViewModel>>>
    {
        private readonly IAulaRepository _aulaRepository;
        private readonly IStreamServices _service;

        public GetAulasCursoQueryHandler(IAulaRepository aulaRepository, IStreamServices streamServices)
        {
            _aulaRepository = aulaRepository;
            _service = streamServices;
        }
        public Task<Result<List<GetAulaViewModel>>> Handle(GetAulasCursoQuery request, CancellationToken cancellationToken)
        {
            var aulas = _aulaRepository.GetAulasCurso(request._Id);
            List<GetAulaViewModel> result = new List<GetAulaViewModel>();
            foreach (var aula in aulas)
            {
                var recurso = _service.BuscarRecurso(Guid.Parse(aula.IdRecursoStream)).Result;
                result.Add(new GetAulaViewModel()
                {
                    Id = aula.Id,
                    Titulo = aula.Titulo,
                    CursoId = aula.CursoId,
                    Duracao = aula.Duracao,
                    Ordem = aula.Ordem,
                    Recurso = new StreamResult()
                    {
                        id = recurso.id,
                        arquivo = recurso.arquivo,
                        link = recurso.link,
                        tipo = recurso.tipo
                    },
                });
            }
            return Result.Success(result);
        }
    }
}
