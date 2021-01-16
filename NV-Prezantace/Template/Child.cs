using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Template
{
    class Child : Person
    {
        protected override void Relax()
        {
            Console.WriteLine("Playing with other kids.");
        }
        protected override void Sleep()
        {
            Console.WriteLine("Going to bed.");
        }

        protected override void Wake()
        {
            Console.WriteLine("Waking up at 7:00");
        }
        protected override void Work()
        {
            Console.WriteLine("Going to school.");
        }
    }
}
