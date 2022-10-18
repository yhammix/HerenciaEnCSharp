using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class CEmpleado:CPersona
    {
        //Atributos
        private string puesto;
        private double salario;

        //Propiedades
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public double Salario 
        {
            get { return salario; }
            set { salario = value; }
        }

        //Metodos

        public void ponerDatos(string paramNombre, int paramEdad, string paramPuesto, double paramSalario) 
        {
            Nombre = paramNombre; //propiedad de la base
            Edad = paramEdad; //propiedad de la base

            puesto = paramPuesto;
            salario = paramSalario;
        
        }

        public void EmpleadoMuestra() 
        {
            Muestra(); //invoco metodo de la base
            Console.WriteLine("Trabajo de {0} con un sueldo de {1}$", puesto,salario);
        }


    }
}
