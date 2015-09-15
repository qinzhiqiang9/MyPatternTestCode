using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    abstract class TemplateMethodPattern
    {
        public abstract void MethodA();

        public abstract void MethodB();

        public void Run()
        {
            MethodA();
            MethodA();
            MethodB();
            MethodA();
        }
    }

    class TemplateProductA : TemplateMethodPattern
    {
        public override void MethodA()
        {
            Console.WriteLine("TemplateProductA.MethodA...");
        }

        public override void MethodB()
        {
            Console.WriteLine("TemplateProductA.MethodB...");
        }
    }

    class TemplateProductB : TemplateMethodPattern
    {
        public override void MethodA()
        {
            Console.WriteLine("TemplateProductB.MethodA...");
        }

        public override void MethodB()
        {
            Console.WriteLine("TemplateProductB.MethodB...");
        }
    }
}
