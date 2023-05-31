using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia
{
    class Estudiante:Persona
    {
        public int codEstudiante;
        public string carrera;
        public string nivel;

        public Estudiante(int ci, string nombres, string apPaterno, string apMaterno, char genero,
            int edad, string estadoCivil, int codEstudiante, string carrera, string nivel)
            :base(ci, nombres, apPaterno, apMaterno, genero, edad, estadoCivil)
        {
            this.codEstudiante = codEstudiante;
            this.carrera = carrera;
            this.nivel = nivel;
        }
        public void VisualizarEstudiante()
        {
            Console.WriteLine("EL CODIGO DEL ESTUDIANTE ES :   "+codEstudiante);
            Console.WriteLine("LA CARRERA DEL ESTUDIANTE ES :   "+carrera);
            Console.WriteLine("EL NIVEL DEL ESTUDIANTE ES  :   "+nivel);
        } 

        public void setCodEstudiante(int codigoEst)
        {
            this.codEstudiante = codigoEst;
        }
        public int getCodEstudiante()
        {
            return codEstudiante;
        }

        public void setCarrera(string nomCarrera)
        {
            this.carrera = nomCarrera;
        }
        public string getCarrera()
        {
            return carrera;
        }

        public void setNivel(string nivelCarr)
        {
            this.nivel = nivelCarr;
        }
        public string getNivel()
        {
            return nivel;
        }
        
    }
}
