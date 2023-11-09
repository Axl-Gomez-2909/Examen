using Examen;

namespace Examen
{
    abstract  class Clase : Alumno
    {
        public string NombreClase { get; set; }
        public string HoraClase { get; set; }
        public string NombreCatedratico { get; set; }

        public Clase(string nombre, string cuenta, string correo, string nombreClase, string horaClase, string nombreCatedratico)
            : base(nombre, cuenta, correo)
        {
            NombreClase = nombreClase;
            HoraClase = horaClase;
            NombreCatedratico = nombreCatedratico;
        }

        // Implementación del método MostrarAlumno de la clase Alumno
        public override void MostrarAlumno()
        {
            Console.WriteLine("Datos del Alumno:");
            Console.WriteLine("");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Número de Cuenta: {cuenta}");
            Console.WriteLine($"Email: {Correo}");
        }

        // Método para mostrar los datos de la clase
        public void MostrarClase()
        {
            Console.WriteLine("Datos de la Clase:");
            Console.WriteLine("");
            Console.WriteLine($"Nombre de la Clase: {NombreClase}");
            Console.WriteLine($"Hora de la Clase: {HoraClase}");
            Console.WriteLine($"Nombre del Catedrático: {NombreCatedratico}");
        }
    }
}
