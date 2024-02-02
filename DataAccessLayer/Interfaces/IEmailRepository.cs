using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Interfaces
{
    public interface IEmailRepository
    {
        Task<IEnumerable<Email>> GetEmail();

        Task<Email> GetEmployeeBySentDate(DateOnly date);

        Task<Email> SendEmail(string emailAddress,string subject,string body);

    }
}
