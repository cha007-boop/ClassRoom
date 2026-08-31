using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Helper
{
    public static string MonthToSeason(int month)
    {
        switch (month)
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
                return "Month must be in interval 1-12";
        }
    }
    public static string MonthToSeason(DateTime dateTime)
    {
        return MonthToSeason(dateTime.Month);
    }

    public static void PrintSeasonCountForMonths(IEnumerable<int> months)
    {
        var linqResult =
            months
            .GroupBy(m => MonthToSeason(m))
            .Select(seasonGroup => new
            {
                season = seasonGroup.Key,
                seasonCount = seasonGroup.Count()
            });

        Console.WriteLine(string.Join("\n", linqResult.Select(l => $"Season: {l.season}\tCount: {l.seasonCount}")));
    }

    public static void PrintSeasonCountForMonths(IEnumerable<DateTime> dates)
    {
        PrintSeasonCountForMonths(dates.Select(d => d.Month));
    }
}

