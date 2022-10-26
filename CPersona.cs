using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class CPersona
    {
        public CPersona(string pNombre, int pEdad) 
        {
            Console.WriteLine("Constructor de la clase Persona");

            nombre = pNombre;
            edad = pEdad;

        }


        protected string nombre;
        protected int edad;

        //Propiedad Nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        //Propiedad Edad
        public int Edad 
        {
            get { return edad; }

            set 
            {
                if (value >= 18)
                    edad = value;
                else 
                {
                    edad = -1;
                    Console.WriteLine("Edad no permitida");
                }
            }
        }
        //Metodo muestra
        public void Muestra() 
        {
            Console.WriteLine("{0} tiene {1} años",nombre,edad);
        }
    }
}
