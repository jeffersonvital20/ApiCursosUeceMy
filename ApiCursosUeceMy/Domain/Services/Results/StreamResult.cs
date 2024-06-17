namespace ApiCursosUeceMy.Domain.Services.Results;

public class StreamResult
{
    public Guid id { get; set; }
    public string? tipo { get; set; }
    public string? link { get; set; }
    public byte[]? arquivo { get; set; }
}
