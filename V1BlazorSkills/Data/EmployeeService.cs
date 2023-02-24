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
                    {"Project Coordination", 15},
                    {"Negotiation", 13},
                    {"Consulting", 13},
                }
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Jean-Luc Picard",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"Project Coordination", 15},
                    {"Negotiation", 13},
                    {"Persuasion", 13},
                    {"Consulting", 13},
                }
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Benajmin Sisko",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"Project Coordination", 15},
                    {"Negotiation", 13},
                    {"Docker", 13},
                    {"Persuasion", 12},
                }
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Kira Nerys",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"Project Coordination", 15},
                    {"Scrum", 9},
                    {"React", 9},
                    {"Persuasion", 12},
                    {"JavaScript", 9},
                }
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Geordi La Forge",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"CSS", 15},
                    {"Scrum", 9},
                    {"React", 8},
                    {"HTML", 15},
                    {"JavaScript", 15},
                    {"NodeJS", 9},
                }
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "B'elanna Torres",
                EmployeeSkills = new Dictionary<string, int>()
                {
                    {"CSS", 15},
                    {"Scrum", 9},
                    {"React", 8},
                    {"HTML", 15},
                    {"JavaScript", 15},
                    {"NodeJS", 9},
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
