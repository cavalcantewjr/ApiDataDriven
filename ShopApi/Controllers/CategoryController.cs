using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopApi.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            return new List<Category>();
        }

        [HttpGet]
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "GET" + id;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Post([FromBody]Category model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(model);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> Put(int id, [FromBody] Category model)
        {
            if(model.Id == id)
                return NotFound(new { message = "Categoria não encontrada"});//objeto dinamico. Que não tem um tipo.

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(model);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public string Delete()
        {
            return "DELETE";
        }
    }
}
