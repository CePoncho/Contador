using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float num = 0.0f;
                Console.WriteLine("Contaremos 100 numeros a partir del digito que ingrese \n");
                Console.WriteLine("Escriba un numero");
                num = float.Parse(Console.ReadLine());

                for (float n = 1; n<= 100; n++)
                {
                    num = 1 + num;
                    Console.WriteLine(num);
                }
                Console.ReadKey();

            }
            catch(Exception)
                {
                Console.WriteLine("Inserte un numero no un caracter");
                }
            Console.ReadLine();
        }
    }
}
