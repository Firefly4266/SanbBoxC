using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxC
{
    public class Person
    {
        private int age = 25;

        /* Non static methods are instance methods. This means an object needs to be created 
         * for them to be used. So you can't say Person.getAge, because Person is the class.  
         * You must first create a new Person and use that instance of the Person class to use
          the method. int newPerson = new Person();  newPerson.getAge(); */
        public int getAge()
        {
            return age;
        }
        public void setAge(int newAge)
        {
            age = newAge;
        }
        //demonstrating a static method. This can be accessed at the class level.
        public static void greet()
        {
            Console.WriteLine("Hello from Static!");
        }
    }
}
