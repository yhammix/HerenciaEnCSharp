using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //obj de la clase padre
            //CPersona uno = new CPersona();
            //uno.Nombre = "Maria";
            //uno.Edad = 27;

            CPersona uno = new CPersona("Maria", 27);

            uno.Muestra();

            
            Console.WriteLine("************************");


            //obj hijo d CPersona
            //CEmpleado dos = new CEmpleado();
            //dos.Nombre = "Juan";
            //dos.Edad = 30;
            //dos.Puesto = "Contador";
            //dos.Salario = 10500.50;


            CEmpleado dos = new CEmpleado("Juan", 30,"Contador",10500.50);
            dos.EmpleadoMuestra(); //llama a un metodo q esta en la clase hijo y dentro de este llama a un metodo q es d la clase padre

            dos.Muestra(); //metodo de la clase padre




            Console.WriteLine("************************");

            //CEmpleado tres = new CEmpleado();
            //tres.ponerDatos("Susana",25,"Programadora",150000.30);//Metdo de la clase HIja
            //tres.EmpleadoMuestra();

            CEmpleado tres = new CEmpleado("Susana", 25, "Programadora", 150000.30);
            tres.EmpleadoMuestra();
            Console.WriteLine("----------------------------------");
            tres.ponerDatos("Susana", 13, "Programadora Senior", 180000.70);
            tres.EmpleadoMuestra();

            Console.ReadKey();
            
        }

    }
}
