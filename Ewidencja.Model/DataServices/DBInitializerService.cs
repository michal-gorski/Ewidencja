using Ewidencja.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ewidencja.Model.DataServices
{
    public class DBInitializerService : IDBInitializerService
    {
        public void InitializeDB(string legacyDBPath)
        {
            PatientsContext ctx = new PatientsContext();
            ctx.LegacyDBPath = legacyDBPath;

            ctx.Database.Initialize(false);
        }
    }
}
