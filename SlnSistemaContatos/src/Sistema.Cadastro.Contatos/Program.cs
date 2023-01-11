using Microsoft.EntityFrameworkCore;
using Sistema.Cadastro.Contatos.Data;
using Sistema.Cadastro.Contatos.Repository;

var builder = WebApplication.CreateBuilder(args);  

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context DB SQL Server
builder.Services.AddDbContext<ContextDatabase>
    (options => options.UseSqlServer("Server=DESKTOP-JB24L2U;Database=DatabaseSistemaContato;User Id=sa;Password=admin;"));

// Repositories
builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
