using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Добавление элемента в массив
 * 
 */

namespace L_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int new_size = size + 1;
            int[] a = new int[size];
        int[] c;
		Random rnd = new Random();
		string ans;
		
		for (int i=0;i<size;i++)
		{
			a[i] = rnd.Next(0,100);
			Console.Write("{0} ", a[i]);
		}
		    
                do
                {
                    Console.WriteLine("\n1.Добавить элемент - add\n2.Удалить элемент - del\n3.Выйти - ex");
                    ans = Console.ReadLine();
                    if (ans == "add")
                    {
                        Console.Write("Введите число, которое нужно добавить в массив: ");
                       int tmp  = int.Parse(Console.ReadLine());

                        c = new int[a.Length];
                        for (int i = 0; i < a.Length; i++)
                        {
                            c[i] = a[i];
                            
                        }
                        size = a.Length + 1;

                        a = new int[size];
                            for (int i = 0; i < a.Length; i++)
                            {
                            if (i != a.Length - 1)
                            {
                                a[i] = c[i];
                            }
                            else
                                a[i] = tmp;

                            }

                        for (int i=0;i<a.Length;i++)
                        {
                            Console.Write("{0} ", a[i]);
                        }


                    }
                    else if (ans == "del")
                    {
                    
                    size = a.Length - 1;
                    c = new int[a.Length - 1];
                    for (int i = 0;i<a.Length-1;i++)
                        {
                            c[i] = a[i];
                        }

                    a = new int[size];

                    for (int i = 0;i<a.Length;i++)
                    {
                        a[i] = c[i];
                    }


                    for (int i = 0; i < a.Length; i++)
                        {
                            Console.Write("{0} ", a[i]);
                        }
                }
                    
                } while (ans != "ex");    

        }
    }
}
