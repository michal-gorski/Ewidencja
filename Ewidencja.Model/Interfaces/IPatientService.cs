using Ewidencja.DTOs;
using System.Collections.Generic;
using Ewidencja.DTOs.DataClasses;

namespace Ewidencja.Model.Interfaces
{
    public interface IPatientService
    {
        IEnumerable<PatientPartial> GetAllPatientsBasicInfo();
        IEnumerable<PatientPartial> GetPartialPatientsBasicInfo(int skip, int take);

    }
}
