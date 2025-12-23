using Memento.Originator;
using Memento.Recorder;

var editor = new TextEditor();
var history = new EditorHistory();

editor.Write("Hello ");
history.Save(editor.Save());   // Save state

editor.Write("World!");
Console.WriteLine("Current Content: " + editor.Content);

editor.Restore(history.LastState); // Undo
Console.WriteLine("After Undo: " + editor.Content);

Console.ReadKey();