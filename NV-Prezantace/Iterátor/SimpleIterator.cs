using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Iterátor
{
    interface SimpleIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
