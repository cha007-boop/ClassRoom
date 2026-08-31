using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student
{
    private int _birthMonth;
    private int _birthDay;
    
    public string Name { get; private set; }
    public int BirthMonth
    {
        get { return _birthMonth; }
        private set { _birthMonth = value; }
    }
    public int BirthDay
    {
        get { return _birthDay; }
        private set { _birthDay = value; }
    }
    public Student(string name, int birthMonth, int birthDay)
    {
        Name = name;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}

