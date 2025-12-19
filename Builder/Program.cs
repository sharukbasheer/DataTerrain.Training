using BuilderMethod.Builder;

Console.WriteLine("Builder Pattern Example");

UserBuilder builder = new UserBuilder();
var build=builder.SetEmail("sharuk@dataterrain.com").Setid(1).SetName("Sharuk").SetPhone(123456789).SetRole("Software Developer").Build();
Console.WriteLine($"Id: {build.Id}, Name: {build.Name}, Email: {build.Email}, Phone: {build.Phone}, Role: {build.Role}");
Console.ReadKey();