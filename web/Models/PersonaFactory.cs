namespace web.Models;

public class PersonaFactory
{
    public Persona Create(string nombre, string apellido, int edad, int cedula)
    {
        return new Persona(nombre, apellido, edad, cedula);
    }
}