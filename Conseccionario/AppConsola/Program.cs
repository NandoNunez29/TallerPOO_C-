using AppConsola;
Console.WriteLine("Digita el limite de tu Conseccionario; ");
int limite = Convert.ToInt16(Console.ReadLine());
Consecionario consecionario = new Consecionario(limite);
char Seguir = 'N';
do {
    Console.WriteLine("Digita Marca: ");
    string Marca = (Console.ReadLine());
    Console.WriteLine("Digita Anio: ");
    int Anio = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Digita Color: ");
    string Color = (Console.ReadLine());
    Coche coche = new Coche(Marca, Anio, Color);
    consecionario.AgregarCoche(coche);

    Console.WriteLine("Deseas agregar otro Choche?");
    Seguir = Convert.ToChar(Console.ReadLine());
} while(Seguir == 'S');

consecionario.MostrarCoches();
Console.WriteLine("Digite El numero del coche que desea eliminar:_");
int op = Convert.ToInt16(Console.ReadLine());
consecionario.EliminarCoches(op);

consecionario.MostrarCoches();

Console.ReadKey();