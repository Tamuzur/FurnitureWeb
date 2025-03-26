using FurnitureStore.api.Data;
using FurnitureStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("FurnitureStore");
builder.Services.AddSqlite<FurnitureStoreContext>(connString);

var app = builder.Build();


app.MapFurnituresEndpoints();
app.MapFTypesEndpoints();


await app.MigrateDBAsync();

app.Run();
