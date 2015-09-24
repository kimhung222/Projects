using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class HelloCSharp
    {
         static void main(string[] args)
        {
            int x;
            int count = 0;
            System.Console.WriteLine("x= "); x = int.Parse(System.Console.ReadLine());
            while (count < x)
            {
                for (int i = 1 + count; i <= 4 + count; i++)
                {
                    System.Console.Write(i);
                }
                count++;
            }
            System.Console.ReadLine();
        }
    }
}
        /*
        static void Main(string[] args)
        {
          //  System.Console.WriteLine(Math.Sqrt(12345));
            /*
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine(Math.Pow(-1, i) * (i+2));
            }
                System.Console.ReadLine();
            */
          //  System.Console.WriteLine(" This Moment: "+ DateTime.Today);
           //System.Console.ReadLine();
          /*  int Age;
            System.Console.Write(" Please input your age: ");
            Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Age); */
           // Object x = "I am batman";
           // System.Console.WriteLine(x);
           /* int x;
            int SUM = 0;
            System.Console.WriteLine("Input x: ");

            x = int.Parse(System.Console.ReadLine());
            int y = x;
            while (x / 10 != 0)
            {
                SUM += x % 10;
                x = x / 10;
                if (x / 10 == 0)
                    SUM += x;
            }
            //System.Console.WriteLine((int)1234 % 10);
            //System.Console.WriteLine(SUM);
           // System.Console.WriteLine(y);
            int NEW = 0;
         //   int count = 0;
            while (y / 10 != 0)
            {
             //   System.Console.WriteLine(count);
             //   System.Console.WriteLine(NEW);
                NEW = 10 * NEW + (y % 10);
             //   System.Console.WriteLine(NEW);
             //   System.Console.WriteLine(y);
                y=y/ 10;
              //  System.Console.WriteLine(y);
              //  System.Console.WriteLine("______________________");
            //    count++;
                if (y / 10 == 0)
                    NEW =NEW*10+ y;
            }
            System.Console.WriteLine(NEW); */
        /*
            int ID;
            String name;
            System.Console.WriteLine("Input ID:"); ID = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Input name:"); name = System.Console.ReadLine();
            System.Console.ReadLine();
           
        }
    }
}
    */    