using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    // 1. Handler
    // 2. Request

    public enum RequestLevel
    {
        None,
        Young,
        Old
    }
    public abstract class Handler
    {
        private Handler NextHandler = null;

        public RequestLevel HandlerLevel = RequestLevel.None;

        public Handler(RequestLevel level)
        {
            HandlerLevel = level;
        }

        public RequestLevel GetHandlerLevel()
        {
            return HandlerLevel;
        }

        public void SetNextHandler(Handler handler)
        {
            NextHandler = handler;
        }

        public void Process(Request request)
        {
            if (HandlerLevel == request.GetRequestLevel())
            {
                DoJob(request);
            }
            else
            {
                if (NextHandler != null)
                {
                    NextHandler.DoJob(request);
                }
            }
        }

        protected abstract void DoJob(Request request);
    }

    public class ConcreteHandlerA : Handler
    {
        public ConcreteHandlerA()
            : base(RequestLevel.Young)
        { }
        protected override void DoJob(Request request)
        {
            Console.WriteLine("ConcreteHandlerA's RequestLevel is {0},Request's message is {1}.", GetHandlerLevel(), request.GetRequestMessage());
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public ConcreteHandlerB()
            : base(RequestLevel.Old)
        { }
        protected override void DoJob(Request request)
        {
            Console.WriteLine("ConcreteHandlerB's RequestLevel is {0},Request's message is {1}.", GetHandlerLevel(), request.GetRequestMessage());
        }
    }

    public class Request
    {
        private RequestLevel reqLevel = RequestLevel.None;
        private string message = String.Empty;
        public Request(RequestLevel level, string msg)
        {
            reqLevel = level;
            message = msg;
        }

        public RequestLevel GetRequestLevel()
        {
            return reqLevel;
        }

        public string GetRequestMessage()
        {
            return message;
        }

        public void SendRequest(Handler h)
        {
            h.Process(this);
        }
    }

}
