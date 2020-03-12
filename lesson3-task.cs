using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1
{
    abstract class Shape
    {
        public abstract double Area();//面积

        public abstract double Perimeter();//周长

    }

    class Circle : Shape
    {//圆形
        double r;
        public Circle()
        {
            Console.WriteLine("请输入圆的半径：");
            string result = Console.ReadLine();
            if (!double.TryParse(result, out r) || r < 0)
            {
                Console.Write("输入内容不合法！");
            }

        }
        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }

    }
    class Rectangle : Shape//长方形
    {
        double width;
        double height;
        public Rectangle()
        {
            Console.WriteLine("请选择输入长方形的长：");
            string widthStr = Console.ReadLine();
            Console.WriteLine("请选择输入长方形的宽：");
            string heightStr = Console.ReadLine();
            if ((!double.TryParse(widthStr, out width) || !double.TryParse(heightStr, out height)) || (width < 0 && height < 0))
            {
                Console.Write("输入内容不合法");
            }
        }
        public override double Area()
        {
            return width * height;
        }
        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
    //正方形
    class Square : Shape
    {
        double width;
        public Square()
        {
            Console.WriteLine("请输入正方形的边长：");
            string widthStr = Console.ReadLine();
            if (!double.TryParse(widthStr, out width))
            {
                Console.Write("输入内容不合法");
            }
        }
        public override double Area()
        {
            return Math.Pow(width, 2);
        }
        public override double Perimeter()
        {
            return 4 * width;
        }
    }
    class Triangle : Shape
    {
        double height;
        double bottom;
        double side1;
        double side2;
        double side3;
        public Triangle()
        {
            Console.Write("请输入三角形的底：");
            string bottomStr = Console.ReadLine();
            Console.Write("请输入三角形的高：");
            string heightStr = Console.ReadLine();
            Console.Write("请输入三角形第1个边长：");
            string side1Str = Console.ReadLine();
            Console.Write("请输入三角形第2个边长：");
            string side2Str = Console.ReadLine();
            Console.Write("请输入三角形第3个边长：");
            string side3Str = Console.ReadLine();
            if ((!double.TryParse(bottomStr, out bottom) || !double.TryParse(heightStr, out height) ||
                !double.TryParse(side1Str, out side1) || !double.TryParse(side2Str, out side2) ||
                !double.TryParse(side3Str, out side3)) || (side1 + side2 > side3 && side1 + side3 > side2
                && side2 + side3 > side1) || (side1 < 0 && side2 < 0 && side3 < 0))
            {
                Console.WriteLine("输入内容不合法");
            }
        }
        public override double Area()
        {
            return bottom * height / 2;
        }
        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skadhf");
            Console.ReadKey();
        }
    }

}
