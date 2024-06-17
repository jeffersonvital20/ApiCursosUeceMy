using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Command.AulaCommands;
using ApiCursosUeceMy.Domain.Services.Interface;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.RequestHandlers.CommandHandler.AulaCommandsHandler;

public class CreateAulaRequestHandler : IRequestHandler<CreateAulaRequest, Result<GetAulaViewModel>>
{
    private readonly IAulaRepository _aulaRepository;
    private readonly IStreamServices _streamServices;

    public CreateAulaRequestHandler(IAulaRepository aulaRepository, IStreamServices streamServices)
    {
        _aulaRepository = aulaRepository;
        _streamServices = streamServices;
    }

    public async Task<Result<GetAulaViewModel>> Handle(CreateAulaRequest request, CancellationToken cancellationToken)
    {
        Guid IdRecurso = new Guid();
        if (request._aula == null)
        {
            return Result.Success(new GetAulaViewModel());
        }
        if (request._aula.Recurso != null)
        {
            IdRecurso = _streamServices.SalvarRecurso(request._aula.Recurso).Result.id;
        }

        Aula entity = new Aula()
        {
            Titulo = request._aula.Titulo,
            CursoId = request._aula.CursoId,
            Duracao = request._aula.Duracao,
            IdRecursoStream = IdRecurso.ToString(),
            Curso = new Curso(),
            Ordem = request._aula.Ordem,
        };


        await _aulaRepository.Create(entity).ConfigureAwait(false);
        var aula = _aulaRepository.GetById(entity.Id);
        GetAulaViewModel result = new GetAulaViewModel()
        {
            Id = aula.Id,
            Titulo = aula.Titulo,
            Duracao = aula.Duracao,
            Ordem = aula.Ordem,
            CursoId = aula.CursoId
        };

        return result;
    }
}
