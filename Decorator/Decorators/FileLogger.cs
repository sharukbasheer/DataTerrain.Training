using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class FileLogger : LoggerDecorator
    {
        private readonly string _filePath = "log.txt";
        public FileLogger(ILogger logger) : base(logger)
        {

        }

        public override void Log(string message)
        {
          Console.WriteLine($"Logging to file {_filePath}: {message}");
            base.Log(message);
        }
    }
}
