using AutoMapper;
using EcomTechTest.Entities;
using EcomTechTest.Entities.helpers;
using EcomTechTest.Modals;

namespace EcomTechTest.Services.Implementation
{
    public class CartService : ICartService
    {
        private readonly IRepository<Cart> cartRepo;
        private readonly IRepository<CartItem> cartItemRepo;
        private readonly IMapper mapper;
        public CartService(IRepository<Cart> cartRepo,
                           IRepository<CartItem> cartItemRepo,
                           IMapper mapper) 
        { 
            this.cartRepo = cartRepo;
            this.cartItemRepo = cartItemRepo;
            this.mapper = mapper;
        }

        public IEnumerable<CartProduct> AddProductToCart(CartUpdate cartupdateinfo)
        {

            if (this.CheckCartExists(cartupdateinfo.CartId))
            {
                var result = mapper.Map<CartItem>(cartupdateinfo);
                this.cartItemRepo.Add(result);
            }

            return this.GetCart(cartupdateinfo.CartId);
        }

        public bool CheckCartExists(int cartId)
        {
            return this.cartRepo.Exists(cartId);
        }

        public int CreateCart()
        {
            return this.cartRepo.Add(new Cart()).ID;
        }

        public void DeleteCart(int cartId)
        {
            if (this.CheckCartExists(cartId))
            {
                this.cartRepo.RemoveById(cartId);
            }
        }

        public IEnumerable<CartProduct> GetCart(int cartId)
        {
            if (this.CheckCartExists(cartId))
            {
                var products = this.cartRepo.GetById(cartId).CartItems;
                if (products != null)
                {
                    return mapper.Map<IEnumerable<CartProduct>>(products);
                }
            }
            return Enumerable.Empty<CartProduct>();
        }

        public IEnumerable<CartProduct> RemoveProductFromCart(CartUpdate cartupdateinfo)
        {
            if (this.CheckCartExists(cartupdateinfo.CartId))
            {
                var cart = this.cartRepo.GetById(cartupdateinfo.CartId);
                var item = cart.CartItems.Where(w => w.ProductId == cartupdateinfo.ProductId).FirstOrDefault();
                if (item != null)
                {
                    cart.CartItems.Remove(item);
                }
            }
            return this.GetCart(cartupdateinfo.CartId);
        }

        public IEnumerable<CartProduct> UpdateCartQuantity(CartUpdate cartupdateinfo)
        {
            if (this.CheckCartExists(cartupdateinfo.CartId))
            {
                var cart = this.cartRepo.GetById(cartupdateinfo.CartId);
                var item = cart.CartItems.Where(w => w.ProductId == cartupdateinfo.ProductId).FirstOrDefault();
                if (item != null)
                {
                    item.Quantity = cartupdateinfo.Quanitity;
                    this.cartRepo.SaveChanges();
                }
            }
            return this.GetCart(cartupdateinfo.CartId);
        }
    }
}
