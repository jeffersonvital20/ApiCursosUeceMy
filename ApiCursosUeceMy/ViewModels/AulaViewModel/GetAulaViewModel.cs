using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Services.Results;

namespace ApiCursosUeceMy.ViewModels.AulaViewModel;

public class GetAulaViewModel
{
    public Guid Id { get; set; }
    public int Ordem { get; set; }
    public string? Titulo { get; set; }
    public string? Duracao { get; set; }
    public Guid CursoId { get; set; }
    public string IdRecursoStream { get; set; }
    public StreamResult Recurso { get; set; }
}
