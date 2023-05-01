namespace EcomTechTest.Modals
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public OrderProduct[] Products { get; set; }
    }
}
