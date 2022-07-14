using Pruducts.Api.Entities;

namespace Pruducts.Api.Sevices
{
    public class ProductService : IProductService
    {
        public async Task<IEnumerable<ProductEntity>> GetAllProducts()
        {
            return await Task.FromResult(Enumerable.Range(1, new Random().Next(1,20))
                .Select((x, i) => new ProductEntity { Id = Guid.NewGuid(), Name = $"Product - {i}", Price = new Random().Next(1, 200) }));
        }

        public async Task<ProductEntity> AddProduct(ProductEntity entity) => await Task.FromResult(new ProductEntity
        {
            Id = Guid.NewGuid(),
            Name = entity.Name,
            Price = entity.Price
        });
    }
}

