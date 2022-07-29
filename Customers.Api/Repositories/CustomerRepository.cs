using Customers.Api.Contracts.Data;
using Customers.Api.Database;

namespace Customers.Api.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private IDbConnectionFactory _connectionFactory;

    public CustomerRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public Task<bool> CreateAsync(CustomerDto customer)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDto?> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}