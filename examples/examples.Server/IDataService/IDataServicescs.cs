using examples.Server.Models;

namespace examples.Server.IDataService
{
    public interface IDataServicescs
    {
        public List<Product> getproduct();
        public Product getproductById(int id);
        public List<Product> GetProductByName(string name);
        public Product GetFirstProduct();


        public List<Category> getCategory();
        public Category getCategoryById(int id);
        public List<Category> GetCategoryByName(string name);
        public Category GetFirstCategory();
    }
}
