﻿namespace V1BlazorSkills.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id = Guid.NewGuid(),
                Name= "Test1",
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Test2",
            }
        };

        public void AddEmployee(Employee e)
        {
            var id = Guid.NewGuid();
            e.Id = id;
            _employees.Add(e);
        }

        public void DeleteEmployee(Guid id)
        {
            var e = GetEmployee(id);
            _employees.Remove(e);
        }

        public Employee GetEmployee(Guid id)
        {
            return _employees.SingleOrDefault(e => e.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void UpdateEmployee(Employee e)
        {
            var getOldEmployeeData = GetEmployee(e.Id);
            getOldEmployeeData.Name = e.Name;
        }
    }
}