using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IShapeFactory circlefactory = new CircleFactory(); //新建圆形工厂类
            IShape circle = circlefactory.GetShape();
            circle.DrawShap();
            Console.WriteLine("Hello World!");
        }
    }
}
