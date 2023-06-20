namespace AppConsole;

public class Electrodomestico
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public bool Encendido { get; set; }

    public Electrodomestico(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public void Encender ()
    {
        Encendido = true;
        Console.WriteLine("Electrodomestico Encendio");
    }

    public void Apagar ()
    {
        Encendido = false;
        Console.WriteLine("Electrodomestico Apagado");
    }

}
