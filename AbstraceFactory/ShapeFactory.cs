using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// 工厂模式的优点，避免对象的创建与业务逻辑相耦合
    /// </summary>
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == "" ) return null;
            if ("Circle" == shapeType) return new Circle();
            if ("Rectangle" == shapeType) return new Rectangle();
            if ("Square" == shapeType) return new Square();
            throw new Exception("不存在");
        }
    }
}
