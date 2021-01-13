using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 第三方兑换卡
    /// </summary>
    public class CardCommodityService: ICommodity
    {
        public void SendCommodity()
        {
            Console.WriteLine("第三方兑换卡");
        }

    }
}
