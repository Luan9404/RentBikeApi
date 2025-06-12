using System.Text.Json.Serialization;
using RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;
using RentBikeApi.Core.Application.UseCases.Motorcycles.DeleteMototcycle;
using RentBikeApi.Core.Application.UseCases.Motorcycles.GetAllMotorcycles;
using RentBikeApi.Core.Application.UseCases.Motorcycles.GetMotocycleById;
using RentBikeApi.Core.Application.UseCases.Motorcycles.UpdateMotorcycleLicensePlate;
using Desafio.WebAPI.API.Models.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.WebAPI.API.Controllers;

[ApiController]
[Route("motos")]
public class MotorcycleController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> Create(CreateMotorcycleRequest request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
        return Created("", null);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllMotorcyclesResponse>>> GetMotorcycles([FromQuery(Name = "placa")] string? licensePlate, CancellationToken cancellationToken)
    {
        var request = new GetAllMotorcyclesRequest(LicensePlate: licensePlate);
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpPut("{id}/placa")]
    public async Task<IActionResult> UpdateLicensePlate(string id, UpdateMotorcyclePlateRequest body, CancellationToken cancellationToken)
    {
        var request = new UpdateMotorcycleLicensePlateRequest(Identifier: id, LicensePlate: body.LicensePlate);
        await _mediator.Send(request, cancellationToken);
        return Ok("Placa modificada com sucesso");
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetMotorcycleByIdResponse>> GetMotorcycle(string id, CancellationToken cancellationToken)
    {
        var request = new GetMotorcycleByIdRequest(Id: id);
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMotorcycle(string id, CancellationToken cancellationToken)
    {
        var request = new DeleteMotorcycleRequest(Identifier: id);
        await _mediator.Send(request, cancellationToken);
        return Ok();
    }

}