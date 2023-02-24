namespace V1BlazorSkills.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id = Guid.NewGuid(),
                Name= "Katherine Janeway",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"Coaching", 12},
                    {"Go", 10},
                    {"Project Coordination", 15},
                }
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Jean Luc Picard",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"Project Coordination", 15},
                    {"Negotiation", 13},
                    {"Docker", 13},
                    {"Building Trust", 13},
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
