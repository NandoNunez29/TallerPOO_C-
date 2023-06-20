namespace AppSolucion;

public class DVD
{
    public string Marca {get; set;}
    public string Modelo {get;  set;}
    public bool Reproduciendo {get;set;}

    public DVD(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public void Reproducir ()
    {
        Reproduciendo = true;
        Console.WriteLine("Reproduciendo...");
    }

    public void Detener ()
    {
        Reproduciendo = false;
        Console.WriteLine("Detenido");
    }
}
