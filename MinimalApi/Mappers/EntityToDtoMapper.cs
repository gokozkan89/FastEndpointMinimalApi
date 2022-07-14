using System;
using Pruducts.Api.Entities;
using Pruducts.Api.Models.Data;

namespace Pruducts.Api.Mappers
{
	public static class EntityToDtoMapper
	{
        public static ProductDto ToProductDto(this ProductEntity entity) => new()
        {
			Id = entity.Id,
			Name = entity.Name,
			Price = entity.Price
		};

		public static IEnumerable<ProductDto> ToProductDto(this IEnumerable<ProductEntity> entities)
			=> entities.Select(x => x.ToProductDto());
	}

}

