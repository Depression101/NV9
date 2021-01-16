using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Template
{
    public abstract class Person
    {
        public void PrintDailyRoutine()
        {
            Wake();
            Work();
            Relax();
            Sleep();
        }
        abstract protected void Work();
        abstract protected void Wake();
        abstract protected void Relax();
        abstract protected void Sleep();
    }
}
