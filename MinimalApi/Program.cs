using FastEndpoints;
using FastEndpoints.Swagger;
using Pruducts.Api.Sevices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();
app.UseFastEndpoints(x =>
{
  
});

app.UseHttpsRedirection();
app.UseOpenApi();
app.UseSwaggerUi3();
app.Run();

