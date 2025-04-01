using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDPLazyLoading
{
    public sealed class SingletonLogger
    {
        private static readonly Lazy<SingletonLogger> _instance = new Lazy<SingletonLogger>(()=> new SingletonLogger());
        private static object _lock = new object();
        private static int counter = 0;

        private SingletonLogger()
        {
            counter++;
            Console.WriteLine($"Instance number = {counter}");
        }

        public static SingletonLogger instance() => _instance.Value;

        public void Log(string message)
        {
            Console.WriteLine(message);
        }


    }
}
