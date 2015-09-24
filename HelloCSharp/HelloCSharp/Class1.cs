using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Class1
    {
        public static void main(String[] args)
        {
            int x;
            int count = 0;
            System.Console.WriteLine("x= "); x = int.Parse(System.Console.ReadLine());
            while (count < x)
            {
                for (int i = 1+count; i <= 4+count; i++)
                {
                    System.Console.Write(i);
                }
                count++;
            }
        }
    }
}
