using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployee();

        Task<Employee> GetEmployeeById(int id);

        Task<Employee> AddEmployee(Employee employee);

        Task<Employee> UpdateEmployee(Employee employee);

        Task<bool> DeleteEmployeeById(int id);
    }
}
