using System;
using FurnitureStore.api.Dtos;
using FurnitureStore.api.Entities;

namespace FurnitureStore.api.Mapping;

public static class FurnitureMapping
{

    public static Furniture ToEntity(this CreateFurnitureDto furniture)
    {
        return new Furniture()
        {
            Name = furniture.Name,
            TypeId = furniture.FTypeId,
            Price = furniture.Price,
            ReleaseDate = furniture.ReleaseDate
        };
    }

    public static Furniture ToDto(this Furniture furniture){   
        return new(
                furniture.Id,
                furniture.Name,
                furniture.FType!.Name,
                furniture.Price,
                furniture.ReleaseDate
        );
    }

}
