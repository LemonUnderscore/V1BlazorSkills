namespace V1BlazorSkills.Data
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
