using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Entities;

namespace BusinessLogicLayer
{
    public interface IEmailSender 
    {
        void SendEmail(Email email);
    }
}
