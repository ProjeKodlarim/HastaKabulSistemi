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
                             //join dep in context.Departments
                             //on doc.Id equals dep.DoctorId
                             where patient.IdentyNumber==IdentyNumber
                             select new PatientVisitDetail
                             {
                                 Id = patient.Id,
                                 IdentyNumber = patient.IdentyNumber,
                                 FirstName = patient.FirstName,
                                 LastName = patient.LastName,
                                 PhoneNumber = patient.PhoneNumber,
                                 Adress = patient.Adress,
                                 DepartmentName = doc.Department.Name,
                                 DoctorName = doc.FirstName+" "+ doc.LastName,
                                 CreatedDate = patient.CreatedDate
                             };
                return result.ToList();
            }
        }
    }
}
