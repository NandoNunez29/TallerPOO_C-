namespace App_Conosla;

public class Coche : IVehiculo
{
    public int  CantidadGasolina {get; set;}

    public Coche(int cantidadGasolina)
    {
        cantidadGasolina = cantidadGasolina;

    }

    public void Conducir()
    {
        if( CantidadGasolina > 0)
        Console.WriteLine("El coche esta conduciendo");
    }  

    public bool Repostar(int cantidadGasolina)
    {
        CantidadGasolina += cantidadGasolina;
        Console.WriteLine("Recarga Gasolina Exitosa!");
        return true;
    }  


}
