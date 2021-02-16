using System;

namespace TrekSharp {
    
public static class StardateExtentions {
    // Friday, July 5, 2318
    private static DateTime TNG0 = new DateTime(
        2318, 07, 5, 
        12, 00, 00, 
        DateTimeKind.Utc
    );

    private static double StardatesPerYear = 918.23186;

    public static double Stardate(this DateTime date) {
        return ((date - TNG0).TotalDays / 365.0) * StardatesPerYear;
    }

    public static DateTime AsStardate(this double stardate) {
        return TNG0 + TimeSpan.FromDays((stardate / StardatesPerYear) * 365.0); 
    }
}

}
