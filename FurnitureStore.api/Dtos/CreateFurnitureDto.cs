namespace FurnitureStore.api.Dtos;

public record class CreateFurnitureDto(
    string Name,
    string Type,
    decimal Price,
    DateOnly ReleaseDate
);
