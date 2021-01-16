using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.CompositeFolder
{
    class Leaf : Component
    {
        public void DoSomething()
        {
            Console.WriteLine("This is a call");
        }
    }
}
