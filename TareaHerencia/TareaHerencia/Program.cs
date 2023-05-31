using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 1;
            while (opcion != -1)
            {
                Console.WriteLine("##################################################");
                Console.WriteLine("PRESIONE 1 PARA REGISTRAR UNA PERSONA ");
                Console.WriteLine("PRESIONE 2 PARA REGISTRAR LOS DATOS DE UN ESTUDIANTE");
                Console.WriteLine("PRESIONE 3 PARA REGISTRAR LOS DATOS DE UN EMPLEADO");
                Console.WriteLine("PRESIONE 4 PARA REGISTRAR LOS DATOS DE UN GERENTE ");
                Console.WriteLine("PRESIONE 5 PARA SALIR DEL PROGRAMA ");
                Console.WriteLine("######################################################");

                Console.WriteLine("ingrese la opcion que requiera");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese el ci de la persona");
                        int ci = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese los nombres de la persona");
                        string nombres = Console.ReadLine();
                        Console.WriteLine("ingrese el apellido paterno de la persona ");
                        string apPaterno = Console.ReadLine();
                        Console.WriteLine("ingrese el apellido materno de la persona ");
                        string apMaterno = Console.ReadLine();
                        Console.WriteLine("ingrese el genero de la persona ");
                        char genero = char.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese la edad de la persona ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el estado civil de la persona ");
                        string estadoCivil = Console.ReadLine();
                        Persona persona = new Persona(ci, nombres, apPaterno, apMaterno, genero, edad, estadoCivil);
                        persona.MostrarPersona();

                        break;
                        
                    case 2:

                        Estudiante estudiantes = new Estudiante(511142, "Loida", "Moreno", "Perez", 'F', 29, "soltera", 1546, "Contabilidad", "Gerente");
                        estudiantes.MostrarPersona();
                        estudiantes.VisualizarEstudiante();

                        break;
                    case 3:

                        Empleado empleado = new Empleado(5916111, "Jimi", "Torrez", "Munos", 'M', 23, "Soltero", "Gerente", 5122, DateTime.Parse("1/04/2002"), 0);
                        empleado.CalcularSalario(salarioBasico, bono);
                        empleado.MostrarPersona();
                        empleado.VisualizarEmpleado();
                        

                        break;
                    case 4:

                        Gerente gerente = new Gerente(1234, "juanito", "torres", "marquez", 'M', 18, "casado", "gerente", 0000, DateTime.Parse("10/05/2000"), 700, "superior");
                        gerente.CalcularSalario(salarioBasico2, bono2);
                        gerente.MostrarPersona();
                        gerente.VisualizarEmpleado();
                        gerente.visualizarGerente();

                        break;
                    case 5:
                        opcion = -1;
                        break;
                }
            }
                  
        }
    }
}
