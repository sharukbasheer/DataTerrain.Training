
using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.Decorators;

ILogger logger = new ConsoleLogger();

logger = new TimestampLogger(logger);

logger = new FileLogger(logger);

logger.Log("Application started");

Console.ReadKey();