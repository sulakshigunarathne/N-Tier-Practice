using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    internal class EmailRepository : IEmailRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public EmailRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Email>> GetEmail()
        {
            return await _dbContext.Emails.ToListAsync();
        }

        public async Task<Email> GetEmployeeBySentDate(DateOnly date)
        {
            return await _dbContext.Emails.FindAsync(date);
        }

        public Task<Email> SendEmail(string emailAddress, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
