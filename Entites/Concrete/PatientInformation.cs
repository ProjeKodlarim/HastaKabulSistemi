using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class PatientInformation:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string DepartmentName { get; set; }

    }
}
