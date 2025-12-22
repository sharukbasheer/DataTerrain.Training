
using CompositeMethod.Components;
using CompositeMethod.Composite;
using CompositeMethod.Leaf;

IEmployee dev1 = new Developer("Sharuk", "Backend Developer");
IEmployee dev2 = new Developer("Arjun", "Frontend Developer");

Manager teamLead = new Manager("Saravana");
teamLead.AddEmployee(dev1);
teamLead.AddEmployee(dev2);
teamLead.DisplayDetails();


Console.ReadKey();