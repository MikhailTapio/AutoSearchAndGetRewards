using System;
using System.Diagnostics;
using System.Threading;

namespace AutoSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("自动搜索已部署");
            int f = 20;
            Console.WriteLine("请输入搜索次数：");
            try
            {
                f = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("输入有误，默认搜索20次");
            }
            int t = 100;
            Console.WriteLine("请输入搜索间隔（毫秒）：");
            try
            {
                t = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("输入有误，默认搜索间隔5000毫秒");
            }
            Console.WriteLine("2秒后开始搜索");
            int i = f;
            Thread.Sleep(2000);
            Random r = new Random();
            while (i > 0)
            {
                Console.WriteLine("第" + (f + 1 - i) + "次执行...");
                OpenUrlWithConsole("https://www.bing.com/search?q=" + r.NextDouble());
                Thread.Sleep(t);
                i--;
            }
            Console.WriteLine("打开奖励网页。");
            OpenUrlWithConsole("https://rewards.bing.com");
        }

        static void OpenUrlWithConsole(String url)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = url;
                myProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
