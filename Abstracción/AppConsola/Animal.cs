namespace AppConsola;

public abstract class Animal
{
public string Nombre { get; set; }

public  Animal (string nombre)
{
    Nombre = nombre;
}

public void SetNombre(string nombre)
{
    Nombre = nombre;
}

public string GetNombre()
{
    return Nombre;
}

public abstract void comer ();
}
