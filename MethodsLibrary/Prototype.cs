using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary
{
    public class Virus
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public Virus[] Children { get; set; }
        public Virus(string name, int age, double weight, string type, Virus[] children)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Type = type;
            Children = children;
        }
        public Virus Clone()
        {
            Virus[] cloneChildren = null;
            if(Children != null)
            {
                cloneChildren = new Virus[Children.Length];
                for (int i = 0; i < Children.Length; i++)
                {
                    cloneChildren[i] = Children[i].Clone();
                }
            }
            return new Virus(Name, Age, Weight, Type, cloneChildren);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}, Type: {Type}");
            if (Children != null && Children.Length > 0)
            {
                Console.WriteLine("Children:");
                foreach (Virus child in Children)
                {
                    child.DisplayInfo();
                }
            }
        }
    }
}
