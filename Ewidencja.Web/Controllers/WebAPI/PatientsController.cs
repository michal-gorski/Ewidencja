using System.Linq;
using Ewidencja.DTOs;
using Ewidencja.DTOs.DataClasses;
using Ewidencja.Model;
using Ewidencja.Model.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace Ewidencja.Controllers.WebAPI
{
    [System.Web.Http.Authorize]
    public class PatientsController : ApiController
    {
        private IPatientService _patientService = ServiceProvider.GetPatientService(); 

        // GET api/<controller>
        [System.Web.Http.Authorize(Roles = "Doctor, Assistant")]
        public IEnumerable<PatientPartial> GetPatientsList(int skip = 0, int take = 50)
        {
            return _patientService.GetPartialPatientsBasicInfo(skip, take);
        }

        /*
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
         */ 
    }
}