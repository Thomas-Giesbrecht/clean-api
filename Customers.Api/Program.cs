using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();

var app = builder.Build();

app.UseFastEndpoints();

app.UseOpenApi();
app.UseSwaggerUi3(x => x.ConfigureDefaults());

app.UseHttpsRedirection();
app.Run();