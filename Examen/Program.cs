using Examen;

try
{
    //Declaraciòn y asignaciòn de variables
    string nombreAlumno = "Axel Ricardo Gomez";
    string numeroCuenta = "T62111122";
    string email = "ax.gomez0929@gmail.com";
    string nombreClase = "Programaciòn";
    string horaClase ="1800 - 19:30";
    string nombreCatedratico = "Roger Gurdian";

    // Crear una instancia de la clase Clase
    Clase  clase = new (nombreAlumno, numeroCuenta, email, nombreClase, horaClase, nombreCatedratico);

    // Mostrar los datos del alumno y la clase
    clase.MostrarAlumno();
    clase.MostrarClase();

    // Ingresar las notas del alumno
    Console.Write("Ingrese la primera nota: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la segunda nota: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la tercera nota: ");
    double nota3 = double.Parse(Console.ReadLine());

    // Crear una instancia de la clase Promedio
    Promedio promedio = new Promedio(nota1, nota2, nota3);

    // Mostrar el promedio de notas
    Console.WriteLine(promedio.MostrarPromedio());
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
    }
