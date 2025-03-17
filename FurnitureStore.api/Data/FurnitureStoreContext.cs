using FurnitureStore.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.api.Data;

public class FurnitureStoreContext(DbContextOptions<FurnitureStoreContext> options) 
    : DbContext(options)
{
    public DbSet <Furniture> Furnitures => Set<Furniture>();
    
    public DbSet <FType> FTypes => Set<FType>();


}
