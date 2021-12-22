using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contadorwhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                float num = 0.0f;
                float num2 = 0.0f;
                Console.WriteLine("Contaremos 100 numeros a partir del digito que ingrese \n");
                Console.WriteLine("Escriba un numero");
                num = float.Parse(Console.ReadLine());

                do
                {
                    num2++;
                    Console.WriteLine(num + num2);
                } 
                while (num2 < 100);
                Console.ReadKey();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Digite un numero no un caracter");
            }
            Console.ReadLine(); 
                
        }
    }
}
