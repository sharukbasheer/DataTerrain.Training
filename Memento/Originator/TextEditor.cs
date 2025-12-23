using Memento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Originator
{
    public class TextEditor
    {
        public string Content { get; private set; } = string.Empty;

        public void Write(string text)
        {
            Content += text;
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(Content);
        }

        public void Restore(TextEditorMemento memento)
        {
            if (memento != null)
            {
                Content = memento.Content;
            }
        }
    }
}
