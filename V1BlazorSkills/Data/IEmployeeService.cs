namespace V1BlazorSkills.Data
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        void UpdateEmployee(Employee e);

        void AddEmployee(Employee e);

        void DeleteEmployee(Guid id);
    }
}
