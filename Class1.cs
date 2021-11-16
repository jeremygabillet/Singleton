using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
    public class Class1
    {
        public DatabaseSingleton Database { get; }
        public Class1()
        {
            Database = DatabaseSingleton.GetInstance();
        }
    }
}