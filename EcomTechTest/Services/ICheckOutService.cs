namespace EcomTechTest.Services
{
    public interface ICheckOutService
    {
        int CreateNewOrder();

        void GetShippingMethods();

        void UpdateOrderShippingMethod();

        int CreateGuestUser(string name);

    }
}
