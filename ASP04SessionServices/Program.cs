using ASP04SessionServices.Models;
using ASP04SessionServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
builder.Services.AddScoped<ISessionStorage<int>, SessionStorage<int>>();
builder.Services.AddScoped<ISessionStorage<string>, SessionStorage<string>>();
builder.Services.AddScoped<ISessionStorage<Item>, SessionStorage<Item>>();
builder.Services.AddScoped<SessionStorage<List<Item>>>();
builder.Services.AddScoped<IShoppingListManager, ShoppingListManager>();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapRazorPages();

app.Run();
