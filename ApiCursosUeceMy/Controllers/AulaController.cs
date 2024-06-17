using ApiCursosUeceMy.Domain.Request.Command.AulaCommands;
using ApiCursosUeceMy.Domain.Request.Query.AulaQueries;
using ApiCursosUeceMy.ViewModels.AulaViewModel;
using ApiCursoUeceMy.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiCursosUeceMy.Controllers;

public class AulaController : AppControllerBase
{
    public AulaController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("create")]
    public Task<IActionResult> Create([FromBody] CreateAulaViewModel aula)
           => SendRequest(new CreateAulaRequest(aula));

    [HttpGet("getById")]
    public Task<IActionResult> GetById([FromQuery] Guid id) => SendRequest(new AulaGetByIdQuery(id));

    [HttpGet("getAll")]
    public Task<IActionResult> GetAll()
        => SendRequest(new AulaGetAllQuery());

    [HttpGet("getAulasCurso")]
    public Task<IActionResult> GetAulasCurso([FromQuery] Guid id) => SendRequest(new GetAulasCursoQuery(id));

    [HttpPatch("update")]
    public Task<IActionResult> Update([FromBody] UpdateAulaViewModel input)
        => SendRequest(new UpdateAulaRequest(input));

//    [HttpDelete("delete")]
//    public Task<IActionResult> Delete([FromQuery] string id)
//        => SendRequest(new DeleteAulaRequest(id));

//    [HttpPatch("updateRecurso")]
//    public Task<IActionResult> UpdateRecuros([FromBody] CreateAulaViewModel input)
//        => SendRequest(new UpdateRecursoAulaRequest(input));

//    [HttpPatch("salvarRecurso")]
//    public Task<IActionResult> SalvarRecuros([FromBody] CreateAulaViewModel input)
//        => SendRequest(new SalvarRecursoAulaRequest(input));
}
