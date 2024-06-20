using System.Text.Json;
using System.Text.Json.Serialization;
using web.Models;
using web.Models.Factories;
using web.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
});

app.Run();
