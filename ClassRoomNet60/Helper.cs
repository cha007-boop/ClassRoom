using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Helper
{
    public static string MonthToSeason(int month)
    {
        switch (month % 12)
        {
            case 12: case 1: case 2:
                return "Winter";
            case 3: case 4: case 5:
                return "Spring";
            case 6: case 7: case 8:
                return "Summer";
            case 9: case 10: case 11:
                return "Autumn";
            default:
                return "Winter";
        }
    }
    public static string MonthToSeason(DateTime dateTime)
    {
        return MonthToSeason(dateTime.Month);
    }
}

