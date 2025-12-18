
using Singleton.TypesOfSingleton;

EagerInitialization EagerInstace = EagerInitialization.GetInstance();

LazyInitialization LazyInstance = LazyInitialization.GetInstance();

await Task.Run(() =>
{
    SynchronziedMethod synchronziedMethod = SynchronziedMethod.GetInstance(); 
});

DoubleLocking DoubleLockInstance = DoubleLocking.GetInstance();

Console.ReadKey();

