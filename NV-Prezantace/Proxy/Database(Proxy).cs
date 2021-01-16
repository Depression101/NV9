using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Proxy
{
    interface Database<K,V>
    {
        V Read(K key);
        void Write(K key, V value);
    }
}
