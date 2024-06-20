using System.Text.Json;
using System.Text.Json.Serialization;
using web.Models;
using web.Models.Factories;
using web.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

var userRepository = UserRepository.GetInstance();
var fencingRepository = FencingRepository.GetInstance();
var manager = DisciplineManager.GetInstance();
var athleteFactory = AthleteFactory.GetInstance();
var adminFactory = AdministratorFactory.GetInstance();
var refereeFactory = RefereeFactory.GetInstance();

var athlete = athleteFactory.Create("Juan", "Perez", "juanperez@correo.com", 12345678);
var admin = adminFactory.Create("Pablo", "Pablo", "Pablo@correo.com", 55555555);
var referee = refereeFactory.Create("Pablin", "Pablin", "pablin@correo.com", 33333333);

userRepository.Add(athlete);
userRepository.Add(admin);
userRepository.Add(referee);

manager.CreateFencingDisciplines(admin);

MatchDataDTO data = new MatchDataDTO("Fencing", "Rapier", "Juan", "5");

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
});

app.Run();
