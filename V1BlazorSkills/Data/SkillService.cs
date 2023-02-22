namespace V1BlazorSkills.Data
{
    public class SkillService : ISkillService
    {

        private List<Skill> _skills = new List<Skill>
        {
            new Skill
            {
                Id = Guid.NewGuid(),
                Name= "JavaScript",
            },
            new Skill
            {
                Id = Guid.NewGuid(),
                Name = "Java",
            },
            new Skill
            {
                Id = Guid.NewGuid(),
                Name = "C#",
            }
        };


        public void AddSkill(Skill s)
        {
            var id = Guid.NewGuid();
            s.Id = id;
            _skills.Add(s);
        }

        public void DeleteSkill(Guid id)
        {
            var skill = GetSkill(id);
            _skills.Remove(skill);
        }

        public Skill GetSkill(Guid id)
        {
            return _skills.SingleOrDefault(s => s.Id == id);
        }

        public List<Skill> GetSkills()
        {
            return _skills;
        }

        public void UpdateSkill(Skill s)
        {
            var getOldSkillData = GetSkill(s.Id);
            getOldSkillData.Name = s.Name;
        }
    }
}
