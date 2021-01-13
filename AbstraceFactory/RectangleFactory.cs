using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class RectangleFactory : IShapeFactory
    {
        public IShape GetShape()
        {
            return new Rectangle();
           // throw new NotImplementedException();
        }
    }
}
