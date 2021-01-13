using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class CircleFactory : IShapeFactory
    {
        public IShape GetShape()
        {
            return new Circle(); //圆形工厂，返回具体的某个圆形类
           // throw new NotImplementedException();
        }
    }
}
