using System;
using System.Threading.Tasks;

namespace TaskTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = new Task<int>(() => { Console.WriteLine("34"); return 34; });
            Task<int> t2 = new Task<int>(() => { Console.WriteLine("11"); return 11; });
            t.Start();
            t2.RunSynchronously();
            Console.WriteLine("Hello World!");
        }
    }
}
