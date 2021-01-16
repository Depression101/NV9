using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.AdapterFolder
{
    class Adapter : Target
    {
        private Adaptee adaptee;
        public Adapter()
        {
            adaptee = new Adaptee();
        }
        public void NewRequest()
        {
            //bonus logika kódu
            adaptee.OldReqest();
        }
    }
}
