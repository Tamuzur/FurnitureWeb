using FurnitureStore.api.Data;
using FurnitureStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var connString = "Data Source=GameStore.db";
builder.Services.AddSqlite<FurnitureStoreContext>(connString);

app.MapFurnituresEndpoints();

app.Run();
