using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Circle : IShape
    {
        public Circle()
        {
            Console.WriteLine("我是一个圆形");
        }
        public void DrawShap()
        {
            Console.WriteLine("我能够画圈圈");
        }
    }
}
