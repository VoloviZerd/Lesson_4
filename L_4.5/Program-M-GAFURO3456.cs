using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Интерполяция массива
 * 
 */

namespace L_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] a = new int[size];
           //double x = 0;
           //double[] xi = new double[size];
            //double[] xj = new double[size];

            Random rnd = new Random();

            for (int i = 0;i<size;i++)
            {
                a[i] = rnd.Next(1, 10 );
                Console.Write("{0} ", a[i]);

                //xi[i] = xj[i] =  i;
            }
            Console.WriteLine();


            //double[] l = new double[size]; //Многочлен Лагранжа
            //double[] F = new double[size];

            //for(int j = 0;j<size;j++)
            //{
            //    x += 0.5;
            //    for (int i = 0;i<size;i++)
            //    {
            //        if(i!=j)
            //        {
            //            l[j] *= (x - xi[i]) / (xj[j] - xi[i]);
            //        }
            //    }
                
            //    F[j] += a[j] * l[j];
            //    Console.Write("{0} ", F[j]);
            //}


            Console.WriteLine();
            Console.ReadKey();

            int count = 0;
            int tmp = 0;

            for (int i = 0; i < size - 1; i++)
            {
                tmp = a[i];
                if (a[i] < a[i + 1])
                {

                    while (tmp < a[i + 1])
                    {
                        tmp++;
                        count++;
                    }
                }
                else if (a[i] > a[i + 1])
                {
                    while (tmp > a[i + 1])
                    {
                        tmp--;
                        count++;
                    }
                }
                else
                    count++;
            }
            count++;
            Console.WriteLine();
            Console.Write(count);
            Console.ReadKey();
            Console.WriteLine();

            int[] c = new int[count];
            int j = 0;
            for (int i = 0;i<size;i++)
            {
                //tmp = a[i];
                
                if(i==0)
                {
                    c[j] = a[i];
                    

                }
                else
                {
                    if(a[i-1]<a[i])
                    {
                        while(c[j]<a[i])
                        {
                            if (c[j] != a[i])
                            {
                                j++;
                                c[j] = c[j - 1] + 1;
                            }
                            else
                            {
                                j++;
                                c[j] = a[i];
                            }
                            

                        }
                    }
                    else if(a[i-1]>a[i])
                    {
                        while(c[j]>a[i])
                        {
                            if (c[j] != a[i])
                            {
                                j++;
                                c[j] = c[j - 1] - 1;
                            }
                            else
                            {
                                j++;
                                c[j] = a[i];
                            }
                            

                        }

                    }
                    else if (a[i - 1] == a[i])
                    {
                        j++;
                        c[j] = a[i];
                    }


                    //j = Math.Abs(a[i-1] - a[i]);
                    //c[j] = a[i];


                }

                
            }

            for(int i=0;i<count;i++)
            {
                for(int k=0;k<=c[i]; k++)
                {
                    if(k==c[i])
                        Console.Write("$");
                    else
                        Console.Write("#");
                    
                }
                Console.WriteLine();
            }

        }
    }
}
