using Entities;
using System;

namespace Entites.Concrete
{
    public class PatientInformation:IEntity
    {
        public int Id { get; set; }
        public string IdentyNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

        public int DoctorId { get; set; }
        public DateTime CreatedDate { get; set; } 
    }
}
