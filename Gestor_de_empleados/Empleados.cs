using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }

        public bool Activo { get; set; }

        public Empleado(string nombre, string apellido, int edad, string cargo, int salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            Salario = salario;
            Activo = true;
        }
    }

    public class Administrativo : Empleado
    {
        public Administrativo(string nombre, string apellido, int edad, int salario)
            : base(nombre, apellido, edad, "ADMINISTRATIVO", salario) { }
    }

    public class Tecnico : Empleado
    {
        public Tecnico(string nombre, string apellido, int edad, int salario)
            : base(nombre, apellido, edad, "TECNICO", salario) { }
    }
}
