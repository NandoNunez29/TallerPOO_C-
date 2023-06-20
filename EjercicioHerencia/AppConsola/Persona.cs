namespace AppConsola;

public class Persona
{
    public string Nombre { get; set; }
    public int  Edad { get; set; }
    public Persona(string nombre)
    {
        Nombre = nombre;       
    }
    public void Saludar()
    {
    Console.WriteLine("Hola te saludo.");
    }
    public void SetEdad(int edad)
    {
    Edad = edad;
    }  
}
