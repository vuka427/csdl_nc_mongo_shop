using AspNetCore.Identity.Mongo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoShop.Data;
using MongoShop.Models.Entities;
using MongoShop.MongoDb;
using MongoShop.Policy;
using MongoShop.Services.Impletment;
using MongoShop.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

IConfiguration configuration = builder.Configuration;


builder.Services.AddIdentityMongoDbProvider<AppUser>(identity =>
    {
        identity.Password.RequireDigit = false;
        identity.Password.RequireLowercase = false;
        identity.Password.RequireNonAlphanumeric = false;
        identity.Password.RequireUppercase = false;
        identity.Password.RequiredLength = 1;
        identity.Password.RequiredUniqueChars = 0;
    },
        mongo =>
        {
            mongo.ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }
    );

builder.Services.AddSingleton<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();
builder.Services.AddSingleton<IAuthorizationHandler, HasClaimHandler>();

builder.Services.AddSingleton<IEmailSender, EmailSender>();
builder.Services.AddRazorPages();

var mongoClient = new MongoClient("mongodb://localhost:27017");
var database = mongoClient.GetDatabase("mongoShop");
builder.Services.AddSingleton(database);

builder.Services.AddScoped<MongoRepository<Product>>(provider => new MongoRepository<Product>(database, "Products"));
builder.Services.AddScoped<MongoRepository<Order>>(provider => new MongoRepository<Order>(database, "Orders"));
builder.Services.AddScoped<MongoRepository<Category>>(provider => new MongoRepository<Category>(database, "Categories"));
builder.Services.AddScoped<MongoRepository<Cart>>(provider => new MongoRepository<Cart>(database, "Carts"));

builder.Services.AddAuthorization(options => 
{
    options.AddPolicy("viewManageMenu", policy => {
        policy.RequireRole(RoleName.Administrator);
    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
