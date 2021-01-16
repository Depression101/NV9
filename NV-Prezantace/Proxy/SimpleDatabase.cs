using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Proxy
{
    public class SimpleDatabase<K, V> : Database<K,V>
    {
        private Dictionary<K, V> storage = new Dictionary<K,V>();
        public V Read(K key)
        {
            return storage.GetValueOrDefault(key);
        }
        public void Write(K key, V value)
        {
            storage.Add(key, value);
        }
    }
}
