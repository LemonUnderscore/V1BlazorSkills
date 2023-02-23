namespace V1BlazorSkills.Data
{
    public interface ITeamService
    {
        List<Team> GetTeams();

        Team GetTeam(Guid id);

        void UpdateTeam(Team t, Team u);

        void AddTeam(Team t);

        void DeleteTeam(Guid id);
    }
}
