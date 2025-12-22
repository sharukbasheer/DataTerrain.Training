using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Flyweights
{
    public class Character
    {
        private readonly char _symbol;      
        private readonly string _font;       
        private readonly int _size;          

        public Character(char symbol, string font, int size)
        {
            _symbol = symbol;
            _font = font;
            _size = size;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine(
                $"Character '{_symbol}' Font={_font}, Size={_size} at ({x},{y})"
            );
        }
    }
}
