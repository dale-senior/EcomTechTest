using AutoMapper;
using EcomTechTest.Entities;
using EcomTechTest.Entities.helpers;
using EcomTechTest.Services;

public class CheckOutService : ICheckOutService
{
    private readonly IMapper mapper;
    private readonly IRepository<User> userRepository;

    public CheckOutService(IMapper mapper,
                           IRepository<User> userRepository) 
    { 
        this.mapper = mapper;
        this.userRepository = userRepository;
    }   

    public int CreateGuestUser(string name)
    {
        User user = new User(name);
        var result = this.userRepository.Add(user);
        return result.ID;
    }

    public int CreateNewOrder()
    {
        throw new NotImplementedException();
    }

    public void GetShippingMethods()
    {
        throw new NotImplementedException();
    }

    public void UpdateOrderShippingMethod()
    {
        throw new NotImplementedException();
    }
}