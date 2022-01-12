using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    interface InterfaceDemo
    {
       public void mymethod();
    }
    interface SecondInterface
    {
         public void myothermethod();
    }
    interface Democlass : InterfaceDemo,SecondInterface
    {
        public void mymethod()
        {
            Console.WriteLine("print method");
        }
        public void myothermethod()
        {
            Console.WriteLine("method2");
        }
    }
}
