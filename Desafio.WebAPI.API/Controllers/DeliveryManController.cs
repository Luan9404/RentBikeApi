using Desafio.Core.Application.UseCases.DeliveryMan.RegisterDeliveryMan;
using Desafio.Core.Application.UseCases.DeliveryMan.UploadDeliveryManDriverLicense;
using Desafio.WebAPI.API.Models.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.WebAPI.API.Controllers;

[ApiController]
[Route("entregadores")]
public class DeliveryManController(IMediator mediator): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(RegisterDeliveryManRequest request, CancellationToken cancellationToken)
    {
        await mediator.Send(request, cancellationToken);
        return Created("", null);
    }

    [HttpPut("{id}/cnh")]
    public async Task<IActionResult> UploadDriverLicense(UploadDriverLicenseRequest request, 
        string id,
        CancellationToken cancellationToken)
    {
        var body = new UploadDeliveryManDriverLicenseRequest(Image: request.Image, Identifier: id);
        await mediator.Send(body, cancellationToken);
        return Ok("atualizado");
    }
}