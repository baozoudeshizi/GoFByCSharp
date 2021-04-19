using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RedmineTest
{
    class Program
    {
        static void Main(string[] args)
        {

           Task<int> aa = DoAsyncStuff.CalculateSumAsync(5, 6);
            Console.WriteLine("我不需要等待异步结果，最先输出");
            Console.WriteLine("我需要等待结果，输出值为"+aa.Result);
            Console.WriteLine("我在异步结果之后，所以也要等待");
            Console.WriteLine("程序退出");


        }


    }

    internal static class DoAsyncStuff
    {
        public static async Task<int> CalculateSumAsync(int i1,int i2)
        {
            WebClient wc = new WebClient();
            string s = wc.DownloadString("http://www.baicu.com");
            int value = await Task.Run(() => getSum(i1, i2));
            return value;
        }

        private static int getSum(int i1, int i2)
        {
            Thread.Sleep(3000);
            Console.WriteLine("3秒后");
            return i1 + i2;

        }
    }
}
