using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batman
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Spiral
            int[,] Spiral;
            Spiral = new int[100,100];
            int x = 0;
            int y = 0;
            System.Console.Write("Input n: "); int n = int.Parse(System.Console.ReadLine());
            int size = n;
            int Current = 1;
            while (size > 0)
            {
                if (Current <= n * n)
                {
                    for (int i = y; i <= y + size - 1; i++)
                    {
                      //  System.Console.WriteLine(Current);
                        Spiral[x, i] = Current++;

                    }
                    for (int j = x+1; j <= x + size - 1; j++)
                    {
                     //   System.Console.WriteLine(Current);
                        Spiral[j, y + size - 1] = Current++;
                    }
                    for (int i = y + size - 2; i >= y; i--)
                    {
                     //   System.Console.WriteLine(Current);
                        Spiral[x + size - 1, i] = Current++;
                    }
                    for (int i = x + size - 2; i >= x+1; i--)
                    {
                     //   System.Console.WriteLine(Current);
                        Spiral[i, y] = Current++;
                    }
                    x += 1;
                    y += 1;
                    size -= 2;
                }
                else
                  break;
            }
            
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    System.Console.Write(Spiral[j, k]);
                }
                System.Console.Write("\n");
            }
            /*
            System.Console.Write("y="); int h = int.Parse(System.Console.ReadLine());
            System.Console.Write("x="); int w = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("{0} ",Spiral[x,y]); */
            System.Console.ReadLine();
           
            
            
            /* 
            int x;
            int count = 0;
            System.Console.WriteLine("x= "); x = int.Parse(System.Console.ReadLine());
            while (count < x)
            {
                for (int i = 1 + count; i <= (4 + count); i++)
                {
                    System.Console.Write(i + " ");
                }
                System.Console.WriteLine();     
                count++;
            }
            System.Console.ReadLine();
        } */
        }
    }
}

