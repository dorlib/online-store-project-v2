using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using storeAPI.Data.Interfaces;

namespace storeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryItemController : ControllerBase
    {

        private readonly IGroceryItemRepository _groceryItemRepository;

        public GroceryItemController(IGroceryItemRepository groceryItemRepository)
        {
            _groceryItemRepository = groceryItemRepository;
        }

        [HttpGet("GetGroceryItems")]
        public async Task<IActionResult> GetPlayers()
        {
            var itmes = await _groceryItemRepository.GetGroceryItems();
            return Ok(itmes);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post([FromBody] GroceryItem item)
        {
            var items = await _groceryItemRepository.CreateGroceryItem(item);
            return Ok(items);
        }


        [HttpPut("Put")]
        public async Task<IActionResult> Put([FromBody] GroceryItem item)
        {
            var items = await _groceryItemRepository.EditGroceryItem(item);
            return Ok(items);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var items = await _groceryItemRepository.DeleteGroceryItem(id);
            return Ok(items);
        }
    }
}
