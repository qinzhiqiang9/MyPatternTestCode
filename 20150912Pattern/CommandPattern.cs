using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    // 1.Invoker
    // 2.Command
    // 3.Receiver
    public class ReceieverA
    {
        public void Add()
        {
            Console.WriteLine("ReceiverA's Add method is running...");
        }
    }

    public class ReceieverB
    {
        public void Remove()
        {
            Console.WriteLine("ReceieverB's Remove method is running...");
        }
    }

    public class ReceieverC
    {
        public void Notify()
        {
            Console.WriteLine("ReceieverC's Notify method is running...");
        }
    }

    public interface ICommand
    {
        void Excute();
    }

    public class ConcreteCommandA : ICommand
    {
        private ReceieverA receieverA = null;
        private ReceieverC receieverC = null;

        public ConcreteCommandA(ReceieverA rA, ReceieverC rC)
        {
            this.receieverA = rA;
            this.receieverC = rC;
        }
        public void Excute()
        {
            this.receieverA.Add();
            this.receieverC.Notify();
        }
    }

    public class ConcreteCommandB : ICommand
    {
        private ReceieverB receieverB = null;
        private ReceieverC receieverC = null;

        public ConcreteCommandB(ReceieverB rB, ReceieverC rC)
        {
            this.receieverB = rB;
            this.receieverC = rC;
        }
        public void Excute()
        {
            this.receieverB.Remove();
            this.receieverC.Notify();
        }
    }

    public class Invoker
    {
        private IList<ICommand> runCommand = new List<ICommand>();
        public void AddCommand(ICommand command)
        {
            runCommand.Add(command);
        }

        public void RunAllCommand()
        {
            runCommand.ToList().ForEach(c => c.Excute());
        }
    }
}
