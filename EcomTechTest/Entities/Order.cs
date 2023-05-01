namespace EcomTechTest.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public DateTime OrderPlacedOnDate { get; set; }
        public int ShippingMethodId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostCode { get; set; }

        public User User { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
