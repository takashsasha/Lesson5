using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные для сохранения в файл:");
            string text = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, text);
        }
    }
}
