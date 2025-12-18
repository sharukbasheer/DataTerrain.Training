using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.TypesOfSingleton
{
    public class SynchronziedMethod
    {
        private static SynchronziedMethod instance;

        private static readonly object lockObject = new object();
        private SynchronziedMethod()
        {

        }
        public static SynchronziedMethod GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                    instance = new SynchronziedMethod();
            }
            return instance;
        }
    }
}
