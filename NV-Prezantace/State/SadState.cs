using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.State
{
    class SadState : StateOfMind
    {
        public void Express()
        {
            Console.WriteLine("I am sad. :(");
        }
    }
}
