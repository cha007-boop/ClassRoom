using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ClassRoom
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public DateTime SemesterStart { get; set; }

    public ClassRoom()
    {
        Name = string.Empty;
        Students = new List<Student>();
        SemesterStart = DateTime.MinValue;
    }

    public void PrintBirthdayCountForSeasons()
    {

    }


    public override string ToString()
    {
        return $"Class name: {Name}" +
               $"\nSemester start: {SemesterStart.ToShortDateString()}" +
               $"\n\nStudent{(Students.Count > 1 ? "s" : "")}:" +
               $"\n\t{string.Join("\n\t", Students)}";
    }
}

