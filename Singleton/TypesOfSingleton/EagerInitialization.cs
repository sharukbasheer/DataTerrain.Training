using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.TypesOfSingleton
{
    public sealed class EagerInitialization
    {
        private static  EagerInitialization instance = new EagerInitialization();

        private EagerInitialization()
        {

        }

        public static EagerInitialization GetInstance()
        {
            return instance;
        }
    }
}
