using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string archivo;
            int p;
            string R = "s";
            while (R == "s")
            {
                Console.WriteLine("introduzca el numero que corresponda a la proceso deseado\n1. Crear \n2. Salir");
                p = int.Parse(Console.ReadLine());


                if (p == 1)
                {
                    StreamWriter ar;
                    archivo = Console.ReadLine();
                    Console.WriteLine("Escriba el nombre que desea ponerle al arhivo: ");
                    ar = File.CreateText(Console.ReadLine() + ".txt");
                    ar.Close();
                }
                Console.Clear();

                if (p == 2)
                {
                    Console.WriteLine("Usted a seleccionado la opcion salir");
                }
                Console.Clear();
                Console.WriteLine("Quieres crear otro archivo?");
                Console.WriteLine("s/n");
                R = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}