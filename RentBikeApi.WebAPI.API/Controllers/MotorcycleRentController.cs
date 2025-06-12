using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentBikeApi.Core.Application.UseCases.MotorcycleRent.RegisterRent;

namespace RentBikeApi.WebAPI.API.Controllers;

[ApiController]
[Route("[controller]")]
public class MotorcycleRentController(IMediator mediator): ControllerBase
{
   [HttpPost]
   public async Task<IActionResult> RegisterRent(RegisterRentRequest request)
   {
      await mediator.Send(request);
      return Ok(new { message = "Aluguel registrado com sucesso." });
   }
    
}