using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Email
    {
        public int id {  get; set; }
        public string emailAddress { get; set; }
        public string subject { get; set; }
        public string body { get; set; }

        public DateOnly sentDate { get; set; }
        
    }
}
