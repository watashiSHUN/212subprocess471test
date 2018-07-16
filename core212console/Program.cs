using System;
using System.Diagnostics;

namespace core212console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start running process");
            var sw = new Stopwatch();
            sw.Start();
            using (var p = Process.Start("consoleapp471.exe"))
            {
                p.WaitForExit();
            }
            sw.Stop();
            Console.WriteLine($"duration: {sw.ElapsedMilliseconds} ms");
            Console.Read();
        }
    }
}
