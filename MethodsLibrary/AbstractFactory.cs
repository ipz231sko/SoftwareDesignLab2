using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary
{
    public interface IDevice
    {
        void Info(string factoryName);
    }
    public class Laptop : IDevice
    {
        public void Info(string factoryName)
        {
            Console.WriteLine($"Фабрика {factoryName} створила ноутбук.");
        }
    }
    public class NetBook : IDevice
    {
        public void Info(string factoryName)
        {
            Console.WriteLine($"Фабрика {factoryName} створила нетбук.");
        }
    }
    public class EBook : IDevice
    {
        public void Info(string factoryName)
        {
            Console.WriteLine($"Фабрика {factoryName} створила електронну книгу.");
        }
    }
    public class Smartphone : IDevice
    {
        public void Info(string factoryName)
        {
            Console.WriteLine($"Фабрика {factoryName} створила смартфон.");
        }
    }
    public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }

    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop();
        public IDevice CreateNetbook() => new NetBook();
        public IDevice CreateEBook() => new EBook();
        public IDevice CreateSmartphone() => new Smartphone();
    }

    public class KiaomiFactory : IDeviceFactory 
    {
        public IDevice CreateLaptop() => new Laptop();
        public IDevice CreateNetbook() => new NetBook();
        public IDevice CreateEBook() => new EBook();
        public IDevice CreateSmartphone() => new Smartphone();
    }
    public class PamsungFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop();
        public IDevice CreateNetbook() => new NetBook();
        public IDevice CreateEBook() => new EBook();
        public IDevice CreateSmartphone() => new Smartphone();
    }
}
