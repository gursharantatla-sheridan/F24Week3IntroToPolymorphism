using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24Week3IntroToPolymorphism
{
    public class BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Show from Base class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Show()
        {
            Console.WriteLine("Show from Derived class");
        }
    }
}
