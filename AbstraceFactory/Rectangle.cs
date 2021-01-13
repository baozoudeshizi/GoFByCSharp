using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Rectangle : IShape
    {
        public Rectangle()
        {
            Console.WriteLine("我是一个长方形");
        }
        public void DrawShap()
        {
            Console.WriteLine("我能够画个长方形");
        }
    }
}
