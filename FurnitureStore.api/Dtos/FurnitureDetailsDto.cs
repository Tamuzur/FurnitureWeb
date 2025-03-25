namespace FurnitureStore.api.Dtos;

public record class FurnitureDetailsDto(
    int Id,
    string Name,
    int FTypeId,
    decimal Price,
    DateOnly ReleaseDate
);
