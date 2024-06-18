namespace web.Models;

public class Persona
{
    private string _nombre;
    private string _apellido;
    private int _edad;
    private int _cedula;
    
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }
    
    public int Edad
    {
        get { return _edad; }
        set { _edad = value; }
    }
    
    public int Cedula
    {
        get { return _cedula; }
        set { _cedula = value; }
    }
    
    public Persona(string nombre, string apellido, int edad, int cedula)
    {
        _nombre = nombre;
        _apellido = apellido;
        _edad = edad;
        _cedula = cedula;
    }
    
    public override string ToString()
    {
        return $"Nombre: {_nombre}, Apellido: {_apellido}, Edad: {_edad}, Cedula: {_cedula}";
    }
}