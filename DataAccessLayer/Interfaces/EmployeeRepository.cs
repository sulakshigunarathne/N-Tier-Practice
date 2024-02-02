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
    public class EmployeeRepository : IEmployeeRepository 
    {
        private readonly ApplicationDBContext _dbContext;

        public EmployeeRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteEmployeeById(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);

            if (employee == null)
            {
                return false;
            }
            _dbContext.Employees.Remove(employee);

            try
            {
                await _dbContext.SaveChangesAsync();
                return true; 
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _dbContext.Employees.FindAsync(id);
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            try
            {
                var existingEmployee = await _dbContext.Employees.FindAsync(employee.Id);

                if (existingEmployee == null)
                {
                    return null;
                }

                existingEmployee.Name = employee.Name;
                existingEmployee.EType = employee.EType;
                existingEmployee.Birthday = employee.Birthday;
                existingEmployee.JoinedDate = employee.JoinedDate;
                existingEmployee.PhoneNumber = employee.PhoneNumber;
                existingEmployee.Email = employee.Email;

                await _dbContext.SaveChangesAsync();

                return existingEmployee;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
