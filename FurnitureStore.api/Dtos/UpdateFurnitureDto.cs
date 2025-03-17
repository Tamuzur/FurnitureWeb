using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.api.Dtos;

public record class UpdateFurnitureDto(
    [Required][StringLength(50)]string Name,
    [Required][StringLength(50)]string Type,
    [Range(1,10000)]decimal Price,
    DateOnly ReleaseDate
);
