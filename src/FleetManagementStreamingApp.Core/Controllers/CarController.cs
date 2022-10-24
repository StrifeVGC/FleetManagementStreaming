using FleetManagementStreamingApp.Common.DTOs;
using FleetManagementStreamingApp.Infrastructure.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagementStreamingApp.Core.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<CarDTO>> GetAllCars()
        {
            try
            {
                var result = await _carService.GetAllCars();

                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarDTO>> GetCarById([FromRoute] string id)
        {
            var result = await _carService.GetCarById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
