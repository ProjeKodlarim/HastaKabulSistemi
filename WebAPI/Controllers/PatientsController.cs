using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        ///api/patients/getpatientdetail?identynumber=12345678912
        [HttpGet("getpatientdetail")]
        public IActionResult GetPatientDetail(string identyNumber)
        {
            var patient = _patientService.GetPatientVisitDetail(identyNumber);
            if (patient != null)
            {
                return Ok(patient);
            }
            return BadRequest("Sonuc yok");
        }

        [HttpPost("add")]
        public IActionResult Add(PatientInformation patientInformation)
        {

            var result = _patientService.Add(patientInformation);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
