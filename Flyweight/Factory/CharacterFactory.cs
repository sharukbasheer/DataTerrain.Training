using Flyweight.Flyweights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Factory
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, Character> _characters = new();

        public Character GetCharacter(char symbol, string font, int size)
        {
            string key = $"{symbol}_{font}_{size}";

            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new Character(symbol, font, size);
            }

            return _characters[key];
        }
    }
}
