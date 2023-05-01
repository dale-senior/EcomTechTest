using AutoMapper;
using EcomTechTest.Entities;
using EcomTechTest.Entities.helpers;
using EcomTechTest.Modals;
using System.Security.AccessControl;

namespace EcomTechTest.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepo;
        private readonly IMapper mapper;
        public ProductService(IRepository<Product> productRepo,
                              IMapper mapper) 
        {
            this.productRepo = productRepo;
            this.mapper = mapper;
        }

        public bool ProductExists (int id) 
        { 
            return this.productRepo.Exists(id);
        }

        public ProductInfo GetProduct(int id)
        {
            var prod = this.productRepo.GetById(id);
            return this.mapper.Map<ProductInfo>(prod);
        }

        public IEnumerable<ProductInfo> GetProducts()
        {
            var products = this.productRepo.GetAll();
            return this.mapper.Map<IEnumerable<ProductInfo>>(products);
        }
    }
}
