using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    
    public interface B : A
    {
        void mymethod3();
    }

    public class InterfaceInheritance : B
    {
        public void mymethod1()
        {
            Console.WriteLine("Implement method 1");
        }

        public void mymethod2()
        {
            Console.WriteLine("Implement method 2");
        }

        public void mymethod3()
        {
            Console.WriteLine("Implement method 3");
        }
    }
    public class InheritanceDemo
    {
        public static void Main(string[] args)
        {
            InterfaceInheritance interfaceInheritance = new InterfaceInheritance();

            interfaceInheritance.mymethod1();
            interfaceInheritance.mymethod2();
            interfaceInheritance.mymethod3();
        }
    }
}
