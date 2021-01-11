using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirAndFileContext context = new DirAndFileContext(new DebugPanelDirAndFile()); 
            //var v = context.GetDirAndFile();

            //程序运行时获得，这个“CDS”可以是传参，也可以是从配置文件中读取等等
            var v = DirAndFileFatory.GetDirAndFileType("CDS").GetDirAndFile();
            Console.WriteLine("Hello World!");
        }
    }
}
