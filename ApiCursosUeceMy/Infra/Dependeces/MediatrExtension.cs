using ApiCursosUeceMy.Domain.Request.Command.AulaCommands;
using ApiCursosUeceMy.Domain.Request.Command.CursoCommands;
using ApiCursosUeceMy.Domain.Request.Query.CursoQueries;

namespace ApiCursosUeceMy.Infra.Dependeces;

public static class MediatrExtension
{
    public static void AddMediatRApi(this IServiceCollection services)
    {
        //services.AddMediatR(typeof(CreateMembroRequest).Assembly);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateCursoRequest).Assembly));
        //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AutorizarUsuarioRequest).Assembly));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UpdateCursoRequest).Assembly));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CursoGetByIdQuery).Assembly));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateAulaRequest).Assembly));
    }
}
