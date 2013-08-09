using System;
using System.Collections.Generic;
using System.Data.Entity;
using Ewidencja.DTOs;
using System.Linq;


namespace Ewidencja.Model
{
    internal class PatientsContextInitializer : DropCreateDatabaseIfModelChanges<PatientsContext>
    {
        protected override void Seed(PatientsContext context)
        {
            base.Seed(context);

            var patients = new List<Patient>
                {
                    new Patient
                        {
                            Name = "Michał",
                            Surname = "Górski",
                            DateOfBirth = new DateTime(1980,09,01)
                        },

                    new Patient
                        {
                            Name = "Magdalena",
                            Surname = "Górska",
                            DateOfBirth = new DateTime(1978,8,9)
                        },
                    new Patient
                        {
                            Name = "Bruno",
                            Surname = "Górski",
                            DateOfBirth = new DateTime(2011,12,9)
                        },
                    new Patient
                        {
                            Name = "Cirus",
                            Surname = "Górski",
                            DateOfBirth = new DateTime(2011,6,9)
                        },
                };

            foreach (var p in patients)
            {
                context.Patients.Add(p);
            }

            context.SaveChanges();
            try
            {


                var importer = new LegacyDataImporter.LegacyDataImporter(context.LegacyDBPath);
                var importedPatients = importer.ImportPatients();
                foreach (var importedPatient in importedPatients)
                {
                    try
                    {
                        context.Patients.Add(importedPatient);
                    }
                    catch (Exception ex)
                    {
                    }
                }

                context.SaveChanges();
            }
            catch (Exception)
            {

            }
        }
    }
}
