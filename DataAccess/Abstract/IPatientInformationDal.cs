using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPatientInformationDal:IEntityRepository<PatientInformation>
    {
        List<PatientVisitDetail> GetPatientVisitDetail(string IdentyNumber);
    }
}
