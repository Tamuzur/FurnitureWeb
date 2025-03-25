using FurnitureStore.api.Data;
using FurnitureStore.api.Dtos;
using FurnitureStore.api.Entities;
using FurnitureStore.api.Mapping;
using Microsoft.EntityFrameworkCore;

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
        group.MapGet("/", (FurnitureStoreContext dbContext) => 
            dbContext.Furnitures.Include(furniture => furniture.FType)
            .Select(furniture => furniture.ToDto())
            .AsNoTracking());

        //GET /furnitures/1
        group.MapGet("/{id}", (int id, FurnitureStoreContext dbContext) =>
        {
            Furniture? furniture = dbContext.Furnitures.Find(id);
            return furniture is null ? 
                Results.NotFound() : Results.Ok(furniture.ToFurnitureDetailsDto());
        })
        .WithName("GetFurniture");
        
        //POST /Furnitures
        group.MapPost("/", (CreateFurnitureDto newFurniture, FurnitureStoreContext dbContext) =>
        {
            Furniture furniture = newFurniture.ToEntity();
            furniture.FType = dbContext.FTypes.Find(newFurniture.FTypeId);


            dbContext.Furnitures.Add(furniture);
            dbContext.SaveChanges();


            return Results.CreatedAtRoute(
                "GetFurniture", 
                new { id = furniture.Id }, 
                furniture.ToFurnitureDetailsDto()
            );
        })
        .WithParameterValidation();

        //PUT /furnitures
        group.MapPut("/{id}", (int id, UpdateFurnitureDto updatedFurniture, FurnitureStoreContext dbContext ) =>
        {

            var existingFurniture = dbContext.Furnitures.Find(id);

            if (existingFurniture == null)
            {
                return Results.NotFound();
            }

            dbContext.Entry(existingFurniture).CurrentValues.SetValues(updatedFurniture.ToEntity(id));
            dbContext.SaveChanges();

            return Results.NoContent();

        });


        //DELETE /furnitures/1
        group.MapDelete("/{id}", (int id, FurnitureStoreContext dbContext) =>
        {
            dbContext.Furnitures
                .Where(furniture => furniture.Id==id)
                .ExecuteDelete();

            return Results.NoContent();

        });

        return group;
    }


}
