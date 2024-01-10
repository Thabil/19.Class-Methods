using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Student
    {

        public double weight;
        public string name;
        public int age;
        public Student(double aWeight, string aName, int aAge)
        {
            this.weight = aWeight;//the word this is an explict way of making the allocation.
            this.name = aName;
            this.age = aAge; //You now have one stop shop to test Obesity of your students and can update the info as you go
        }


        public bool IsObese()
        {
            if (weight > 60)
                return true;
            else return false;

        }

    }    
}
