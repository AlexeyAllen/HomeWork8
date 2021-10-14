using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderContent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод на консоль содержимого выбранной папки и содержимого всех подкаталогов
            //Console.WriteLine("Введите путь паки для отображения ее содержимого");
            string folderPath = @"C:\Users\aqml\source\repos\HomeWork8";
            string[] folderContent = Directory.GetDirectories(folderPath, "*" , SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
            
            foreach (string folder in folderContent)
            {
                Console.WriteLine(folder);
                
            }

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();
        }
    }
}
