using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Bánh mì" },
            new Product() { Id = 2, Name = "Kẹo lạc" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }
    }
}
