using FurnitureStore.api.Data;
using FurnitureStore.api.Dtos;
using FurnitureStore.api.Entities;

namespace FurnitureStore.api.Endpoints;

public static class FurnitureEndpoints
{
    private static readonly List<FurnitureDto> furnitures = [
        new FurnitureDto(1, "Modern Chair", "Chair", 120.99m, new DateOnly(2023, 5, 20)),
        new FurnitureDto(2, "Oak Table", "Table", 450.50m, new DateOnly(2022, 8, 15)),
        new FurnitureDto(3, "Leather Sofa", "Sofa", 899.99m, new DateOnly(2021, 12, 10)),
    ];

    public static RouteGroupBuilder MapFurnituresEndpoints(this WebApplication app)
    {

        var group = app.MapGroup("furnitures")
        .WithParameterValidation();   

        //GET /furnitures
        group.MapGet("/", () => furnitures);

        //GET /furnitures/1
        group.MapGet("/{id}", (int id) =>
        {
            FurnitureDto? furniture = furnitures.Find(furnitures => furnitures.Id == id);
            return furniture is null ? Results.NotFound() : Results.Ok(furniture);
        })
        .WithName("GetFurniture");
        
        //POST /Furnitures
        group.MapPost("/", (CreateFurnitureDto newFurniture, FurnitureStoreContext dbContext) =>
        {
            Furniture furniture = new()
            {
                Name = newFurniture.Name,
                FType = dbContext.FTypes.Find(newFurniture.FTypeId),
                TypeId = newFurniture.FTypeId,
                Price = newFurniture.Price,
                ReleaseDate = newFurniture.ReleaseDate
            };

            dbContext.Furnitures.Add(furniture);
            dbContext.SaveChanges();

            FurnitureDto furnitureDto = new(
                furniture.Id,
                furniture.Name,
                furniture.FType!.Name,
                furniture.Price,
                furniture.ReleaseDate

            );

            return Results.CreatedAtRoute("GetFurniture", new { id = furniture.Id }, furnitureDto);
        })
        .WithParameterValidation();

        //PUT /furnitures
        group.MapPut("/{id}", (int id, UpdateFurnitureDto updatedFurniture) =>
        {
            var index = furnitures.FindIndex(furniture => furniture.Id == id);

            if (index == -1)
            {
                return Results.NotFound();
            }

            furnitures[index] = new FurnitureDto(
                id,
                updatedFurniture.Name,
                updatedFurniture.Type,
                updatedFurniture.Price,
                updatedFurniture.ReleaseDate
            );

            return Results.NoContent();

        });


        //DELETE /furnitures/1
        group.MapDelete("/{id}", (int id) =>
        {
            furnitures.RemoveAll(furniture => furniture.Id == id);

            return Results.NoContent();

        });

        return group;
    }


}
