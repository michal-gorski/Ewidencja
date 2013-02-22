using Ewidencja.DTOs;
using System.Collections.Generic;

namespace Ewidencja.Model.Interfaces
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetAllPatientsBasicInfo();
        IEnumerable<Patient> GetPartialPatientsBasicInfo(int skip, int take);

    }
}
