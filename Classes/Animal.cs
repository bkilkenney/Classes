using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Animal
    {
        //fields

        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;


        //Properties
        public string Type { get; set; }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public string Weight { get; set; }
        public string Height { get; set; }

        public int Age
        {
            get { return this.age; }            //get is the return 
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age can't be less than 0");
                }
                else
                {
                    this.age = value;               //set is where the logic takes place. e.g. you don't want a negative # for age
                }
            }
        }

        public int NumOfLegs { get; set; }




     //Methods
        public virtual void Move()
        {
            Console.WriteLine("Animal moved when the VIRTUAL method was called");
        }


        public  virtual void MakeNoise()
        {
            Console.WriteLine("Animal made noise when the VIRTUAL method was called.");
        }
    }
}
