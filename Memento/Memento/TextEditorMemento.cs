using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class TextEditorMemento
    {
        public string Content { get; }

        public TextEditorMemento(string content)
        {
            Content = content;
        }
    }
}
