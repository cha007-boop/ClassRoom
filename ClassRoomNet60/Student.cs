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
        set
        {
            if (value > 0 && value <= 12)
                _birthMonth = value;
            else
            {
                throw new ArgumentOutOfRangeException("BirthMonth must be between 1 and 12.");
            }
        }
    }
    public int BirthDay
    {
        get { return _birthDay; }
        set { _birthDay = value; }
    }
    public Student(string name, int birthMonth, int birthDay)
    {
        Name = name;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Birth season {Helper.MonthToSeason(BirthMonth)}";
    }
}

