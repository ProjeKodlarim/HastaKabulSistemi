using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPatientInformationDal : EfEntityRepositoryBase<PatientInformation, HKContext>, IPatientInformationDal
    {
        public List<PatientVisitDetail> GetPatientVisitDetail(string IdentyNumber)
        {
            using (HKContext context = new HKContext())
            {
                var result = from patient in context.PatientInformations
                             join doc in context.Doctors
                             on patient.DoctorId equals doc.Id
                             join dep in context.Departments
                             on doc.Id equals dep.Id
                             where patient.IdentyNumber==IdentyNumber
                             select new PatientVisitDetail
                             {
                                 FirstName = patient.FirstName,
                                 LastName = patient.LastName,
                                 PhoneNumber = patient.PhoneNumber,
                                 Adress = patient.Adress,
                                 DepartmentName = dep.Name,
                                 DoctorName = doc.FirstName+" "+ doc.LastName
                             };
                return result.ToList();
            }
        }
    }
}
