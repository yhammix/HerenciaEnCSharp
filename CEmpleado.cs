using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    sealed class CEmpleado:CPersona
    {
        //Atributos
        private string puesto;
        private double salario;

        public CEmpleado(string pNombre, int pEdad, string pPuesto, double pSalario) 
            : base(pNombre, pEdad) //d los 4 parametros q recibe el constructor estos son los q corresponden a la clase persona a su constructor
        {
            Console.WriteLine("Constructor clase hija");
            puesto = pPuesto;
            salario = pSalario;

        }

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
            //Nombre = paramNombre; //propiedad de la base
            //Edad = paramEdad; //propiedad de la base

            nombre = paramNombre;
            edad = paramEdad;

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
