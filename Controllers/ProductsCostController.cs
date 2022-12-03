using Less16_Controllers.Services;
using Microsoft.AspNetCore.Mvc;

namespace Less16_Controllers.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductsCostController : Controller
    {
        InventoryService Service;
        public ProductsCostController(InventoryService service)
        {
            Service = service;
        }
        [HttpGet]
        public IActionResult AllProductsCost()
        {
            return Ok(Service.AllProductCost());
        }
    }
}
