using System;
namespace Pruducts.Api.Entities
{
	public class ProductEntity
	{
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}

