using Dapper.Contrib.Extensions;
using MinimalAPILearn;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/Users", async () =>
{
    using (var connection = new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
    {
        return await connection.GetAllAsync<User>();
    }
})
.WithName("GetUser")
.WithOpenApi();

app.MapGet("/api/Users/{id}", async (int id) =>
{
    using (var connection = new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
    {
        return await connection.GetAsync<User>(id);
    }
})
.WithName("GetUserById")
.WithOpenApi();

app.MapPost("/api/Users", async (User user) =>
{
    using (var connection = new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
    {
        var result = await connection.InsertAsync<User>(user);
        return "user added successfully";
    }
})
.WithName("AddUser")
.WithOpenApi();

app.MapPut("/api/Users", async (User user) =>
{
    using (var connection = new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
    {
        if (await connection.UpdateAsync<User>(user))
        {
            return "user updated successfully";
        }
        return "user doesn't updated successfully";
    }
})
.WithName("UpdateUser")
.WithOpenApi();

app.MapDelete("/api/Users/{id}", async (int id) =>
{
    using (var connection = new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")))
    {
        var user = await connection.GetAsync<User>(id);
        if (user != null)
        {
            if (await connection.DeleteAsync<User>(user))
            {
                return "user deleted successfully";
            }
            return "user doesn't deleted successfully";
        }
        return "user not found";
    }
})
.WithName("DeleteUser")
.WithOpenApi();

app.Run();
