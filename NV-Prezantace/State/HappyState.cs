using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.State
{
    class HappyState : StateOfMind
    {
        public void Express()
        {
            Console.WriteLine("I am happy. :)");
        }
    }
}
