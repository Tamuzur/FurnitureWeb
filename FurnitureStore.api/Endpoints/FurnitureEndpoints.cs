using FurnitureStore.api.Data;
using FurnitureStore.api.Dtos;
using FurnitureStore.api.Entities;
using FurnitureStore.api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.api.Endpoints;

public static class FurnitureEndpoints
{
    public static RouteGroupBuilder MapFurnituresEndpoints(this WebApplication app)
    {

        var group = app.MapGroup("furnitures")
        .WithParameterValidation();   

        //GET /furnitures
        group.MapGet("/", async (FurnitureStoreContext dbContext) => 
            await dbContext.Furnitures.Include(furniture => furniture.FType)
            .Select(furniture => furniture.ToDto())
            .AsNoTracking()
            .ToListAsync());

        //GET /furnitures/1
        group.MapGet("/{id}", async (int id, FurnitureStoreContext dbContext) =>
        {
            
            Furniture? furniture = await dbContext.Furnitures.FindAsync(id);
            return furniture is null ? 
                Results.NotFound() : Results.Ok(furniture.ToFurnitureDetailsDto());
        })
        .WithName("GetFurniture");
        
        //POST /Furnitures
        group.MapPost("/", async (CreateFurnitureDto newFurniture, FurnitureStoreContext dbContext) =>
        {
            Furniture furniture = newFurniture.ToEntity();
            furniture.FType = dbContext.FTypes.Find(newFurniture.FTypeId);


            dbContext.Furnitures.Add(furniture);
            await dbContext.SaveChangesAsync();


            return Results.CreatedAtRoute(
                "GetFurniture", 
                new { id = furniture.Id }, 
                furniture.ToFurnitureDetailsDto()
            );
        })
        .WithParameterValidation();

        //PUT /furnitures
        group.MapPut("/{id}", async (int id, UpdateFurnitureDto updatedFurniture, FurnitureStoreContext dbContext ) =>
        {
 
            var existingFurniture = await dbContext.Furnitures.FindAsync(id);

            if (existingFurniture == null)
            {
                return Results.NotFound();
            }

            dbContext.Entry(existingFurniture).CurrentValues.SetValues(updatedFurniture.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();

        });


        //DELETE /furnitures/1
        group.MapDelete("/{id}", async  (int id, FurnitureStoreContext dbContext) =>
        {
            await dbContext.Furnitures
                .Where(furniture => furniture.Id==id)
                .ExecuteDeleteAsync();

            return Results.NoContent();

        });

        return group;
    }


}
