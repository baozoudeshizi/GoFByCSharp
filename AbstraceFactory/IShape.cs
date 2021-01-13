using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IShape
    {
        /// <summary>
        /// 具体的图形，有各自的“画图形”的方法
        /// </summary>
        public void DrawShap();
    }
}
