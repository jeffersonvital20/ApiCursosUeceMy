using System.Collections.ObjectModel;

namespace ApiCursosUeceMy.Domain.Model;

public class Curso
{
    public Curso()
    {
        Aulas = new Collection<Aula>();
    }
    public Guid Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public string? NomeInstrutor { get; set;}
    public int QtdAulas { get; set; }
    public decimal Preco { get; set; }
    public ICollection<Aula>? Aulas { get; set; }
}
