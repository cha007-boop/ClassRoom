using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student
{
    private int _birthYear;
    private int _birthMonth;
    private int _birthDay;

    public string Name { get; private set; }
    public int BirthYear
    {
        get { return _birthYear; }
        set { _birthYear = value; }
    }
    public int BirthMonth
    {
        get { return _birthMonth; }
        set
        {
            int maxDays = DateTime.DaysInMonth(BirthYear, value);
            ValidateBirthday(BirthYear, value, maxDays);
            if (BirthDay > maxDays)
                BirthDay = maxDays;
            _birthMonth = value;
        }
    }
    public int BirthDay
    {
        get { return _birthDay; }
        set
        {
            ValidateBirthday(BirthYear, BirthMonth, value);
            _birthDay = value;
        }
    }
    public Student(string name, int birthYear, int birthMonth, int birthDay)
    {
        Name = name;
        ValidateBirthday(birthYear, birthMonth, birthDay);
        BirthYear = birthYear;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }

    private void ValidateBirthday(int birthYear, int birthMonth, int birthDay)
    {
        if (birthMonth < 1 || birthMonth > 12)
        {
            throw new ArgumentOutOfRangeException("Birth month must be between 1 and 12.");
        }
        int maxDays = DateTime.DaysInMonth(birthYear, birthMonth);
        if (birthDay < 1 || birthDay > maxDays)
        {
            throw new ArgumentOutOfRangeException($"Birth day for this month must be between 1 and {maxDays}");
        }

    }

    public override string ToString()
    {
        return $"Name: {Name}, Birth season {Helper.MonthToSeason(BirthMonth)}";
    }
}

