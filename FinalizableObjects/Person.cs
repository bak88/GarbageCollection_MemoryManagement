using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableObjects
{
    internal class Person : IDisposable
    {
        private bool disposed = false;
        public string Name { get; set; }
        public Person(string name) => Name = name;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if(disposing)
            {

            }
            disposed = true;
        }
        ~Person() 
        { 
            Dispose(false);
        }

        
    }

}
