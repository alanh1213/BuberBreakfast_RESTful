using BuberBreakfast.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("breakfast")]
    public class BreakfastController : ControllerBase
    {
        [HttpPost()]
        public IActionResult CreateBreakfast(CreateBreakfastDTO createBreakfastDTO)
        {
            return Ok(createBreakfastDTO);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertBreakfast(Guid Id, CreateBreakfastDTO createBreakfastDTO)
        {
            return Ok(createBreakfastDTO);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }
    }
}
