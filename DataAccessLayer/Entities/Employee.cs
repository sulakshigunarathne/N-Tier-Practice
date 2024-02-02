using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string EType { get; set; }
        public string Birthday { get; set; }
        public string JoinedDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
