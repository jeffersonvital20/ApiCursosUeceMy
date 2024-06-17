using ApiCursosUeceMy.Domain.Services.Inputs;
using ApiCursosUeceMy.Domain.Services.Results;

namespace ApiCursosUeceMy.Domain.Services.Interface
{
    public interface IStreamServices
    {
        Task<StreamResult> SalvarRecurso(StreamInput streamInput);
        Task<StreamResult> BuscarRecurso(Guid IdRecurso);       
    }
}
