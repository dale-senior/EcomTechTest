using EcomTechTest.Modals;
using EcomTechTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcomTechTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> logger;
        private readonly ICheckOutService checkoutService;

        public CheckoutController(ILogger<CheckoutController> logger,
                                  ICheckOutService checkoutService)
        {
            this.logger = logger;
            this.checkoutService = checkoutService;
        }

        [HttpPost(Name = "SetCustomerAddress")]
        public ActionResult<string> SetCustomerAddress(OrderDetails customerOrder)
        {
            return "";
        }

        [HttpPost(Name = "GetShippingMethods")]
        public ActionResult<string> GetShippingMethods(OrderDetails customerOrder)
        {
            return "";
        }


        [HttpPost(Name = "SetCustomerShippingMethod")]
        public ActionResult<string> SetCustomerShippingMethod(OrderDetails customerOrder)
        {
            return "";
        }


        [HttpPost(Name = "CompleteOrder")]
        public ActionResult<string> CompleteOrder(OrderDetails customerOrder)
        {
            return "";
        }


    }
}
