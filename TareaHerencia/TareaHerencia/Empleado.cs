using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaHerencia
{
    class Empleado:Persona
    {
        public string cargo;
        public int cod_empleado;
        public DateTime fecha_ingreso;
        public int salario;

        public Empleado(int ci, string nombres, string apPaterno, string apMaterno, char genero,
            int edad, string estadoCivil, string cargo, int cod_empleado, DateTime fecha_ingreso, int salario)
            :base(ci, nombres, apPaterno, apMaterno, genero, edad, estadoCivil)
        {
            this.cargo = cargo;
            this.cod_empleado = cod_empleado;
            this.fecha_ingreso = fecha_ingreso;
            this.salario = salario;
        }
        public void VisualizarEmpleado()
        {
            Console.WriteLine("EL CARGO ES :  "+cargo);
            Console.WriteLine("EL CODIGO ES  :   "+cod_empleado);
            Console.WriteLine("LA FECHA DE INGRESO ES  :   "+fecha_ingreso);
            Console.WriteLine("EL SALARIO ES  :   "+ salario);
        }

        public int CalcularSalario(int salarioBasico, int bono)
        {
            salario = salarioBasico + bono;
            return salario;
        }
        //hacer un metodo para empleado que se llama CalcularSalario que reciba 2 datos 1) salario basico 2) bono
        //que haga la suma de esos 2 y devuelva a atributo Salario actuializandolo


        public void setCargo(string cargoEmp)
        {
            this.cargo = cargoEmp;
        }
        public string getCargo()
        {
            return cargo;
        }

        public void setCod_empleado(int codigoEmp)
        {
            this.cod_empleado = codigoEmp;
        }
        public int getCod_empleado()
        {
            return cod_empleado;
        }

        public void setFecha_ingreso(DateTime fechaIngresoEmp)
        {
            this.fecha_ingreso = fechaIngresoEmp;
        }
        public DateTime getFecha_ingreso()
        {
            return fecha_ingreso;
        }

        public void setSalario(int salarioFin)
        {
            this.salario = salarioFin;
        }
        public int getSalario()
        {
            return salario;
        }
               
    }
}

