namespace FurnitureStore.api.Entities;

public class Furniture
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public int FTypeId { get; set; }

    public FType? FType{ get; set; }

    public decimal Price{ get; set; }

    public DateOnly ReleaseDate{ get; set; }
}
