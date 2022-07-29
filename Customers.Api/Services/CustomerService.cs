using Customers.Api.Domain;
using Customers.Api.Repositories;

namespace Customers.Api.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public Task<bool> CreateAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<Customer?> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}