using AppConsola;

Persona Diego = new Persona("Diego");
Diego.Saludar();

Estudiante Nando = new Estudiante();
Nando.SetEdad(25);
Nando.Saludar();
Nando.VerEdad();
Nando.Estudiar();

Profesor profe = new Profesor();
profe.SetEdad(45);
profe.Saludar();
profe.Explicar();

Console.ReadKey();

