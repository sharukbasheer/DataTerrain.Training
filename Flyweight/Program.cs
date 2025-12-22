
using Flyweight.Context;
using Flyweight.Factory;

var factory = new CharacterFactory();
var document = new List<CharacterContext>();

document.Add(new CharacterContext(
    factory.GetCharacter('A', "Arial", 12), 10, 10));

document.Add(new CharacterContext(
    factory.GetCharacter('A', "Arial", 12), 20, 10));

document.Add(new CharacterContext(
    factory.GetCharacter('B', "Arial", 12), 30, 10));

document.Add(new CharacterContext(
    factory.GetCharacter('A', "Arial", 12), 40, 10));

foreach (var character in document)
{
    character.Draw();
}

Console.ReadKey();