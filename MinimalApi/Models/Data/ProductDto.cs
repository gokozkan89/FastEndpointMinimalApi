using System;
namespace Pruducts.Api.Models.Data
{
	public class ProductDto
	{
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}

