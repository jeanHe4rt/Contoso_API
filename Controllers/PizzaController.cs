using Contoso_API.Models;
using Contoso_API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Contoso_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {

        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

        // GET by Id action

        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(string id)
        {
            var pizza = PizzaService.Get(id);
            if(pizza == null)
            {
                return NotFound();
            }

            return pizza;
        }


        // POST action

        // PUT action

        // DELETE action
    }
}
