using Iterator.Aggregate;
using Iterator.Models;

var employees = new EmployeeCollection();
employees.Add(new Employee(1, "Sharuk"));
employees.Add(new Employee(2, "Saravana"));

var iterator = employees.CreateIterator();

while (iterator.HasNext())
{
    var employee = iterator.Next();
    Console.WriteLine($"Employee: {employee.Id} - {employee.Name}");
}

Console.ReadKey();