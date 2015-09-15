using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    public class Director
    {
        private BuilderA builderA = new BuilderA();

        private BuilderB builderB = new BuilderB();
        public ModelA CreateModelA()
        {
            return builderA.CreateModelA();
        }

        public ModelB CreateModelB()
        {
            return builderB.CreateModelB();
        }
 
    }

    public class BuilderB
    {
        public ModelB CreateModelB()
        {
            ModelB modelA = new ModelB();
            modelA.PartialA(); modelA.PartialB(); modelA.PartialC();
            return modelA;
        }
    }

    public class BuilderA
    {

        public ModelA CreateModelA()
        {
            ModelA modelA = new ModelA();
            modelA.PartialD();
            modelA.PartialC();
            modelA.PartialB();
            modelA.PartialA();
            return modelA;
        }
    }

    public class ModelA
    {
        public void PartialA()
        {
            Console.WriteLine("ModelA.PartialA");
        }

        public void PartialB()
        {
            Console.WriteLine("ModelA.PartialB");
        }

        public void PartialD()
        { Console.WriteLine("ModelA.PartialD"); }

        public void PartialC()
        { Console.WriteLine("ModelA.PartialC"); }
    }

    public class ModelB
    {
        public void PartialA()
        {
            Console.WriteLine("ModelB.PartialA");
        }

        public void PartialB()
        {
            Console.WriteLine("ModelB.PartialB");
        }

        public void PartialC()
        { Console.WriteLine("ModelB.PartialC"); }
    }
}
