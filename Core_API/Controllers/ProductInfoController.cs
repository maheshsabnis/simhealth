using Core_API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInfoController : ControllerBase
    {
        ProductDbContext db;
        ProductInfo productInfo;
        public ProductInfoController(ProductDbContext db)
        {
            productInfo = new ProductInfo();
            this.db = db;
        }

        // GET: api/<ProductInfoController>
        [HttpGet]
        public  IEnumerable<ProductInfo> Get()
        {
            return db.Products;
        }

        

        // POST api/<ProductInfoController>
        [HttpPost]
        public IEnumerable<ProductInfo> Post([FromBody] ProductInfo value)
        {
            db.Products.Add(value);
            db.SaveChanges();
            return db.Products;
        }

         
    }
}
