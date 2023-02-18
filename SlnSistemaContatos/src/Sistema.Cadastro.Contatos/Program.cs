using Microsoft.EntityFrameworkCore;
using Sistema.Cadastro.Contatos.Data;
using Sistema.Cadastro.Contatos.Helper;
using Sistema.Cadastro.Contatos.Repository;

var builder = WebApplication.CreateBuilder(args);  

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context DB SQL Server
builder.Services.AddDbContext<ContextDatabase>
    (options => options.UseSqlServer("Server=DESKTOP-M1NTML1\\SQLEXPRESS;Database=DatabaseSistemaContato;User Id=sa;Password=admin1535;"));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Repositories
builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<ISessao, Sessao>();

builder.Services.AddSession(o =>
{
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipelineHelper.ISessao Lifetime: Scoped ImplementationType: Sistema.Cadastro.Contatos.Helper.Sessao': Unable to resolve service for type 'Microsoft.AspNetCore.Http.HttpContextAccessor' while attempting to activate 'Sistema.Cadastro.Contatos.Helper.Sessao'..
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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
