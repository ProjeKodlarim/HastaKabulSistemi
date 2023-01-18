using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Department:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
