using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Services.Inputs;

namespace ApiCursosUeceMy.ViewModels.AulaViewModel
{
    public class CreateAulaViewModel
    {
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public string? Duracao { get; set; }
        public Guid CursoId { get; set; }
        public StreamInput Recurso { get; set; }
    }
}
