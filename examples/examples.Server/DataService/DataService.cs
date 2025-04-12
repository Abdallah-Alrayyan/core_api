using examples.Server.Controllers;
using examples.Server.IDataService;
using examples.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace examples.Server.DataService
{
    public class DataService : IDataServicescs
    {
        private readonly MyDbContext _db;

        public DataService(MyDbContext db)
        {
            _db = db;

        }

       
        public List<Product> getproduct()
        {

            var Products = _db.Products.ToList();

            return Products;
        }


     
        public Product getproductById(int id)
        {
            var ProductId = _db.Products.Find(id);
         
                return ProductId;
        }




        public List<Product> GetProductByName(string name)
        {
            var ProductName = _db.Products.Where(x => x.ProductName == name).ToList();

                return ProductName;
       
        }


      
        public Product GetFirstProduct()
        {
            var FirstProduct = _db.Products.First();
            return FirstProduct;
        }



    
        public List<Category> getCategory()
        {

            var Categories = _db.Categories.ToList();

            return Categories;
        }



        public Category getCategoryById(int id)
        {
            var CategoryId = _db.Categories.Find(id);
    
                return CategoryId;

        }


      
        public List<Category> GetCategoryByName(string name)
        {
            var CategoryName = _db.Categories.Where(x => x.CategoryName == name).ToList();

                return CategoryName;

        }


        [HttpGet("getFirstCategory")]
        public Category GetFirstCategory()
        {
            var FirstCategory = _db.Categories.First();
            return FirstCategory;
        }


    }
}
