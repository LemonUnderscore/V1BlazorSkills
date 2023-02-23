using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace V1BlazorSkills.Data
{
    public class SeedData
    {
        public void Initialize(string skilldefsraw)
        {
            Console.WriteLine("INIT RUNNING");
            Console.WriteLine(skilldefsraw);
        }
    }
}