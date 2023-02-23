namespace V1BlazorSkills.Data
{
    public interface ISkillService
    {
        List<Skill> GetSkills();

        Task<List<Dictionary<string, string>>> GetSkillsAsync();

        Skill GetSkill(Guid id);

        Guid GetSkillIdByName(string name);

        void UpdateSkill(Skill s);

        void AddSkill(Skill s);

        void DeleteSkill(Guid id);
    }
}
