using FleetManagementStreamingApp.Common.DTOs;
using FleetManagementStreamingApp.Infrastructure.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagementStreamingApp.Core.Controllers
{
    [ApiController]
    [Route("api/brands")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<ActionResult<BrandDTO>> GetAllBrands()
        {
            var result = await _brandService.GetAllBrands();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarDTO>> GetBrandById([FromRoute] string id)
        {
            var result = await _brandService.GetBrandById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
