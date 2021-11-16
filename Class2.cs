using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
    public class Class2
    {
        public DatabaseSingleton Database { get; }
        public Class2()
        {
            Database = DatabaseSingleton.GetInstance();
        }
    }
}