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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public List<Department> GetAll(Expression<Func<PatientInformation, bool>> filter = null)
        {
            var result = _departmentDal.GetAll();
            return result;
        }
    }
}
