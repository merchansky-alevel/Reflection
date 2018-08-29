using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomework.Data
{
    class Human : Person
    {
        private int HiddenHumanField = 101;
        public int OpenHumanField = 11011101;

        public override void Voice()
        {
            Console.WriteLine("Hi hi");
        }

        private void HiddenHuman()
        {
            Console.WriteLine("Smart people");
        }
    }
}
