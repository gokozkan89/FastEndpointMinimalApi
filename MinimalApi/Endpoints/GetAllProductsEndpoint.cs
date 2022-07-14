using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Pruducts.Api.Mappers;
using Pruducts.Api.Models.Responses;
using Pruducts.Api.Sevices;

namespace Pruducts.Api.Endpoints
{
	[HttpGet("products/all"), AllowAnonymous]
	public class GetAllProductsEndpoint : EndpointWithoutRequest<GetAllProductsResponse>
	{
		private readonly IProductService _productService;

        public GetAllProductsEndpoint(IProductService productService)
        {
            _productService = productService;
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var allProducts = await _productService.GetAllProducts();
            await SendOkAsync( new GetAllProductsResponse { Products = allProducts.ToProductDto().ToList() });
        }
    }
}

