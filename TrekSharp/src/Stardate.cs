using System;

namespace TrekSharp {
    
public static class StardateExtentions {
    // Friday, July 5, 2318
    private static DateTime TNG0 = new DateTime(
        2318, 07, 5, 
        12, 00, 00, 
        DateTimeKind.Utc
    );

    //private static double StardatesPerYear = 918.23186;
    private static double DaysPerStardate = 0.397766856;

    public static double Stardate(this DateTime date) {
        var days = (date - TNG0).TotalDays;
        var stardates = days / DaysPerStardate;
        return stardates;
    }

    public static DateTime AsStardate(this double stardate) {
        return TNG0 + TimeSpan.FromDays(stardate * DaysPerStardate); 
    }
}

}
