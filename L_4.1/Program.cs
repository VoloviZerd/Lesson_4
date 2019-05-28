using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_4._1
{
    class Program
    {
        const int size = 6;

        static void Main(string[] args)
        {
            int[] a = new int[size];
            int[] b = new int[size];
            int[] c = new int[size];
            float[] p = new float[size];
            float M = 0;
            int s = 0;
            float m = 0;
            //10..99

            Random rnd = new Random();

            for (int i = 0; i< size; i++)
            {
                a[i] = rnd.Next(10, 30);
                Console.Write("{0} ", a[i]);
                s += a[i];
                

            }

            //Console.WriteLine();
            //m = s*1.0f / a.Length;

            //bool found;
            //int counterB = 0;
            //int count = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    found = false;
            //    for (int j = 0; j < counterB; j++)
            //    {
            //        if (b[j] == a[i])
            //        {
            //            found = true;
            //            break;
            //        }
            //    }

            //    if (found == false)
            //    {
            //        b[counterB] = a[i];
            //        counterB++;
            //    }
            //}

            //for ( int i=0;i<counterB;i++)
            //{
            //    count = 0;
            //    for(int j=0;j<size;j++)
            //    {
            //        if(b[i]==a[j])
            //        {
            //            count++;
            //        }
                
            //    }
            //    c[i] = count;
            
            //}

            //for(int i=0;i<counterB;i++)
            //{
            //    p[i] = (float)c[i] / size ;
            //}

            //for (int i=0; i<counterB; i++)
            //{
            //    M += b[i] * p[i];
            //}


            for (int i = 0;i<size;i++)
            {
                for(int j=0;j<size-1;j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Отсортированный массив : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", a[i]);
 

            }

            /*   int count = 0;
               for (int j = 0; j < size; j++)
               {
                   if (a[i] == a[j])
                   {

                       count++;
                       }
                   }
               }


               Console.WriteLine("{0} {1}", a[i], count);*/


            //for (int i = 0; i < counterB; i++)
            //    Console.WriteLine("{0} {1} {2}", b[i], c[i], p[i]); 

            //m = (float)s / a.Length;
            //Console.WriteLine("Среднее арифметическое {0} \n Мат ож {1}", m, M);
            

            //Найти математическое ожидание

            //Найти и вывести среднее арифметическое массива

            /*
             int * / int = int
             float * / int = float 
             float * / float = float
            */

        }
    }
}
