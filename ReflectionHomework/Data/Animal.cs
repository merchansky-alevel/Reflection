using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomework.Data
{
    class Animal : Person
    {
        private string HiddenAnimalField = "wof wof";
        public string OpenAnimalField = "wof2 wof2";

        public override void Voice()
        {
            Console.WriteLine("Animal voice"); ;
        }

        private void HiddenAnimal()
        {
            Console.WriteLine("Smart animal");
        }
    }
}
