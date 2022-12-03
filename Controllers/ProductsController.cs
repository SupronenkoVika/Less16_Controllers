using Less16_Controllers.Models.Domain;
using Less16_Controllers.Services;
using Microsoft.AspNetCore.Mvc;

namespace Less16_Controllers.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductsController : Controller
    {
        InventoryService Service;
        public ProductsController(InventoryService service)
        {
            Service = service;
        }

        [HttpPost]
        public IActionResult AddProduct(Products product)
        {
            Service.AddProduct(product);
            return Created($"Product {product.Name}", product);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(Service.GetAllProduct());
        }

        [HttpPut]
        public IActionResult UpdateProduct(int prodId, Products product)
        {
            Service.UpdateProduct(prodId, product);
            return Created($"Replase {product.Name}", product);
        }
    }
}
