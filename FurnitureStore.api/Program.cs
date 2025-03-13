using FurnitureStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapFurnituresEndpoints();

app.Run();
