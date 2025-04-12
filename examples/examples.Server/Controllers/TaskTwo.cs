using examples.Server.IDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace examples.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskTwo : ControllerBase
    {
        private readonly IDataServicescs _data;

        public TaskTwo(IDataServicescs data)
        {
            _data = data;
        }



        [HttpGet("getProduct")]
        public IActionResult getproduct()
        {

            var Products = _data.getproduct();
            return Ok(Products);
        }



        [HttpGet("getProductById")]
        public IActionResult getproductById(int id)
        {
            var ProductId = _data.getproductById(id);
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
            var ProductName = _data.GetProductByName(name);
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
            var FirstProduct = _data.GetFirstProduct();
            return Ok(FirstProduct);
        }



        [HttpGet("getCategory")]
        public IActionResult getCategory()
        {

            var Categorys = _data.getCategory();

            return Ok(Categorys);
        }


        [HttpGet("getCategoryById")]
        public IActionResult getCategoryById(int id)
        {
            var CategoryId = _data.getCategoryById(id);
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
            var CategoryName = _data.GetCategoryByName(name);
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
            var FirstCategory = _data.GetFirstCategory();
            return Ok(FirstCategory);
        }

        //[HttpDelete("deleteProduct/{id}")]
        //public IActionResult DeleteProduct () {
        
        //    var DeleteProduct = _data.DeleteProduct();
        //    return Ok(DeleteProduct);

        //}
        // phantom Was here






    }
}
