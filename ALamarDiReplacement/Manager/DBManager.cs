using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALamarDiReplacement.Manager
{
    public class DBManager : IDBManager
    {
        public void Initialize()
        {
            var i = 0;
        }

        public bool Save<T>(T obj)
        {
            return true;
        }
    }
}
