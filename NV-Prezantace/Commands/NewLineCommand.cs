using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Commands
{
    public class NewLineCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine();
        }
    }
}
