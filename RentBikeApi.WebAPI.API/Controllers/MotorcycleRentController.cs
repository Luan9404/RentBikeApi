using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentBikeApi.Core.Application.UseCases.MotorcycleRent.GetMotorcycleRentById;
using RentBikeApi.Core.Application.UseCases.MotorcycleRent.RegisterRent;

namespace RentBikeApi.WebAPI.API.Controllers;

[ApiController]
[Route("locacao")]
public class MotorcycleRentController(IMediator mediator): ControllerBase
{
   [HttpPost]
   public async Task<IActionResult> RegisterRent(RegisterRentRequest request)
   {
      await mediator.Send(request);
      return Ok(new { message = "Aluguel registrado com sucesso." });
   }
   
   [HttpGet("{id}")]
   public async Task<IActionResult> GetRentById(Guid id)
   {
      var request = new GetMotorcycleRentByIdRequest(id);
      var response = await mediator.Send(request);
      return Ok(response);
   }
    
}