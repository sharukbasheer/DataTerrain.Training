
using Prototype.Models;

Employee OrgObject=new Employee()
{
    Id = 1,
    Name = "Person 1",
    Address = new Address()
    {
        Street = "Street 1",
        City = "City 1",
        Country = "India"
    }
};

Employee CloneObject= OrgObject.Clone();
CloneObject.Id = 2;
CloneObject.Name = "Person 2";
CloneObject.Address = new Address()
{
    Street = "Street 2",
    City = "City 2",
    Country = "USA"
};

Console.WriteLine("Original Object");
Console.WriteLine($"Id: {OrgObject.Id}, Name: {OrgObject.Name}, Address: {OrgObject.Address.Street}, {OrgObject.Address.City}, {OrgObject.Address.Country}");
Console.WriteLine("Cloned Object");
Console.WriteLine($"Id: {CloneObject.Id}, Name: {CloneObject.Name}, Address: {CloneObject.Address.Street}, {CloneObject.Address.City}, {CloneObject.Address.Country}");

Console.ReadKey();