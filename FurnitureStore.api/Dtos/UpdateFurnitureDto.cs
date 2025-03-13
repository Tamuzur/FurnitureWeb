namespace FurnitureStore.api.Dtos;

public record class UpdateFurnitureDto(
    string Name,
    string Type,
    decimal Price,
    DateOnly ReleaseDate
);
