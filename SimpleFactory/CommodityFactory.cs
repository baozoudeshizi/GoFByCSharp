using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 工厂模式的优点，避免对象的创建与业务逻辑相耦合
    /// </summary>
    public class CommodityFactory
    {
        public ICommodity GetCommodityService(int commodityType)
        {
            if (commodityType <= 0 ) return null;
            if (1 == commodityType) return new CouponCommodityService();
            if (2 == commodityType) return new GoodsCommodityService();
            if (3 == commodityType) return new CardCommodityService();
            throw new Exception("不存在");
        }
    }
}
