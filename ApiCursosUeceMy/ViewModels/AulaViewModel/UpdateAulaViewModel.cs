namespace ApiCursosUeceMy.ViewModels.AulaViewModel;

public class UpdateAulaViewModel
{
    public Guid Id { get; set; }
    public int Ordem { get; set; }
    public string? Titulo { get; set; }
    public string? Duracao { get; set; }
    public string? IdRecursoStream { get; set; }
}
