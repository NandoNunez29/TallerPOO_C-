using App_Conosla;
Console.WriteLine("Digita La cantidad de Gasolina con la que vas a inicializar el coche: ");
int gasolina = int.Parse(Console.ReadLine());    
Coche coche = new Coche(gasolina);
Console.WriteLine("Digita La cantidad de Gasolina con la que vas a inicializar la avioneta: ");
gasolina = int.Parse(Console.ReadLine()); 
IVehiculo avioneta = new Avioneta(gasolina);


coche.Conducir();

avioneta.Repostar(50000);
Console.ReadKey();

