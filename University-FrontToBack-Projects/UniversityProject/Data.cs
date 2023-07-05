using System.Text.RegularExpressions;
using UniversityProject.Models;

namespace UniversityProject;

public static class Data
{
    public static List<Student> Students = new List<Student>
        {
            new Student{Id=1,FullName="Novruzlu Adem",Group="a1"},
            new Student{Id=2,FullName="Feliyev Felaket",Group="a2"},
            new Student{Id=3,FullName="Shemiyev Shemi",Group="b1"},
            new Student{Id=4,FullName="Shoshuyev Shoshu",Group="b2"}
        };
    public static List<Models.Group> Groups = new List<Models.Group> {
        new Models.Group { Id = 1, Name = "a1" },
        new Models.Group { Id = 2, Name = "a2" },
        new Models.Group { Id = 3, Name = "b1" },
        new Models.Group { Id = 4, Name = "b2" }
    };
}