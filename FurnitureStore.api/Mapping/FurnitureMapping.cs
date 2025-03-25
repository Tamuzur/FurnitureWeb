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
            FTypeId = furniture.FTypeId,
            Price = furniture.Price,
            ReleaseDate = furniture.ReleaseDate
        };
    }

    public static FurnitureDto ToDto(this Furniture furniture)
    {   
        return new FurnitureDto(
                furniture.Id,
                furniture.Name,
                furniture.FType!.Name,
                furniture.Price,
                furniture.ReleaseDate
        );
    }

    public static FurnitureDetailsDto ToFurnitureDetailsDto(this Furniture furniture)
    {   
        return new FurnitureDetailsDto(
                furniture.Id,
                furniture.Name,
                furniture.FTypeId,
                furniture.Price,
                furniture.ReleaseDate
        );
    }

    public static Furniture ToEntity(this UpdateFurnitureDto furniture, int id)
    {
        return new Furniture()
        {
            Id = id,
            Name = furniture.Name,
            FTypeId = furniture.FTypeId,
            Price = furniture.Price,
            ReleaseDate = furniture.ReleaseDate
        };
    }

}
