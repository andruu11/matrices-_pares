using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca cantidad de filas:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca cantidad de columnas:");
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] matrizb = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j % 2 == 0)
                    {
                        matrizb[i, j] = 0;
                    }
                    else
                    {
                        matrizb[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matrizb[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
