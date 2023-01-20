
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll(Expression<Func<PatientInformation, bool>> filter = null);
        bool Add(Department department);
    }
}
