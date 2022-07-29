using Customers.Api.Domain;

namespace Customers.Api.Services;

/// <summary>
/// Knows how to interact with customers.
/// </summary>
public interface ICustomerService
{
    /// <summary>
    /// Creates a new customer.
    /// </summary>
    /// <param name="customer">The customer to be created.</param>
    /// <returns>True, if creation was successful.</returns>
    Task<bool> CreateAsync(Customer customer);

    /// <summary>
    /// Get a specific customer by id.
    /// </summary>
    /// <param name="id">The id of the customer.</param>
    /// <returns>Returns the customer.</returns>
    Task<Customer?> GetAsync(Guid id);

    /// <summary>
    /// Get all customers.
    /// </summary>
    /// <returns>Returns all customers.</returns>
    Task<IEnumerable<Customer>> GetAllAsync();
}