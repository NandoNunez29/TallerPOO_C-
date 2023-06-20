namespace App_Conosla;

public class Avioneta : IVehiculo
{
    public int  CantidadGasolina {get; set;}

    public Avioneta(int cantidadGasolina)
    {
        cantidadGasolina = cantidadGasolina;

    }

    public void Conducir()
    {
        if( CantidadGasolina > 0)
        Console.WriteLine("La avioneta esta volando");
    }  

    public bool Repostar(int cantidadGasolina)
    {
        if (cantidadGasolina > 100000)
        {
        CantidadGasolina += cantidadGasolina;
        Console.WriteLine("Recarga Gasolina Exitosa!");
        return true;
        } else
        {
        Console.WriteLine("Recarga Minima debe ser $100.000!");
        return false;
        } 
    }  

}
