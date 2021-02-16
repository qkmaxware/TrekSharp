using System;
using System.Collections.Generic;

namespace TrekSharp{
    
public static class ListExtentions {
    private static Random random = new Random();
    public static T Random<T>(this List<T> items) {
        return items[random.Next(items.Count)];   
    }
}

}