using Pruducts.Api.Entities;
using Pruducts.Api.Models.Data;

namespace Pruducts.Api.Mappers
{
	public static class DTOToEntityMapper
	{
		public static ProductEntity ToProductEntity(this ProductDto dto) => new ProductEntity
		{
			Id = dto.Id,
			Name = dto.Name,
			Price = dto.Price
		};

		public static IEnumerable<ProductEntity> ToProductEntity(this IEnumerable<ProductDto> dtos) =>
			dtos.Select(x => x.ToProductEntity());
	}
}

