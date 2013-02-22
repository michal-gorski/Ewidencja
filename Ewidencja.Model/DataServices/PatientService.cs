using Ewidencja.DTOs;
using Ewidencja.Model.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ewidencja.Model.DataServices
{
    public class PatientService : IPatientService
    {
        public IEnumerable<Patient> GetAllPatientsBasicInfo()
        {
            var pc = new PatientsContext();

            return (from p in pc.Patients
                    select new Patient 
                    { 
                        Name = p.Name,
                        Surname = p.Surname,
                        City = p.City,
                        Street = p.Street,
                        HomeNumber = p.HomeNumber,
                        CellPhone = (p.CellPhone == string.Empty) ? p.Phone : p.CellPhone,
                        DateOfBirth = p.DateOfBirth,                        
                    });
        }

        public IEnumerable<Patient> GetPartialPatientsBasicInfo(int toSkip, int toTake)
        {
            var pc = new PatientsContext();

            return (from p in pc.Patients
                    select new Patient
                    {
                        Name = p.Name,
                        Surname = p.Surname,
                        City = p.City,
                        Street = p.Street,
                        HomeNumber = p.HomeNumber,
                        CellPhone = (p.CellPhone == string.Empty) ? p.Phone : p.CellPhone,
                        DateOfBirth = p.DateOfBirth,
                    }).Skip(toSkip).Take(toTake);
        }


    }
}
