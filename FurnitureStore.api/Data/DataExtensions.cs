using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.api.Data;

public static class DataExtensions
{
    public static void MigrateDB(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<FurnitureStore>();
        dbContext.DataBase.Migrate();
    }
}
