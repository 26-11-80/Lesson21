using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson21
{
    class Program
    {
        static int[,] garden = new int[n, m];
        const int n = 5;
        const int m = 10;


        static void Main(string[] args)
        {

            Thread sadovnik1 = new Thread(Sadovnik1);
            Thread sadovnik2 = new Thread(Sadovnik2);

            sadovnik1.Start();
            sadovnik2.Start();

            sadovnik1.Join();
            sadovnik2.Join();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void Sadovnik1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (garden[i, j] == 0)
                        garden[i, j] = 1;
                    Thread.Sleep(1);
                }
            }

        }
        public static void Sadovnik2()
        {
            for (int i = m - 1; i > 0; i--)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    if (garden[j, i] == 0)
                        garden[j, i] = 2;
                    Thread.Sleep(1);
                }
            }
        }
    }
}
    

