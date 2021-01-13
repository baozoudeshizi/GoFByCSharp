using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class SquareFactory: IShapeFactory
    {
        public IShape GetShape()
        {
            return new Square();
           // throw new NotImplementedException();
        }

    }
}
