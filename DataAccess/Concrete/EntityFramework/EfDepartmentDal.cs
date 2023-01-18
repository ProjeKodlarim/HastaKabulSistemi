using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal:EfEntityRepositoryBase<Department,HKContext>,IDepartmentDal
    {
    }
}
