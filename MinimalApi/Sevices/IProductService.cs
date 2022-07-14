using System;
using Pruducts.Api.Entities;

namespace Pruducts.Api.Sevices
{
	public interface IProductService
	{
        public Task<IEnumerable<ProductEntity>> GetAllProducts();
        public Task<ProductEntity> AddProduct(ProductEntity entity);
    }
}

