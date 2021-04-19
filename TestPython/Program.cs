using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestPython
{
    class Program
    {
        private static string aa = "";

        public static void Main(string[] args)
        {    
            //Console.WriteLine("Hello World!");
            //string[] strArr = new string[2];//参数列表
            List<string> strArr = new List<string>();
            strArr.Add("test");
            //strArr.Add("3");
            string sArguments = @"main.py";//这里是python的文件名字
            RunPythonScript(sArguments, strArr,"-u");

            Console.ReadKey();
        }

        public static void RunPythonScript(string sArgName, List<string> teps,string args)
        {
            Process p = new Process();
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + sArgName;// 获得python文件的绝对路径（将文件放在c#的debug文件夹中可以这样操作）
            p.StartInfo.FileName = @"python.exe";//没有配环境变量的话，可以像我这样写python.exe的绝对路径。如果配了，直接写"python.exe"即可
            string sArguments = path;
            foreach (string sigstr in teps)
            {
                sArguments += " " + sigstr;//传递参数
            }

            sArguments += " " + args;

            p.StartInfo.Arguments = sArguments;

            p.StartInfo.UseShellExecute = false;

            p.StartInfo.RedirectStandardOutput = true;

            p.StartInfo.RedirectStandardInput = true;

            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.CreateNoWindow = true;

            p.Start();
            p.BeginOutputReadLine();
            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);

            Console.ReadLine();
            p.WaitForExit();
        }

        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                //return e.Data;
                AppendText(e.Data + Environment.NewLine);
                aa = e.Data;
            }
            else
            {
           
            }
        }

        public static void AppendText(string text)
        {
            //string result += text.ToString();

            //return result;
            Console.WriteLine(text);     //此处在控制台输出.py文件print的结果
        }

    }
}
