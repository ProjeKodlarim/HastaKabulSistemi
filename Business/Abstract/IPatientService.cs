using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPatientService
    {
        List<PatientInformation> GetAll(Expression<Func<PatientInformation, bool>> filter = null);
        PatientInformation Get(Expression<Func<PatientInformation, bool>> filter);
        void Add(PatientInformation entity);
        void Delete(PatientInformation entity);
        void Update(PatientInformation entity);
        List<PatientVisitDetail> GetPatientVisitDetail(string identyNumber);
    }
}
