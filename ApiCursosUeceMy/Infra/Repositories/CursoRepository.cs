using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Infra.Context;

namespace ApiCursosUeceMy.Infra.Repositories;

public class CursoRepository : BaseRepository<Curso>, ICursoRepository
{
    public CursoRepository(AppDbContext context) : base(context)
    {
    }
}
