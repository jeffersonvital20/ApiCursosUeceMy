using ApiCursosUeceMy.Domain.Model;
using ApiCursosUeceMy.Domain.Request.Command;
using ApiCursosUeceMy.Domain.Request.Query;
using ApiCursosUeceMy.ViewModels;
using ApiCursoUeceMy.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiCursosUeceMy.Controllers;

public class CursoController : AppControllerBase
{
    public CursoController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost("create")]
    public Task<IActionResult> Create([FromBody] CreateCursoViewModel curso)
           => SendRequest(new CreateCursoRequest(curso));

    [HttpGet("getById")]
    public Task<IActionResult> GetById([FromQuery] Guid id) => SendRequest(new CursoGetByIdQuery(id));

    [HttpGet("getAll")]
    public Task<IActionResult> GetAll()
        => SendRequest(new CursoGetAllQuery());

    [HttpPatch("update")]
    public Task<IActionResult> Update([FromBody] GetCursoViewModel input)
        => SendRequest(new UpdateCursoRequest(input));

    //[HttpDelete("delete")]
    //public Task<IActionResult> Delete([FromQuery] string id)
    //    => SendRequest(new Delete { entity }Request(id));

}
