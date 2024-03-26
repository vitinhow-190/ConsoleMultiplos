using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite o numero desejado: ");
            int mult = int.Parse(Console.ReadLine());

            int cont = mult;

            while (cont <= 100) 
            {
                Console.Write(cont);

                cont += mult;
            
            }

            Console.ReadKey();
        }
    }
}
