using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Infra.Context;

namespace ApiCursosUeceMy.Infra.Repositories
{
    public class AulaRepository : BaseRepository<Aula>, IAulaRepository
    {
        public AulaRepository(AppDbContext context) : base(context)
        {
        }
    }
}
