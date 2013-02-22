using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ewidencja.Model.Interfaces
{
    public interface IDBInitializerService
    {
        void InitializeDB(string legacyDBPath);
    }
}
