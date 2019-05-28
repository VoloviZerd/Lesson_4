using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Инверсия массива
 * 
 */

namespace L_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] a = new int[size];
            int[] c = new int[a.Length];
            Random rnd = new Random();

            Console.Write("Исходный массив массив:\n");

            for (int i = 0; i<size;i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();

            for (int i=0;i<size;i++)
            {
                c[size - i - 1] = a[i];
            }

            Console.Write("Инвертированный массив:\n");
            for (int i = 0; i < size; i++)
            {
             
                Console.Write("{0} ", c[i]);
            }

        }
    }
}
