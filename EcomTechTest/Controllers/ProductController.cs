using EcomTechTest.Modals;
using EcomTechTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcomTechTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {

        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;

        public ProductController(ILogger<ProductController> logger,
                                 IProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }

        [HttpGet(Name = "GetProduct")]
        public ActionResult<ProductInfo> GetProduct(int id)
        {
            if (this.productService.ProductExists(id))
            {
                return StatusCode(404, "Product Not Found");
            }
            return this.productService.GetProduct(id);
        }


        [HttpGet(Name = "GetAllProducts")]
        public ActionResult<IEnumerable<ProductInfo>> GetAllProducts()
        {
            return this.productService.GetProducts().ToList();
        }
    }
}
