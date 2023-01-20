using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PatientManager : IPatientService
    {
        IPatientInformationDal _patientInformationDal;

        public PatientManager(IPatientInformationDal patientInformationDal)
        {
            _patientInformationDal = patientInformationDal;
        }

        public bool Add(PatientInformation entity)
        {
            entity.CreatedDate = DateTime.Now;
             _patientInformationDal.Add(entity);
            return true;
        }

        public void Delete(PatientInformation entity)
        {
            _patientInformationDal.Delete(entity);
        }

        public PatientInformation Get(Expression<Func<PatientInformation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<PatientInformation> GetAll(Expression<Func<PatientInformation, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<PatientVisitDetail> GetPatientVisitDetail(string identyNumber)
        {
            return _patientInformationDal.GetPatientVisitDetail(identyNumber);
        }

        public void Update(PatientInformation entity)
        {
            throw new NotImplementedException();
        }
    }
}
