using Customers.Api.Contracts.Responses;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Customers.Api.Endpoints;

[HttpGet("customers"), AllowAnonymous]
public class GetAllCustomersEndpoint : EndpointWithoutRequest<GetAllCustomersResponse>
{
    public override async Task HandleAsync(CancellationToken ct)
    {
        var customer = new CustomerResponse()
        {
            Id = Guid.NewGuid(),
            Username = "Thomas-Giesbrecht",
            FullName = "Thomas Giesbrecht",
            Email = "mail@gmail.com",
            DateOfBirth = new DateTime(2022, 7, 25)
        };

        var response = new GetAllCustomersResponse
        {
            Customers = new List<CustomerResponse> {customer}
        };
        
        await SendOkAsync(response, ct);
    }
}