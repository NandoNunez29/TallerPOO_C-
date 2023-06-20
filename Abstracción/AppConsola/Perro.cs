namespace AppConsola;

public class Perro : Animal
{
    public Perro(string nombre) : base("")
    {
        Nombre = nombre;
    }
    public override void comer ()
    {
        Console.WriteLine($"El perro {Nombre} está comiendo");
    }
}
