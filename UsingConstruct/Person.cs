using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstruct
{
    internal class Person : IDisposable
    {
        public string Name { get; }
        public Person(string name) => Name = name;
        public void Dispose()
        {
            Console.WriteLine($"{Name} has been disposed");
        }
    }
}
