using Ewidencja.DTOs;
using System.Data.Entity;

namespace Ewidencja.Model
{
    internal class PatientsContext : DbContext
    {
        public string LegacyDBPath { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public PatientsContext()
        {
            Database.SetInitializer(new PatientsContextInitializer());
        }
    }
}
