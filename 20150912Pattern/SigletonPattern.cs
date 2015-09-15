using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    public class SigletonPattern
    {
        private SigletonPattern()
        { }

        private static SigletonPattern mySingle = new SigletonPattern();

        public SigletonPattern Create()
        {
            return mySingle;
        }
    }

    public class SingletonPatternB
    {
        private SingletonPatternB() { }

        private static SingletonPatternB mySingleB = null;

        public SingletonPatternB Create()
        {
            if (mySingleB == null)
            {
                lock (mySingleB)
                {
                    if (mySingleB == null)
                    {
                        mySingleB = new SingletonPatternB();
                    }
                }
            }
            return mySingleB;
        }
    }
}
