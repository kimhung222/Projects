using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class M
    {
        int x;
        int y;
        int[,] Matrix;

        M(int x,int y)
        {
            this.x = x;
            this.y = y;
            Matrix = new int[x, y];
        }
        public void outputrangeM(int initx,int inity, int a, int b)
        {
            if (initx > x || inity > y || a > x - initx || b > y - inity)
            {
                Console.Write("\n Out of Range");
                return;
            }
            else
            {
                for (int i = initx; i < initx + a; i++)
                {
                    for (int j = inity; j < inity + b; j++)
                    {
                        Console.Write(Matrix[i, j] + "  ");
                    }
                    Console.Write("\n");
                }
            }
        }
        public int[,] inputM()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("Matrix[{0},{1}] = ", i, j); Matrix[i, j] = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                }
            }
                return Matrix;
        }
        public void outputM()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(Matrix[i, j] + "  ");
                }
                Console.Write("\n");
            }
        }
        public int sum3M(int a,int b)
        {
            int SUM = 0;
            if (a <= x - 3 && b <= y - 3)
            {
                for (int i = a; i < a + 3; i++)
                {
                    for (int j = b; j < b + 3; j++)
                    {
                        SUM += Matrix[i, j];
                    }
                }
                return SUM;
            }
            return -1;
        }
        
        static void Main(string[] args)
        {   int MAX = 0;
            int remx =0;
            int remy =0;
            M m = new M(3, 4);
            m.inputM();
            m.outputM();
           // Console.Write(m.sum3M(0, 2));
            for (int i = 0; i < m.x; i++)
            {
                for (int j = 0; j < m.y; j++)
                {
                    if (m.sum3M(i, j) > MAX)
                    {
                        MAX= m.sum3M(i,j);
                        remx = i;
                        remy = j;
                    }
                    
                }
            }
            Console.Write("\n MAX VALUE: "+MAX+"\n");
            m.outputrangeM(remx,remy,3,3);

                Console.ReadLine();
            
        }
    }
}






