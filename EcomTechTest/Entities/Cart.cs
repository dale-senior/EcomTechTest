namespace EcomTechTest.Entities
{
    public class Cart
    {
        public int ID { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
