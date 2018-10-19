using System;

namespace NetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET Core 2.1 Console App");

            var test = new NetStandardLibrary.TestClass();
            try
            {
                test.TestMethod().Wait();
            }
            catch (AggregateException ex)
            {
                if (ex.InnerException is ArgumentNullException)
                {
                    // This is expected, because CloudFileDirectory isn't initialised
                }
                else
                {
                    throw;
                }
            }

            Console.WriteLine("All OK. Press any key.");
            Console.ReadKey(true);
        }
    }
}
