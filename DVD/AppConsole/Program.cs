using AppSolucion;

DVD dvd = new DVD("Sony", "DVD-123");

Console.WriteLine($"Marca:  {dvd.Marca}\nModelo:  {dvd.Modelo}");
dvd.Reproducir();
dvd.Detener();
Console.ReadKey();