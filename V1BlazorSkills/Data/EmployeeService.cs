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
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Test2",
            }
        };

        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
