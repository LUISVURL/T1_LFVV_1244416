using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace T1_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Mi segundo programa");
            Console.Write("Ingrese Nombre: ");
            string sNombre = Console.ReadLine();
            Console.Write("Ingrese Edad: ");
            string sEdad = Console.ReadLine();
            Console.Write("Ingrese Carrera: ");
            string sCarrera = Console.ReadLine();
            Console.Write("Ingrese Carné: ");
            string sCarne = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Mi segundo programa");
            Console.WriteLine("Nombre: " + sNombre);
            Console.WriteLine("Edad: " + sEdad);
            Console.WriteLine("Carrera: " + sCarrera);
            Console.WriteLine("Carné: " + sCarne);

            Console.WriteLine("");

            Console.WriteLine("Soy " + sNombre + ", tengo " + sEdad + " años y estudio la carrera de " + sCarrera+".");
            Console.WriteLine("Mi número de carné es: " + sCarne);
            Console.ReadKey();
        }
    }
}
