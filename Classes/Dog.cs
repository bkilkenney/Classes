using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Dog : Animal
    {

    //This class can have it's own fields and properites, as well as any that it inherits

      //Fields
        private string name;
        private string owner;

    //Properties
        public string Name { get; set; }

        public string Owner { get; set; }

        public override void Move()
        {
            Console.WriteLine("Dog moved when the OVERRIDE method was called");
        }









    }
}
