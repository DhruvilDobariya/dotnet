using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class ConstructorDestructor
    {
        public static void Main(string[] args)
        {
            ConstructorDestructorClass constructorDestructorClass = new ConstructorDestructorClass();
            constructorDestructorClass.Display();
        }
    }
    public class ConstructorDestructorClass
    {
        public ConstructorDestructorClass()
        {
            //Constructor
            Console.WriteLine("Constructore run");
        }

        public void Display()
        {
            Console.WriteLine("Run Display");
        }

        ~ConstructorDestructorClass()
        {
            //Destructore
            Console.WriteLine("Destroctore Run");
        }
    }

}
