using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1. FactoryMethodPattern test code
            //IProduct productA = FactoryMethodPattern.CreateProduct("_20150912Pattern.ProductA");
            //productA.Run();

            //IProduct productB = FactoryMethodPattern.CreateProduct("_20150912Pattern.ProductB");
            //productB.Run();

            #endregion

            #region 2. TemplateMethod test code
            //new TemplateProductA().Run();
            //new TemplateProductB().Run();

            #endregion

            #region 3. Prototype pattern test code
            //PrototypeA a1 = new PrototypeA();
            //PrototypeA a2 = new PrototypeA();

            //PrototypeA c1 = a1.Clone();
            #endregion

            #region 4. DynamicProxy Pattern test code
            //DynamicProxySubject dproxy = new DynamicProxySubject();
            //RealSubject subject = new RealSubject();
            //dproxy.Invoke(typeof(object), typeof(object).GetMethod("GetType"));
            //dproxy.Invoke(typeof(RealSubject), typeof(RealSubject).GetMethod("MethodA"));
            #endregion

            #region 5. Mediator Pattern test code
            //Mediator m = new Mediator();
            //ConcreteA A = new ConcreteA(m);
            //ConcreteB B = new ConcreteB(m);
            //ConcreteC C = new ConcreteC(m);
            //m.A = A;
            //m.B = B;
            //m.C = C;
            //C.MethodC();
            #endregion
            
            #region 6. Command Pattern test code
            //ReceieverA receieverA = new ReceieverA();
            //ReceieverC receieverC = new ReceieverC();
            //ReceieverB receieverB = new ReceieverB();

            //ICommand command1 = new ConcreteCommandA(receieverA, receieverC);
            //ICommand command2 = new ConcreteCommandB(receieverB, receieverC);

            //Invoker invoker = new Invoker();
            //invoker.AddCommand(command1);
            //invoker.AddCommand(command2);

            //invoker.RunAllCommand();
            #endregion

            Request req1 = new Request(RequestLevel.Young, "my age is 18.");
            Request req2 = new Request(RequestLevel.Old, "my age is 80.");

            ConcreteHandlerA handlerA = new ConcreteHandlerA();
            ConcreteHandlerB handlerB = new ConcreteHandlerB();
            handlerA.SetNextHandler(handlerB);
            
            handlerA.Process(req1);
            handlerA.Process(req2);
            Console.ReadKey();
        }

        public class PrototypeA
        {
            private object myobj = null;
            public PrototypeA()
            {
                myobj = new object();
                Console.WriteLine("Custructor is running...");
            }

            public object MyObj { get { return myobj; } }

            public PrototypeA Clone()
            {
                return this.MemberwiseClone() as PrototypeA;
            }
        }
    }
}
