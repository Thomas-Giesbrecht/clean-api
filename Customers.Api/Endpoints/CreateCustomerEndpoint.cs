using Customers.Api.Contracts.Requests;
using Customers.Api.Contracts.Responses;
using Customers.Api.Mapping;
using Customers.Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Customers.Api.Endpoints;

[HttpPost("customers"), AllowAnonymous]
public class CreateCustomerEndpoint : Endpoint<CreateCustomerRequest, CustomerResponse>
{
   private readonly ICustomerService _customerService;

   public CreateCustomerEndpoint(ICustomerService customerService)
   {
      _customerService = customerService;
   }
   
   public override async Task HandleAsync(CreateCustomerRequest request, CancellationToken ct)
   {
      var customer = request.ToCustomer();

      await _customerService.CreateAsync(customer);

      var customerResponse = customer.ToCustomerResponse();
      await SendCreatedAtAsync<GetCustomerEndpoint>(new { }, customerResponse, generateAbsoluteUrl: true, cancellation: ct);
   }
}