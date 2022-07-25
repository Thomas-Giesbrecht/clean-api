using Customers.Api.Contracts.Requests;
using Customers.Api.Contracts.Responses;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Customers.Api.Endpoints;

[HttpGet("customers/{id:guid}"), AllowAnonymous]
public class GetCustomerEndpoint : Endpoint<GetCustomerRequest, CustomerResponse>
{
    public override async Task HandleAsync(GetCustomerRequest req, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}