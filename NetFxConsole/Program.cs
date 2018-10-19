using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFxConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Framework 4.6.1 Console App");

            var test = new NetStandardLibrary.TestClass();
            test.TestMethod().Wait();
        }
    }
}
