using BusinessLogic.ApiModels.Products;
using BusinessLogic.Interfaces;
using DataAccess.Data;
using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService service;

        public ProductsController(IProductsService service)
        {
            this.service = service;
        }

        [HttpGet("all")]
        public IActionResult Get()
        {
            return Ok(service.Get()); // status: 200
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(service.Get(id));
        }

        [HttpPost]
        public IActionResult Create(CreateProductModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            service.Create(model);

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(EditProductModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            service.Edit(model);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            service.Delete(id);

            return Ok();
        }
    }
}
