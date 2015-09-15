using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    public class FactoryMethodPattern
    {
        public static IProduct CreateProduct(string className)
        {
            Type type = Type.GetType(className);
            return (IProduct)Activator.CreateInstance(type);
        }
    }

    public interface IProduct
    {
        void Run();
    }

    public class ProductA : IProduct
    {
        public ProductA()
        {
            Console.WriteLine("ProductA is created.");
        }

        public void Run()
        {
            Console.WriteLine("ProductA's Run method is running...");
        }
    }

    internal class ProductB : IProduct
    {
        public ProductB()
        {
            Console.WriteLine("ProductB is created.");
        }

        public void Run()
        {
            Console.WriteLine("ProductB's Run method is running...");
        }
    }
}
