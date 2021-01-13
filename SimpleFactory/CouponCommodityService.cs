using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 优惠券
    /// </summary>
    public  class CouponCommodityService:ICommodity
    {
        public void SendCommodity()
        {
            Console.WriteLine("优惠券");
        }

    }
}
