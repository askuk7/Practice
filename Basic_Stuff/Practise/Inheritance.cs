using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class A
    {
        //public A()
        //{
        //    Console.WriteLine("A");
        //}
        public virtual void abc()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        //public B()
        //{
        //    Console.WriteLine("B");
        //}
        public override void abc()
        {            
            Console.WriteLine("B");
        }
    }
    class C : B
    {
        //public C()
        //{
        //    Console.WriteLine("C");
        //}

        public new void abc()
        {
            Console.WriteLine("C");
        }
    }
}
