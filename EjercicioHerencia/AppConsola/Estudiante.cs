namespace AppConsola;

public class Estudiante : Persona
{
    public Estudiante() : base("")
    {
        
    }

    public void Estudiar(){
        Console.WriteLine("Estoy estudiando");
    }
    public void VerEdad(){
        Console.WriteLine($"Mi edad es {Edad}");
    }
    
}
