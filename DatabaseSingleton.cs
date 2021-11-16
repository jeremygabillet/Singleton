using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
    public class DatabaseSingleton
    {
        private static DatabaseSingleton _instance;
        private static readonly object _lock = new object();
        private DatabaseSingleton() { }
        public static DatabaseSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseSingleton();
                    }
                }
            }
            return _instance;
        }

    }
}