using FurnitureStore.api.Dtos;

namespace FurnitureStore.api.Endpoints;

public static class FurnitureEndpoints
{
    private static readonly List<FurnitureDto> furnitures =  [
        new FurnitureDto(1, "Modern Chair", "Chair", 120.99m, new DateOnly(2023, 5, 20)),
        new FurnitureDto(2, "Oak Table", "Table", 450.50m, new DateOnly(2022, 8, 15)),
        new FurnitureDto(3, "Leather Sofa", "Sofa", 899.99m, new DateOnly(2021, 12, 10)),
    ];




}
