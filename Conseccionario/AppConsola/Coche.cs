namespace AppConsola;

public class Coche
{
    public string Marca {get;protected set;}
    public int Anio {get;protected set;}
    public string Color {get;protected set;}

    public Coche(string marca, int anio, string color)
    {
        Marca = marca;
        Anio = anio;
        Color = color;                        
    }

    
}
