using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.TypesOfSingleton
{
    public class DoubleLocking
    {
        private static DoubleLocking instance;

        private static readonly object lockObject = new object();
        private DoubleLocking()
        {

        }
        public static DoubleLocking GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                        instance = new DoubleLocking();
                }
            }
            return instance;
        }
    }
}
