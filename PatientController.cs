using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Patient;

namespace BloodBankModuleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase

    {
        public List<Patient1> GetPatient1s()
        {
            List<Patient1> patients = new List<Patient1>(3);


            patients.Add(item: new Patient1("11478632",
                                               "Mika",
                                               "House",
                                               "08/25/1998",
                                               "O Pos",
                                               "12.2"));
                patients.Add(item: new Patient1("39340444",
                "Celeste",
                    "Iglesias",
                    "07/13/1989",
                    "O Neg",
                    "9.4"));


                patients.Add(item: new Patient1("45642344", "Richard", "Guaca", "06/23/1997", "B Positive", "16.3"));

                return patients;
            }
        }
    }


namespace Microsoft.OpenApi.Models
{
    class Patient
    {


    }
}