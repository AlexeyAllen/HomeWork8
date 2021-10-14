using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileQty
{
    class Program
    {
        // Вывод статистики по файлу: количество символов, строк и слов в тексте.
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\aqml\source\repos\HomeWork8\TextFile\bin\Debug\SampleFile.txt");

            using (reader)
            {
                int lines = 0;
                int symbol = 0;
                int words = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    lines++;
                    char[] separator = new char[] { ' ' };
                    string[] stringArray = line.Split(separator);

                    for (int i = 0; i < line.Length; i++)
                    {
                        symbol++;
                    }

                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        words++;
                    }
                    line = reader.ReadLine();
                }
                Console.WriteLine("Количество символов = {0}", symbol);
                Console.WriteLine("Количество слов = {0}", words);
                Console.WriteLine("Количество строк = {0}", lines);
            }

            Console.ReadKey();
        }
    }
}
