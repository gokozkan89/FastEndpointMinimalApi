using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Pruducts.Api.Entities;
using Pruducts.Api.Mappers;
using Pruducts.Api.Models.Requests;
using Pruducts.Api.Models.Responses;
using Pruducts.Api.Sevices;

namespace Pruducts.Api.Endpoints
{
    [HttpPost("products/add"), AllowAnonymous]
    public class AddProductEndpoint : Endpoint<AddProductRequest, AddProductResponse>
    {
        private readonly IProductService _productService;

        public AddProductEndpoint(IProductService productService)
        {
            _productService = productService;
        }

        public override async Task HandleAsync(AddProductRequest req, CancellationToken ct)
        {
            AddProductResponse response = new();

            var addedProduct = await _productService.AddProduct(ToProducEntity(req));
            response.Product = addedProduct.ToProductDto();

            await SendOkAsync(response);
        }

        private ProductEntity ToProducEntity(AddProductRequest request)
            => new ProductEntity { Name = request.Name, Price = request.Price };
    }
}

