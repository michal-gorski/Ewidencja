using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using Ewidencja.DTOs;
using Ewidencja.Model;
using Ewidencja.Model.Interfaces;

namespace Ewidencja.Controllers.WebAPI
{
    [Authorize]
    public class PatientsController : ApiController
    {
        private IPatientService _patientService = ServiceProvider.GetPatientService(); 

        // GET api/<controller>
        [Authorize(Roles="Doctor, Assistant")]
        public IEnumerable<Patient> GetPatientsList(int skip, int take)
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