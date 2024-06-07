using ApiCursosUeceMy.Domain.Model;

namespace ApiCursosUeceMy.ViewModels;

public class GetAulaViewModel
{
    public Guid Id { get; set; }
    public int Ordem { get; set; }
    public string? Titulo { get; set; }
    public string? Duracao { get; set; }
    public string? IdRecursoStream { get; set; }
    public Guid CursoId { get; set; }
}
