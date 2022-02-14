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
            string[] separators = { " " };
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255");
            string strNum = Convert.ToString(Console.ReadLine());
            string[] numStrArr = strNum.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int n = numStrArr.Length;
            byte[] arrNum = new byte[n];
            for (int i = 0; i < numStrArr.Length; i++)
            {
                arrNum[i] = Convert.ToByte(numStrArr[i]);

            };
            File.WriteAllBytes("bytes.bin", arrNum); 
        }
    }
}
