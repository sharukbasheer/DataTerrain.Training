using Flyweight.Flyweights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Context
{

    public class CharacterContext
    {
        private readonly Character _character;
        private readonly int _x;
        private readonly int _y;

        public CharacterContext(Character character, int x, int y)
        {
            _character = character;
            _x = x;
            _y = y;
        }

        public void Draw()
        {
            _character.Display(_x, _y);
        }
    }
}
