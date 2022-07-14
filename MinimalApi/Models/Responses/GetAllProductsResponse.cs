using Pruducts.Api.Models.Data;

namespace Pruducts.Api.Models.Responses
{
	public class GetAllProductsResponse
	{
        public IList<ProductDto>? Products { get; set; }
    }
}

