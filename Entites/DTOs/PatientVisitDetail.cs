using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class PatientVisitDetail
    {
        public int Id { get; set; }
        public string IdentyNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string DoctorName { get; set; }
        public string DepartmentName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
