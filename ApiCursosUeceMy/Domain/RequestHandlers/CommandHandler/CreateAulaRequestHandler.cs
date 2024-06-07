using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Command;
using ApiCursosUeceMy.Infra.Repositories;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.CommandHandler;

public class CreateAulaRequestHandler : IRequestHandler<CreateAulaRequest, Result<Aula>>
{
    private readonly IAulaRepository _aulaRepository;

    public CreateAulaRequestHandler(IAulaRepository aulaRepository)
    {
        _aulaRepository = aulaRepository;
    }

    public async Task<Result<Aula>> Handle(CreateAulaRequest request, CancellationToken cancellationToken)
    {
        if (request._aula == null)
        {
            return Result.Success(new Aula());
        }
        Aula entity = new Aula()
        {
            Titulo = request._aula.Titulo,
            CursoId = request._aula.CursoId,
            Duracao = request._aula.Duracao,
            IdRecursoStream = request._aula.IdRecursoStream,
            Curso = new Curso(),
            Ordem = request._aula.Ordem,

        };

        await _aulaRepository.Create(entity).ConfigureAwait(false);
        Aula result = _aulaRepository.GetById(entity.Id);

        return result;
    }
}
