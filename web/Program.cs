using System.Text.Json;
using System.Text.Json.Serialization;
using web.Models;
using web.Models.Factories;
using web.Repositories;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var userRepository = UsuarioRepository.GetInstance();
var fencingRepository = FencingRepository.GetInstance();
var manager = DisciplineManager.GetInstance();
var athleteFactory = AthleteFactory.GetInstance();
var adminFactory = AdministratorFactory.GetInstance();

var athlete = athleteFactory.Create("Juan", "Perez", "juanperez@correo.com", 12345678);
var admin = adminFactory.Create("Pablo", "Pablo", "Pablo@correo.com", 55555555);

userRepository.Add(athlete);
userRepository.Add(admin);

manager.CreateFencingDisciplines(admin);

var disciplines = fencingRepository.GetAll();

app.MapGet("/user", () => userRepository.GetAll());

app.MapGet("/fencingDisciplines", () => fencingRepository.GetAll());

MatchDataDTO data = new MatchDataDTO("Fencing", "Rapier", "Juan", "5");
app.MapGet("/calculate", () => manager.CalculateFencingDisciplines(admin, data));

app.Run();
