using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "Tim", 10);

            
            Console.Write("Is "+ student1.name+ " Obese? ");
            Console.WriteLine(student1.IsObese());

            Console.Write("Is " + student2.name + " Obese? ");
            Console.WriteLine(student2.IsObese());


            Console.ReadLine();
        }
    }
}
