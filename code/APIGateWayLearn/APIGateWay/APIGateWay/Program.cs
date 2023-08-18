using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("Ocelot.json");
builder.Services.AddOcelot();
var app = builder.Build();

await app.UseOcelot();
app.MapControllers();

app.Run();

// Nuget: Ocelot
// Folder Structure:
// APIGateWay
// => APIgateway Project
//      => Program.cs
//          => Main entry point of our micro-service application
//      => Ocelot.json
//          => Which contains which contains bridge configuration between services and gateway
// => Service folder: which contains different services 
//      => ProductService
//      => UserService
