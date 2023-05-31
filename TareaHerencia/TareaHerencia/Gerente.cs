using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia
{
    class Gerente:Empleado  
    {
        public string unidad;

        public Gerente(int ci, string nombres, string apPaterno, string apMaterno, char genero,
            int edad, string estadoCivil, string cargo, int cod_empleado, DateTime fecha_ingreso, int salario, string unidad)
            : base(ci, nombres, apPaterno, apMaterno, genero, edad, estadoCivil, cargo, cod_empleado, fecha_ingreso, salario )
        {
            this.unidad = unidad;
        }

        public void visualizarGerente()
        {
            Console.WriteLine("PERTENECE A LA UNIDAD  :   "+unidad);
        }

        public void setUnidad(string unidadGer)
        {
            this.unidad = unidadGer;
        }
        public string getUnidad()
        {
            return unidad;
        }
    }
}
