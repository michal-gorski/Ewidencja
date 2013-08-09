using Ewidencja.DTOs;
using System.Data.Entity;

namespace Ewidencja.Model
{
    internal class PatientsContext : DbContext
    {
        public PatientsContext()
            : base("Ewidencja.PatientsContext")
        {
            Database.SetInitializer(new PatientsContextInitializer());
        }

        public PatientsContext(string connectionStringName)
            : base(connectionStringName)
        {
        }

        public string LegacyDBPath { get; set; }
        public DbSet<Patient> Patients { get; set; }
        
    }
}
