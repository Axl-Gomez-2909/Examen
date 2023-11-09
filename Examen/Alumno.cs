using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Alumno
    {
        public string Nombre { get; set; }
        public string Numerocuenta { get; set; }
        public string Correo { get; set; }

        public Alumno(string nombre, string cuenta, string correo)
        {
            Nombre = nombre;
            Numerocuenta = cuenta;
            Correo = correo;
        }

        // Método abstracto para mostrar los datos del alumno
        public abstract void Mostraralumno();
    }
}
