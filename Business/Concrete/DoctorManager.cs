using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        IDoctorDal _doctorDal;

        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public bool Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
            return true;
        }

        public List<Doctor> GetAll(Expression<Func<PatientInformation, bool>> filter = null)
        {
            var result = _doctorDal.GetAll();
            return result;
        }
    }
}
