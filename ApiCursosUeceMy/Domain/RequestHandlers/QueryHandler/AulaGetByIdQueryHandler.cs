using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Query;
using ApiCursosUeceMy.Infra.Repositories;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.QueryHandler
{
    public class AulaGetByIdQueryHandler : IRequestHandler<AulaGetByIdQuery, Result<GetAulaViewModel>>
    {
        private readonly IAulaRepository _aulaRepository;

        public AulaGetByIdQueryHandler(IAulaRepository aulaRepository)
        {
            _aulaRepository = aulaRepository;
        }

        public async Task<Result<GetAulaViewModel>> Handle(AulaGetByIdQuery request, CancellationToken cancellationToken)
        {
            Aula aula = _aulaRepository.GetById(request._Id);

            GetAulaViewModel result = new GetAulaViewModel()
            {
                Id = aula.Id,
                Titulo = aula.Titulo,
                CursoId = aula.CursoId,
                Duracao = aula.Duracao,
                IdRecursoStream = aula.IdRecursoStream,
                Ordem = aula.Ordem
            };

            return result;
        }
    }
}
