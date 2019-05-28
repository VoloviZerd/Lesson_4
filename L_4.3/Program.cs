using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *
 *  Сортировка массива 
 *
 */
namespace L_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] a = new int[size];
            Random rnd = new Random();

            Console.Write("Массив до сортировки:    ");
            for (int i=0;i<size;i++)
            {
                a[i] = rnd.Next(1,100);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            Console.Write("Массив после сортировки: ");
            for (int i=0;i<size;i++)
            {
                for(int j=0;j<size-1;j++)
                {
                    if(a[j]>a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                 }
            }
            
            for (int i = 0;i<size;i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
    }
}
