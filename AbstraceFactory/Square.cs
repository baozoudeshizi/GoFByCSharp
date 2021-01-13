using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Square: IShape
    {
        public Square()
        {
            Console.WriteLine("我是一个正方形");
        }
        public void DrawShap()
        {
            Console.WriteLine("我可以画个正方形");
        }
    }
}
