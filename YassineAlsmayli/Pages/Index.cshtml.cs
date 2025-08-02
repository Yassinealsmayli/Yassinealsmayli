using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace YassineAlsmayli.Pages
{
    public class IndexModel : PageModel
    {
        public List<Skill> Skills { get; set; }

        public void OnGet()
        {
            Skills = new List<Skill>
            {
                new() { Name = "C#/.NET", Level = 85 },
                new() { Name = "Flutter", Level = 80 },
                new() { Name = "SQL", Level = 75 },
                new() { Name = "JavaScript", Level = 70 },
                new() { Name = "HTML/CSS", Level = 90 }
            };
        }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }
}