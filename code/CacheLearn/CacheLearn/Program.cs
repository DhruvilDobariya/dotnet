using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews(options =>
{
    options.CacheProfiles.Add("Caching", new CacheProfile()
    {
        Duration = 120,
        Location = ResponseCacheLocation.Any,
        VaryByHeader = "cookie"
    });
    options.CacheProfiles.Add("NoCaching", new CacheProfile()
    {
        NoStore = true,
        Location = ResponseCacheLocation.None
    });

});
builder.Services.AddResponseCaching();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseCors();
app.UseResponseCaching();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
