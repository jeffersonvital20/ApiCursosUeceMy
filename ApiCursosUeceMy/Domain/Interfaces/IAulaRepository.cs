using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.ViewModels.AulaViewModel;

namespace ApiCursosUeceMy.Domain.Interfaces;

public interface IAulaRepository : IBaseRepository<Aula>
{
    List<GetAulaViewModel> GetAulasCurso(Guid idCurso);
}
