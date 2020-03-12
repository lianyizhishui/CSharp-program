using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Program
    {
        public static bool Judge(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {

                if (n % i == 0)

                    return false;

            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字：");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("质数因子有：");

            for (int i = 2; i <= input; i++)
            {
                while (input % i == 0 && Judge(i))
                {
                    Console.WriteLine(i);
                    input = input / i;
                }
            }
            System.Console.ReadKey();

        }

    }

}

