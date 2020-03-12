using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_task1
{
    public class Operation {
        public static double GetResult(double numberA, double numberB, string operate) {
            double result = 0d;
            switch (operate) {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }

            return result;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                Console.Write("请输入运算符号（+，-，*,/）：");
                string operation = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(Operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), Convert.ToString(operation)));
                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine(); }
            catch (Exception ex) {
                Console.WriteLine("您的输入有错：" + ex.Message);

            }
        }
    }
}