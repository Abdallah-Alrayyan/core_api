using examples.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace examples.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class category : ControllerBase
    {
        private readonly MyDbContext _db;

        public category(MyDbContext db)
        {
            _db = db;

        }

        [HttpGet("getProduct")]
        public IActionResult getproduct() {

            var abd =  _db.Products.ToList();

            return Ok(abd);
        }

        [HttpGet("getProductById")]
        public IActionResult getproductById(int id)
        {
            var ProductId = _db.Products.FirstOrDefault(x => x.ProductId == id);
            if (ProductId != null)
            {
                return Ok(ProductId);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getProductByName")]
        public IActionResult GetProductByName(string name)
        {
            var ProductName = _db.Products.FirstOrDefault(x => x.ProductName == name);
            if (ProductName != null)
            {
                return Ok(ProductName);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getFirstProduct")]
        public IActionResult GetFirstProduct()
        {
            var FirstProduct = _db.Products.First();
            return Ok(FirstProduct);
        }

        //-------------------------------------

        [HttpGet("getCategory")]
        public IActionResult getCategory()
        {

            var abd = _db.Categories.ToList();

            return Ok(abd);
        }


        [HttpGet("getCategoryById")]
        public IActionResult getCategoryById(int id)
        {
            var CategoryId = _db.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (CategoryId != null)
            {
                return Ok(CategoryId);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getCategoryByName")]
        public IActionResult GetCategoryByName(string name)
        {
            var CategoryName = _db.Categories.FirstOrDefault(x => x.CategoryName == name);
            if (CategoryName != null)
            {
                return Ok(CategoryName);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getFirstCategory")]
        public IActionResult GetFirstCategory()
        {
            var FirstCategory = _db.Categories.First();
            return Ok(FirstCategory);
        }


    }
}
