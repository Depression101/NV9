using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.Proxy
{
    class LoggingDatabase<K, V> : Database<K, V>
    {
        private Database<K, V> databaseDelegate;
        public LoggingDatabase(Database<K, V> database)
        {
            databaseDelegate = database;
        }
        public V Read(K key)
        {
            log("Reading from key: " + key);
            return databaseDelegate.Read(key);
        }

        public void Write(K key, V value)
        {
            log("Writing to key: " + key);
            databaseDelegate.Write(key, value);
        }
        private void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
