using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALamarDiReplacement.Manager
{
    public interface IDBManager
    {
        void Initialize();
        bool Save<T>(T obj);
    }
}
