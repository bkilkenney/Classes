using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Animal
    {

        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        public void Move()
        {
            Console.WriteLine("Animals be movin'");
        }


        public void MakeNoise()
        {
            Console.WriteLine("Looks like I won't be sleeping tonight with all noise my newAnimal is making!");
        }
    }
}
