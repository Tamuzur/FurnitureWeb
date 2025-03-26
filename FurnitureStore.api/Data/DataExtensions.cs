using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.api.Data;

public static class DataExtensions
{
    public static async Task MigrateDBAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<FurnitureStoreContext>();
        await dbContext.Database.MigrateAsync();
    }
}
