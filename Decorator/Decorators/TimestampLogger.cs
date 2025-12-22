using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger)
        {

        }

        public override void Log(string message)
        {
            var timestampedMessage = $"[{DateTime.Now}] {message}";
            base.Log(timestampedMessage);
        }
    }
}
