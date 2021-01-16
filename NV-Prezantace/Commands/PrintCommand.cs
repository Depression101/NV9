using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Commands
{
    class PrintCommand : Command
    {
        private string text;
        public PrintCommand(string rText)
        {
            text = rText;
        }
        public void Execute()
        {
            Console.WriteLine(text);
        }
    }
}
