using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia
{
    class Persona
    {
        public int ci;
        public string nombres;
        public string apPaterno;
        public string apMaterno;
        public char genero;
        public int edad;
        public string estadoCivil;

        public Persona(int ci, string nombres, string apPaterno, string apMaterno, char genero,
            int edad, string estadoCivil)
        {
            this.ci = ci;
            this.nombres = nombres;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.genero = genero;
            this.edad = edad;
            this.estadoCivil = estadoCivil ;
        }
        public void MostrarPersona()
        {
            Console.WriteLine("LOS DATOS REGISTRADOS SON:");
            Console.WriteLine("CARNET :  " + ci);
            Console.WriteLine("NOMBRES :  " + nombres);
            Console.WriteLine("APELLIDO PATERNO :  " + apPaterno);
            Console.WriteLine("APELLIDO MATERNO :  " + apMaterno);
            Console.WriteLine("GENERO :  " + genero);
            Console.WriteLine("EDAD :  " + edad);
            Console.WriteLine("ESTADO CIVIL :  " + estadoCivil);
        }

        public void setCi(int carnet)
        {
            if (carnet >= 1000 && carnet < 100000000)
            {
                this.ci = carnet;
            }
            else
            {
                this.ci = 0;
                Console.WriteLine("el dato es incorrecto, no esta en el rango establecido");
            }
        }
        public int getCi()
        {
            return ci;
        }

        
        public void setNombres(string nombre)
        {
            this.nombres = nombre;
        }
        public string getNombres()
        {
            return nombres;
        }

        public void setApPaterno(string pApellido)
        {
            this.nombres = pApellido;
        }
        public string getApPaterno()
        {
            return apPaterno;
        }

        public void setApMaterno(string sApellido)
        {
            this.apMaterno = sApellido;
        }
        public string getApMaterno()
        {
            return apMaterno;
        }

        public void setGenero(char gen)
        {
            if (gen == 'M' || gen == 'F' || gen == 'O')
            {
                this.genero = gen;
            }
            else
            {
                this.genero = 'O';
            }
        }
        public char getGenero()
        {
            return genero;
        }

        public void setEdad(int EdadA)
        {
            if (EdadA >= 7 && EdadA <= 18)
            {
                this.edad = EdadA;
            }
            else
            {
                this.edad = 0;
                Console.WriteLine("el dato es incorrecto, no esta en el rango establecido");
            }
        }
        public int getEdad()
        {
            return edad;
        }

        public void setEstadoCivil(string EsCivil)
        {
            this.estadoCivil = EsCivil;
        }
        public string getEstadoCivil()
        {
            return estadoCivil;
        }

    }
}
