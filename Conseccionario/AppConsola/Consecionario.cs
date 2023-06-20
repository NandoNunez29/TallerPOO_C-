namespace AppConsola;

public class Consecionario
{
    public List<Coche> Coches { get; protected set; }
    public int LimiteCoches { get; protected set; }

    public Consecionario(int limite)
    {
        Coches = new List<Coche>();
        LimiteCoches = limite;
    }
    public void AgregarCoche(Coche c){
        if(Coches.Count < LimiteCoches)
        {
            Coches.Add(c);
        } else Console.WriteLine("SUPERASTE EL LIMITE DE COCHES");
    }

    public void MostrarCoches()
    {
        int id = 0;
        foreach (var item in Coches)
        {
            
            Console.WriteLine($"{id}- Marca: {item.Marca}\tAnio: {item.Anio}\tColor: {item.Color}");
            id += 1;
        }
    }

    public void VaciarCoches()
    {
        Coches.Clear();
        Console.WriteLine("Lista de Coches vaciada");
    }

  public void EliminarCoches(int opcion)
    {

        Coches.RemoveAt(opcion);
    }
}
