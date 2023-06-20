using AppConsole;

Electrodomestico electrodomestico = new Electrodomestico("Samsung", "XYZ123");

Console.WriteLine($"Marca: {electrodomestico.Marca}\nModelo: {electrodomestico.Modelo}");
electrodomestico.Encender();
electrodomestico.Apagar();

Console.ReadKey();