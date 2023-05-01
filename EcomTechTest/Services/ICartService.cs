using EcomTechTest.Modals;

namespace EcomTechTest.Services
{
    public interface ICartService
    {

        bool CheckCartExists(int id);

        int CreateCart();

        IEnumerable<CartProduct> GetCart(int id);

        void DeleteCart(int id);

        IEnumerable<CartProduct> AddProductToCart(CartUpdate cartupdateinfo);

        IEnumerable<CartProduct> RemoveProductFromCart(CartUpdate cartupdateinfo);

        IEnumerable<CartProduct> UpdateCartQuantity(CartUpdate cartupdateinfo);
    }
}
