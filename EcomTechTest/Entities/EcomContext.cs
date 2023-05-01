using Microsoft.EntityFrameworkCore;

namespace EcomTechTest.Entities
{
    public class EcomContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EcomContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ShippingMethod> ShippingMethods { get; set; }

        public DbSet<User> Users { get; set; }

    }
}

