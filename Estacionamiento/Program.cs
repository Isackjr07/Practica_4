using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuto;

            Console.WriteLine("Cuanto duro en el estacionamiento (ejemplo 10 minutos , 150 minutos etc):");
            minuto = Convert.ToInt32(Console.ReadLine());

            if(minuto <= 60)
            {
             Console.WriteLine("Debera pagar $5.00 pesos");
            }
                if(minuto >= 60 && minuto <= 120 )
                {
                 Console.WriteLine("Debera pagar $15.00 pesos");
                 }
                     if (minuto > 120)
                        {
                        Console.WriteLine("Debera pagar $40.00 pesos");
                         }

            Console.ReadKey();
        }
    }
}
