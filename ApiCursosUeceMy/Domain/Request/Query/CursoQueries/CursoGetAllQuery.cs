using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.CursoViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Query.CursoQueries;

public class CursoGetAllQuery : IRequest<Result<List<GetCursoViewModel>>>, IValidatable
{
}
