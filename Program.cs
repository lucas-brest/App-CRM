using App_CRM.Authentication;
using App_CRM.Data;
using App_CRM.Model;
using App_CRM.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Authentication Services
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddTransient<UsuarioService>();

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient();

builder.Services.AddTransient<IServicioService, ServicioService>();
builder.Services.AddTransient<ClienteService>();
builder.Services.AddTransient<PendientesService>();
builder.Services.AddTransient<ContratoService>();

builder.Services.AddDbContext<CRMDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnectionString")));


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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
