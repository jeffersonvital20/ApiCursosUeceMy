using System.Buffers.Text;

namespace ApiCursosUeceMy.Domain.Model;

public class Aula
{
    public Guid Id { get; set; }
    public int Ordem { get; set; }
    public string? Titulo { get; set; }
    public string? Duracao { get; set;}
    public string? IdRecursoStream { get; set; }
    public Curso? Curso { get; set; }
    public Guid CursoId { get; set; }

}
