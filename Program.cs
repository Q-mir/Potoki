using System.Threading;

namespace Potoki
{
    internal class Program
    {
        private static void Method()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }        
        }
        static void Main(string[] args)
        {
            Thread thread = new(Method);
            thread.Start();
            Console.WriteLine("end");
            thread.Join();
            Console.WriteLine("ready");



            Console.ReadLine();
        }
    }
}