using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CommodityFactory fac = new CommodityFactory();
            ICommodity com = fac.GetCommodityService(2);
            com.SendCommodity();
            Console.WriteLine("Hello World!");
        }
    }
}
