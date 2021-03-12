using System;
using System.Collections.Generic;

namespace TrekSharp{
    
public static class RandomizerExtentions {
    private static Random random = new Random();
    public static T Random<T>(this List<T> items) {
        return items[random.Next(items.Count)];   
    }

    public static int Random(this Range range) {
        return random.Next(range.Start.Value, range.End.Value);
    }

    public static int NextExcept(this System.Random random, int max, int except) {
        var value = random.Next(max);
        while (value == except) {
            value = random.Next(max);
        }
        return value;
    }
}

}