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
}

