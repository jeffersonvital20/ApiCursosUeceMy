namespace ApiCursoUeceMy.Domain.Execption;

[Serializable]
public class AppCursoUceMyValidatorException : Exception
{
    public AppCursoUceMyValidatorException(Dictionary<string, IEnumerable<string>> errors) : base("Invalid data")
        => Errors = errors;

    public Dictionary<string, IEnumerable<string>> Errors { get; }
}
