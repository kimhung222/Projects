using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace HandlingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            const String input1 = "E:\\Casstle\\INPUT.txt";
            const String input2 = "E:\\Casstle\\INPUT_.txt";
            const String output_ ="E:\\Casstle\\OUTPUT.txt";
            String source="";
            StreamReader sr1 = new StreamReader(input1);
            StreamWriter sw = new StreamWriter(output_);
            String line;
            while ((line = sr1.ReadLine()) != null)
            {
                source += line;
            }
            sr1.Close();
            String[] parts = line.Split(' ');
            int[] count = new int[parts.Length];
            

            Console.ReadLine();
            try
            {
               
                for (int i = 0; i < 69; i++)
                    sw.WriteLine(i);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found !");
            }
            Console.WriteLine("Complete");
            sw.Close();
        }
    }
}
