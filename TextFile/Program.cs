using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class Program
    {
        // Cумма чисел на консоль из созданного файла
        static void Main(string[] args)
        {
            File.Create(@"C:\Users\aqml\source\repos\HomeWork8\HomeWork8\test.txt");
            StreamWriter writer = new StreamWriter("testFile.txt");
            Random random = new Random();
            using (writer)
            {
                for (int i = 0; i < 10; i++)
                {
                    int number = random.Next(0, 100);
                    writer.WriteLine(number);
                }
            }

            StreamReader reader = new StreamReader("testFile.txt");
            int Sum = 0;
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    Sum += Convert.ToInt32(line);
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("Сумма 10 случайных чисел из созданного файла = " + Sum);
            Console.ReadKey();
        }
    }
}
