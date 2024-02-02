using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }

        public async Task<bool> DeleteEmployeeById(int id)
        {
            return await _employeeRepository.DeleteEmployeeById(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await _employeeRepository.GetEmployee();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            return await _employeeRepository.UpdateEmployee(employee);
        }
    }
}
