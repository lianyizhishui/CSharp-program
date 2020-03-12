using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 4, 3, 0, 43, 45, 32, 242, 24 };

            Console.WriteLine("最小" + array.Min());
            Console.WriteLine("最大" + array.Max());
            Console.WriteLine("平均" + array.Average());
            Console.WriteLine("总合" + array.Average() * 10);

            Console.Read();

        }
    }
}
