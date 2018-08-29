using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomework.Data
{
    class Person
    {
        private int Min = 12;
        private int Max = 22;
        public int OpenForChildren = 212;

        public virtual void Voice()
        {
            Console.WriteLine("Abstract voice");
        }        
    }
}
