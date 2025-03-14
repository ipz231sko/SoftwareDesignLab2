using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        private static readonly object _lock = new object();
        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("Виклик методу бізнес-логіки одинака");
        }
    }
}
