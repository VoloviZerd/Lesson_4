using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Поиск max и min массива
 * 
 */
namespace L_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] a = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();

            int max = a[0];
            int min = a[0];
            for (int i = 0; i < size; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                else if (a[i] < min)
                {
                    min = a[i];
                }

            }
            Console.Write("max: {0}\nmin: {1} ", max, min);
        }

    }
}