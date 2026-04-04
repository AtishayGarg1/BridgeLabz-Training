using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.texteditorsystem
{
    internal class TextEditorMain
    {
        static void Main(string[] args)
        {
            TextEditorHistory editor = new TextEditorHistory(10);

            editor.AddState("Hello");
            editor.AddState("Hello World");
            editor.AddState("Hello World!");
            editor.AddState("Hello World! Welcome");

            editor.DisplayCurrentState();

            editor.Undo();
            editor.DisplayCurrentState();

            editor.Undo();
            editor.DisplayCurrentState();

            editor.Redo();
            editor.DisplayCurrentState();

            editor.AddState("Hello World! Welcome to C#");
            editor.DisplayCurrentState();
        }
    }
}
