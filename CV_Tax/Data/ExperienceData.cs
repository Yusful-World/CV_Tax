using CV_Tax.Models;
using System.Reflection.Emit;

namespace CV_Tax.Data
{
    public class ExperienceData
    {
        public static List<Experience> GetExperiences => new List<Experience>()
        {
            new() { Establishment = "Igate", Role = ".NetDeveloper", 
                Period = "March 2023-Feb 2025", 
                Tasks = new List<string>
                {
                    "\tDeveloped and maintained enterprise-level web applications using .NET Core and C#.",
                    "\tDesigned and implemented RESTful APIs for seamless frontend-backend integration."
                }  
            },
            new() { Establishment = "ArshTag", Role = ".NetDeveloper Intern",
                Period = "Sept 2022-Feb 2023",
                Tasks = new List<string>
                {
                    "\tWorked closely with senior developers to learn and implement best practices in .NET development.",
                    "\tAssisted in database design and optimized SQL queries for more efficient data storage and retrieval."
                }
            },
            new() { Establishment = "Al-Haqq", Role = "Software Developer",
                Period = "March 2021-July 2022",
                Tasks = new List<string>
                {
                    "\tImplemented version control using Git and GitHub in developing web applications.",
                    "\tDeveloped console applications using C# and Visual Studio."
                }
            }
        };
    }
}
