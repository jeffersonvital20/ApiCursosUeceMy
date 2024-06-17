using ApiCursosUeceMy.Domain.Interfaces;
using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Infra.Context;
using ApiCursosUeceMy.ViewModels.AulaViewModel;

namespace ApiCursosUeceMy.Infra.Repositories
{
    public class AulaRepository : BaseRepository<Aula>, IAulaRepository
    {
        public AulaRepository(AppDbContext context) : base(context)
        {
        }

        public List<GetAulaViewModel> GetAulasCurso(Guid idCurso)
        {
            var aulas = GetAll();
            var aulasCurso = aulas.Where(a => a.CursoId.Equals(idCurso)).ToList();
            List<GetAulaViewModel> result = new List<GetAulaViewModel>();
            foreach (var aula in aulasCurso)
            {
                result.Add(new GetAulaViewModel()
                {
                    Id = aula.Id,
                    CursoId = aula.CursoId,
                    Duracao = aula.Duracao,
                    Ordem = aula.Ordem,
                    IdRecursoStream = aula.IdRecursoStream,
                    Titulo = aula.Titulo,
                });
            }

            return result;
        }
    }
}
