using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IShapeFactory
    {
        /// <summary>
        /// 获得Shape的工厂
        /// </summary>

        public IShape GetShape();

    }
}
