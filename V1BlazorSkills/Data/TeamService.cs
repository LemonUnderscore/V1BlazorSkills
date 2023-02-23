namespace V1BlazorSkills.Data
{
    public class TeamService : ITeamService
    {
        private List<Team> _teams = new List<Team>
        {
            new Team
            {
                Id = Guid.NewGuid(),
                Name = "Test Team 1",
                Employees= new List<Employee> {}
            },
            new Team
            {
                Id = Guid.NewGuid(),
                Name = "Test Team 2",
                Employees= new List<Employee> {}
            }
        };

        public void AddTeam(Team t)
        {
            var id = Guid.NewGuid();
            t.Id = id;
            _teams.Add(t);
        }

        public void DeleteTeam(Guid id)
        {
            var t = GetTeam(id);
            _teams.Remove(t);
        }

        public Team GetTeam(Guid id)
        {
            return _teams.SingleOrDefault(t => t.Id == id);
        }

        public List<Team> GetTeams()
        {
            return _teams;
        }

        public void UpdateTeam(Team old, Team updated)
        {
            var getOldTeamData = GetTeam(old.Id);
            getOldTeamData.Name = updated.Name;
            getOldTeamData.Employees = updated.Employees;
        }
    }
}
