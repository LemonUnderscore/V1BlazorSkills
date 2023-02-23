namespace V1BlazorSkills.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id = Guid.NewGuid(),
                Name= "Test1",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"JavaScript", 0},
                    {"C#", 2}
                }
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Test2",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"JavaScript", 5},
                    {"C#", 1}
                }
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

        public void UpdateEmployee(Employee e, Employee updated)
        {
            var getOldEmployeeData = GetEmployee(e.Id);
            getOldEmployeeData.Name = updated.Name;
            getOldEmployeeData.EmployeeSkills = updated.EmployeeSkills;
        }
    }
}
