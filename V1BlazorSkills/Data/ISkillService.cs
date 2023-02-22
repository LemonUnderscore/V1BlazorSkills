namespace V1BlazorSkills.Data
{
    public interface ISkillService
    {
        List<Skill> GetSkills();

        Skill GetSkill(Guid id);

        void UpdateSkill(Skill s);

        void AddSkill(Skill s);

        void DeleteSkill(Guid id);
    }
}
