using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2286
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                string jogadorPAR = Console.ReadLine();
                string jogadorImpar = Console.ReadLine();
                Console.WriteLine("Teste " + contador);
                for (int i = 0; i < n; i++)
                {
                    string[] num = Console.ReadLine().Split(' ');
                    int parImpar = (int.Parse(num[0]) + int.Parse(num[1])) %2;
                    if (parImpar == 0)
                    {
                        Console.WriteLine(jogadorPAR);
                    }
                    else
                    {
                        Console.WriteLine(jogadorImpar);
                    }
                }
                Console.WriteLine();
                contador++;
            }
        }
    }
}
