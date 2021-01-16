using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Iterátor
{
    interface List<T>
    {
        T GetElementAtIndex(int index);
        int GetSize();
    }
}
