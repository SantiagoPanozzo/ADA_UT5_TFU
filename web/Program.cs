using System.Text.Json;
using System.Text.Json.Serialization;
using web.Models;
using web.Models.Factories;
using web.Repositories;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var usuarioRepository = new UsuarioRepository();
var athleteFactory = AthleteFactory.GetInstance();
var athlete = athleteFactory.Create("Juan", "Perez", "juanperez@correo.com", 12345678);
usuarioRepository.Add(athlete);

app.MapGet("/user", () => usuarioRepository.GetAll());

app.Run();
