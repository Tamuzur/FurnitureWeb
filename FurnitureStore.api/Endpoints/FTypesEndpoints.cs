using FurnitureStore.api.Data;
using FurnitureStore.api.Entities;
using FurnitureStore.api.Mapping;
using Microsoft.EntityFrameworkCore;


namespace FurnitureStore.api.Endpoints;

public static class FTypesEndpoints
{
    public static RouteGroupBuilder MapFTypesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("FTypes");

        group.MapGet("/", async (FurnitureStoreContext dbContext) =>
            await dbContext.FTypes.Select(ftype => ftype.ToDto()).AsNoTracking().ToListAsync()
        );

        return group;
    }


}
