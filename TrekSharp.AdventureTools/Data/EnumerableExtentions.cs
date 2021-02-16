using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools {

public static class EnumerableExtentions {

    public static IEnumerable<IEnumerable<T>> ByN<T>(this IEnumerable<T> list, int N) {
        var indexedItems = list.Select((item, index) => new {index, item});
        var groupedItems = indexedItems.GroupBy(indexedItem => indexedItem.index / N,
                   indexedItem => indexedItem.item,
                   (key, items) => items);
        return groupedItems;
    }

}

}