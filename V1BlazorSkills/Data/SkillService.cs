using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace V1BlazorSkills.Data
{
    public class SkillService : ISkillService
    {
        private List<Skill> _skills = new List<Skill>();

        public Task<List<Dictionary<string, string>>> GetSkillsAsync()
        {
            List<Dictionary<string, string>> l = new List<Dictionary<string, string>>();
            if (_skills.Count == 0)
            {
                string _skillDefsRaw = File.ReadAllText("wwwroot/skilldefs.json");
                dynamic values = JsonConvert.DeserializeObject(_skillDefsRaw);
                foreach (var item in values.AllSkills)
                {
                    var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(item.ToString());
                    l.Add(dict);
                }

                foreach (var dict in l)
                {
                    Skill s = new Skill
                    {
                        Id = Guid.NewGuid(),
                        Name = dict["name"],
                        Category = dict["categoryName"],
                    };
                    _skills.Add(s);
                }
            }


            return Task.FromResult(l);
        }

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

        public Guid GetSkillIdByName(string name)
        {
            Skill s = _skills.SingleOrDefault(s => s.Name == name);
            return s.Id; 
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
