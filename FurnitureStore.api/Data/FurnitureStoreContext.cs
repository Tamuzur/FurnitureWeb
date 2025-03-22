using FurnitureStore.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.api.Data;

public class FurnitureStoreContext(DbContextOptions<FurnitureStoreContext> options) 
    : DbContext(options)
{
    public DbSet <Furniture> Furnitures => Set<Furniture>();
    
    public DbSet <FType> FTypes => Set<FType>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<FType>().HasData(
            new {Id = 1, Name = "Garden table"},
            new {Id = 2, Name = "Garden chair"},
            new {Id = 3, Name = "Hammock"},
            new {Id = 4, Name = "Bench"},
            new {Id = 5, Name = "Bed"}

        );
    }


}
