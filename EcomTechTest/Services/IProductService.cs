using EcomTechTest.Modals;

namespace EcomTechTest.Services
{
    public interface IProductService
    {
        IEnumerable<ProductInfo> GetProducts();

        ProductInfo GetProduct(int id);

        bool ProductExists(int id);
    }
}
