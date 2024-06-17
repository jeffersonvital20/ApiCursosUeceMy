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
    public class AulaGetByIdQueryHandler : IRequestHandler<AulaGetByIdQuery, Result<GetAulaViewModel>>
    {
        private readonly IAulaRepository _aulaRepository;
        private readonly IStreamServices _service;

        public AulaGetByIdQueryHandler(IAulaRepository aulaRepository,IStreamServices streamServices)
        {
            _aulaRepository = aulaRepository;
            _service = streamServices;
        }

        public async Task<Result<GetAulaViewModel>> Handle(AulaGetByIdQuery request, CancellationToken cancellationToken)
        {
            Aula aula = _aulaRepository.GetById(request._Id);
            var recurso = _service.BuscarRecurso(Guid.Parse(aula.IdRecursoStream)).Result;
            GetAulaViewModel result = new GetAulaViewModel()
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
            };

            return result;
        }
    }
}
