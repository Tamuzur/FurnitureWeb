namespace WebApplication.Dtos;

public record FurnitureDto(
    int Id,
    string Name,
    string Type,
    decimal Price,
    DateOnly ReleasedDate
);