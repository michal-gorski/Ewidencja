using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ewidencja.Model.DataServices;
using Ewidencja.Model.Interfaces;

namespace Ewidencja.Model
{
    public static class ServiceProvider
    {
        public static IPatientService GetPatientService()
        {
            return new PatientService();
        }

    }
}
