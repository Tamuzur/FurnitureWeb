namespace FurnitureStore.api.Dtos;

public record class FurnitureDto(
    int Id,
    string Name,
    string Type,
    decimal Price,
    DateOnly ReleaseDate);
