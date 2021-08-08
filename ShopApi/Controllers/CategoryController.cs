using Microsoft.AspNetCore.Mvc;

namespace ShopApi.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "GET";
        }

        [HttpGet]
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "GET" + id;
        }

        [HttpPost]
        [Route("")]
        public string Post()
        {
            return "POST";
        }

        [HttpPut]
        [Route("")]
        public string Put()
        {
            return "PUT";
        }

        [HttpDelete]
        [Route("")]
        public string Delete()
        {
            return "DELETE";
        }
    }
}
