using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Template
{
    public class Worker : Person
    {
        protected override void Relax()
        {
            Console.WriteLine("Watching movies.");
        }

        protected override void Sleep()
        {
            Console.WriteLine("Going to bed.");
        }

        protected override void Wake()
        {
            Console.WriteLine("Waking up at 6:00");
        }
        protected override void Work()
        {
            Console.WriteLine("Going to work. Working...");
        }
    }
}
