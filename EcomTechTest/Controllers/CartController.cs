using EcomTechTest.Modals;
using EcomTechTest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EcomTechTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> logger;
        private readonly ICartService cartService;

        public OrderController(ILogger<OrderController> logger,
                               ICartService cartService)
        {
            this.logger = logger;
            this.cartService = cartService;
        }

        [HttpPost(Name = "CreateGuestCart")]
        public ActionResult<int> CreateGuestCart()
        {
            return this.cartService.CreateCart();
        }

        [HttpPost(Name = "AddToCart")]
        public ActionResult<IEnumerable<CartProduct>> AddToCart(CartUpdate cartupdateinfo)
        {
            if (this.cartService.CheckCartExists(cartupdateinfo.CartId))
            {
                return StatusCode(404, "Cart Not Found");
            }
            var result = this.cartService.AddProductToCart(cartupdateinfo);
            return result.ToList();
        }

        [HttpPost(Name = "UpdateQuantity")]
        public ActionResult<IEnumerable<CartProduct>> UpdateQuantity(CartUpdate cartupdateinfo)
        {
            if (this.cartService.CheckCartExists(cartupdateinfo.CartId))
            {
                return StatusCode(404, "Cart Not Found");
            }
            var result = this.cartService.UpdateCartQuantity(cartupdateinfo);
            return result.ToList();
        }

        [HttpPost(Name = "RemoveFromCart")]
        public ActionResult<IEnumerable<CartProduct>> RemoveFromCart(CartUpdate cartupdateinfo)
        {
            if (this.cartService.CheckCartExists(cartupdateinfo.CartId)) {
                return StatusCode(404, "Cart Not Found");
            }
            var result = this.cartService.RemoveProductFromCart(cartupdateinfo);
            return result.ToList();
        }
    }
}
