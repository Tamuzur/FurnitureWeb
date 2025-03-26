using FurnitureStore.api.Dtos;
using FurnitureStore.api.Entities;


namespace FurnitureStore.api.Mapping;

public static class FTypeMapping
{

    public static FTypeDto ToDto(this FType ftype)
    {
        return new FTypeDto(ftype.Id, ftype.Name);
    }

}
