using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query;

public class CursoGetAllQuery : IRequest<Result<List<GetCursoViewModel>>>, IValidatable
{
}
