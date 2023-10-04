using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema0._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicial = 1900;
            int anioFinal = DateTime.Now.Year;

            Console.WriteLine("Mostrar los Años bisiestos desde el año 1900:");

            for (int año = anioInicial; año <= anioFinal; año++)
            {
                if (EsBisiesto(año))
                {
                    Console.WriteLine(año);
                }
            }

            Console.ReadKey();
        }

        static bool EsBisiesto(int año)
        {
            return año % 4 == 0 && (año % 100 != 0 || año % 400 == 0);
            Console.ReadKey();
        }
    }
}
