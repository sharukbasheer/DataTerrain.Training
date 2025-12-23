using Memento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Recorder
{
    public class EditorHistory
    {
        public TextEditorMemento LastState { get; private set; }

        public void Save(TextEditorMemento memento)
        {
            LastState = memento;
        }
    }
}
