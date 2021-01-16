using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Proxy
{
    class SecureDatabase<K,V> : Database<K,V>
    {
        private Database<K, V> databaseDelegate;
        public SecureDatabase(Database<K,V> database)
        {
            this.databaseDelegate = database;
        }
        public V Read(K key)
        {
            if (CanRead())
                return databaseDelegate.Read(key);
            else
                throw new Exception();
        }
        public void Write(K key, V value)
        {
            if (CanWrite())
                databaseDelegate.Write(key, value);
            else
                throw new Exception();
        }
        private bool CanRead()
        {
            //kontrola přístupu
            return false;
        }
        private bool CanWrite()
        {
            //kontrola přístupu
            return false;
        }
    }
}
