using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 实物商品
    /// </summary>
    public class GoodsCommodityService: ICommodity
    {
        public void SendCommodity()
        {
            Console.WriteLine("实物商品");
        }

    }
}
