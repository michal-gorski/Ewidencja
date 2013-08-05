using Ewidencja.DTOs;
using Ewidencja.DTOs.DataClasses;
using Ewidencja.Model.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ewidencja.Model.DataServices
{
    public class PatientService : IPatientService
    {
        public IEnumerable<PatientPartial> GetAllPatientsBasicInfo()
        {
            var pc = new PatientsContext();

            return (from p in pc.Patients
                    select new PatientPartial
                    {
                        PatientId = p.PatientId,
                        Name = p.Name,
                        Surname = p.Surname,
                        City = p.City,
                        Street = p.Street,
                        HomeNumber = p.HomeNumber,
                        CellPhone = (p.CellPhone == string.Empty) ? p.Phone : p.CellPhone,
                        DateOfBirth = p.DateOfBirth,                        
                    });
        }

        public IEnumerable<PatientPartial> GetPartialPatientsBasicInfo(int toSkip, int toTake)
        {
            var pc = new PatientsContext();

            return (from p in pc.Patients
                    orderby p.Surname, p.Name
                    select new PatientPartial
                    {
                        PatientId = p.PatientId,
                        Name = p.Name,
                        Surname = p.Surname,
                        City = p.City,
                        Street = p.Street,
                        HomeNumber = p.HomeNumber,
                        CellPhone = ((p.CellPhone == string.Empty) ? p.Phone : p.CellPhone),
                        DateOfBirth = p.DateOfBirth,
                    }).Skip(toSkip).Take(toTake);
        }


    }
}
