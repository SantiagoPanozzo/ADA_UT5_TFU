using System.Text.Json;
using System.Text.Json.Serialization;
using web.Models;
using web.Repositories;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var personaRepository = new PersonaRepository();
var personaFactory = new PersonaFactory();
var persona = personaFactory.Create("Juan", "Perez", 30, 12345678);
personaRepository.Add(persona);

app.MapGet("/", () => personaRepository.GetAll());

app.Run();
