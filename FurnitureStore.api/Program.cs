using FurnitureStore.api.Dtos;
using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetNameEndpointName = "GetName";

List<FurnitureDto> furnitures =  [
    new FurnitureDto(1, "Modern Chair", "Chair", 120.99m, new DateOnly(2023, 5, 20)),
    new FurnitureDto(2, "Oak Table", "Table", 450.50m, new DateOnly(2022, 8, 15)),
    new FurnitureDto(3, "Leather Sofa", "Sofa", 899.99m, new DateOnly(2021, 12, 10)),
];

//GET /furnitures
app.MapGet("furnitures", () => furnitures);

//GET /furnitures/1
app.MapGet("furnitures/{id}", (int id) => 
{
    FurnitureDto? furniture = furnitures.Find(furnitures => furnitures.Id == id );
    return furniture is null ? Results.NotFound() : Results.Ok(furniture);
})
.WithName("GetFurniture");
//POST
app.MapPost("furnitures", (CreateFurnitureDto newFurniture) =>
{
    FurnitureDto furniture = new (
        furnitures.Count + 1,
        newFurniture.Name,
        newFurniture.Type,
        newFurniture.Price,
        newFurniture.ReleaseDate
    );
    furnitures.Add(furniture);

    return Results.CreatedAtRoute("GetFurniture", new {id = furniture.Id},furniture);
});

//PUT /furnitures
app.MapPut("furnitures/{id}", (int id, UpdateFurnitureDto updatedFurniture) => 
{
    var index = furnitures.FindIndex(furniture => furniture.Id == id );

    furnitures[index] = new FurnitureDto(
        id,
        updatedFurniture.Name,
        updatedFurniture.Type,
        updatedFurniture.Price,
        updatedFurniture.ReleaseDate 
    );
    
    return Results.NoContent();

});

app.Run();

//DELETE /furnitures/1
app.MapDelete("funitures/{id}", (int id) => 
{
    furnitures.RemoveAll(furniture => furniture.Id == id);
    
    return Results.NoContent();

});
