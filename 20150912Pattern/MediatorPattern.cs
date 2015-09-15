using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    public class Mediator
    {
        public ConcreteA A { get; set; }
        public ConcreteB B { get; set; }
        public ConcreteC C { get; set; }
        public ConcreteD D { get; set; }


        public void DoA()
        {
            if (B != null) B.MethodB();
            
            if (D != null) D.MethodD();
        }

        public void DoB()
        {
            if (C != null) C.MethodC();
            if (D != null) D.MethodD();
        }

        public void DoC()
        {
            if (D != null) D.MethodD();
        }
    }

    public class ConcreteA
    {
        private Mediator myMediator;
        public ConcreteA(Mediator mediator)
        {
            this.myMediator = mediator;
        }

        public void MethodA()
        {
            Console.WriteLine("ConcreteA's MethodA is runing...");
            myMediator.DoA();
        }
    }

    public class ConcreteB
    {
        private Mediator myMediator;
        public ConcreteB(Mediator mediator)
        {
            this.myMediator = mediator;
        }

        public void MethodB()
        {
            Console.WriteLine("ConcreteB's MethodB is runing...");
            myMediator.DoB();
        }
    }

    public class ConcreteC
    {
        private Mediator myMediator;
        public ConcreteC(Mediator mediator)
        { this.myMediator = mediator; }

        public void MethodC()
        {
            Console.WriteLine("ConcreteC's MethodC is runing...");
            myMediator.DoC();
        }
    }

    public class ConcreteD
    {
        private Mediator myMediator;
        public ConcreteD(Mediator mediator)
        { this.myMediator = mediator; }

        public void MethodD()
        {
            Console.WriteLine("ConcreteD's MethodD is runing...");
            
        }
    }
}
