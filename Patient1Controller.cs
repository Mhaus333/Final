using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient;

namespace BloodBankModuleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Patient1Controller : ControllerBase
    {

        List<Patient1> patients = new List<Patient1>()
        {

           new Patient1(1,"0999988", "Iglesias", "Celeste", "07/23/1989", "O positive", "Hgb: 12.2"),
           new Patient1(2,"6356576", "Ramirez", "Galilea", "12/23/1945", "O negative", "Hgb: 12.2"),
           new Patient1(3,"8753782", "Marillo", "Onessimo", "12/12/1999", "A positive", "Hgb: 12.2"),
           new Patient1(4,"7643546", "House", "Michael", "07/23/1989", "O positive", "Hgb: 12.2")
        };

        public List<Patient1> Patients { get => patients; set => patients = value; }

        // GET: api/Patient1
        [HttpGet]
        public List<Patient1> Get(int id)
        {
            return patients;
        }

        // GET: api/Patient1/5
        [HttpGet("{id}", Name = "Get")]
        public string Patient1ControllerGet(int id)
        {
            return "value";
        }

        // POST: api/Patient1
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Patient1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Patient1/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
