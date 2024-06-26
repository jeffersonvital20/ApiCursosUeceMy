﻿using ApiCursosUeceMy.Domain.Validation;
using ApiCursosUeceMy.ViewModels.CursoViewModel;
using MediatR;
using OperationResult;

namespace ApiCursosUeceMy.Domain.Request.Command.CursoCommands
{
    public class CreateCursoRequest : IRequest<Result<CreateCursoViewModel>>, IValidatable
    {
        public CreateCursoViewModel _createCursoViewModel { get; set; }
        public CreateCursoRequest(CreateCursoViewModel createCursoModelView)
        {
            _createCursoViewModel = createCursoModelView;
        }
    }
}
