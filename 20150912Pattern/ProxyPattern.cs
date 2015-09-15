using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    class ProxyPattern
    {
    }

    public class RealSubject
    {
        public void MethodA()
        {
            Console.WriteLine("RealSubject MethodA...");
        }
    }

    public class ProxySubject
    {
        private RealSubject subject;
        public void MethodA()
        {
            if (subject == null) subject = new RealSubject();
            subject.MethodA();
        }
    }

    public class DynamicProxySubject
    {
        //1. Type
        //2. Method

        public object Invoke(Type type, MethodInfo method,params object[] parameters)
        {
            return method.Invoke(Activator.CreateInstance(type), parameters);
        }

    }
}
