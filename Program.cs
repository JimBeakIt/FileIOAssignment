using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number I can turn to a text file");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userNum);
            using (StreamWriter file = new StreamWriter(@"C:\Users\jimbe\Logs\logNum.txt", true))
            {
                file.WriteLine(userNum);
            }
        }
    }
}
