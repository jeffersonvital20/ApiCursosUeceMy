using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Infra.Repositories;

namespace ApiCursosUeceMy.Infra.Dependeces;

public static class DepedencyInjection
{
    public static void AddDepencies(this IServiceCollection services)
    {
        AddRepositoryDependency(services);
    }

    private static void AddRepositoryDependency(IServiceCollection services)
    {
        services.AddScoped<ICursoRepository, CursoRepository>();
        services.AddScoped<IAulaRepository, AulaRepository>();
    }
}
