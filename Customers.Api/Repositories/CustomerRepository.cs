using Customers.Api.Contracts.Data;
using Customers.Api.Database;
using Dapper;

namespace Customers.Api.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CustomerRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<bool> CreateAsync(CustomerDto customer)
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(
            @"INSERT INTO Customers (Id, Username, FullName, Email, DateOfBirth) 
            VALUES (@Id, @Username, @FullName, @Email, @DateOfBirth)",
            customer);
        return result > 0;
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