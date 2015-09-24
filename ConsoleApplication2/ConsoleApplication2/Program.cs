using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester
{
    class Program
    {   







        static void Main(string[] args)
        {

            int x, y;
            int[,] matrix;
            Console.Write("x: "); x = int.Parse(Console.ReadLine());
            Console.Write("y: "); y = int.Parse(Console.ReadLine());
            matrix = new int[x, y];
            for(int i=0;i<x;i++){
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("matrix[{0}][{1}] :", x, y);
                    matrix[x, y] = int.Parse(Console.ReadLine());
                }
            }



        }
    }
}
