using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.TypesOfSingleton
{
    public sealed class LazyInitialization
    {
        private  static LazyInitialization instance;

        private LazyInitialization()
        {

        }

        public static LazyInitialization GetInstance()
        {
            if(instance==null)
                instance = new LazyInitialization();
            return instance;
        }
    }
}
