using AppConsola;

Console.WriteLine("Digita el nombre del perro");
string nombre= Console.ReadLine();  

Perro perro = new Perro(nombre);
perro.GetNombre();
perro.comer();

Console.ReadKey();  