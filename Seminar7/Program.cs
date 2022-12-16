using System;

namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num: ");
            string str = Console.ReadLine();
            int num = 5;

            if (Program.TryParse(str, out num))
            {
                System.Console.WriteLine(num);
            }
            
        }
        static bool TryParse(string str, out int num)
        {
            try
            {
                num = int.Parse(str);
                return true;
            }
            catch 
            {
                num = 0;
                return false;
            }
            
        }
    }
}
