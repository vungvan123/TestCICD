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
            new Product() { Id = 2, Name = "Kẹo lạc" },
            new Product() { Id = 3, Name = "Cánh gà chiên mắm" },
            new Product() { Id = 4, Name = "Tôm chiên xù" },
            new Product() { Id = 5, Name = "Đùi gà sốt me" },
            new Product() { Id = 6, Name = "XXXX" },
            new Product() { Id = 7, Name = "XYZ" },
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }
    }
}
