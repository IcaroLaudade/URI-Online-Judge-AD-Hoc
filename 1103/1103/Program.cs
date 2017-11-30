using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1103
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string txt = Console.ReadLine();
                if (txt.Equals("0 0 0 0")){
                    break;
                }
                string[] numero = txt.Split(' ');
                int[] vet = new int[4];
                int minutosinicio = 0;
                int minutosfim = 0;
                int aux = 0;

                for (int i = 0; i < 4; i++)
                {
                    vet[i] = int.Parse(numero[i]);
                }
                if (vet[0] == 0)
                {
                    vet[0] = 24;
                }
                if (vet[2] == 0)
                {
                    vet[2] = 24;
                }
                minutosinicio = ((vet[0] * 60) + vet[1]);
                minutosfim = ((vet[2] * 60) + vet[3]);

                if (minutosinicio >= minutosfim)
                {
                    aux = ((1440 - minutosinicio) + minutosfim);
                }
                else
                {
                    aux = minutosfim - minutosinicio;
                }

                Console.WriteLine(aux);

            }
        }
    }
}

