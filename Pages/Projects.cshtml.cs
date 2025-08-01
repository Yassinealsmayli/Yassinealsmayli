using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace YassineAlsmayli.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; }

        public void OnGet()
        {
            Projects = new List<Project>
            {
                new() {
                    Title = "GitHub Portfolio",
                    Description = "Collection of 10+ projects including Flutter applications",
                    Technologies = new List<string> { "Flutter", "Dart" },
                    Link = "https://github.com/Yassinealsmayli"
                },
                new() {
                    Title = "E-Commerce Website",
                    Description = "Full-featured online store with payment integration",
                    Technologies = new List<string> { "ASP.NET Core", "React", "SQL Server" },
                    Link = "#"
                },
                new() {
                    Title = "Task Management App",
                    Description = "Productivity application for team collaboration",
                    Technologies = new List<string> { "Blazor", "Azure Functions" },
                    Link = "#"
                }
            };
        }
    }

    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public string Link { get; set; }
    }
}