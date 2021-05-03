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

    public static KeyValuePair<K, V> Min<K, V>(this SortedList<K, V> dict) {
        return new KeyValuePair<K, V>(dict.Keys[0], dict.Values[0]); //is O(1)
    }

    public static KeyValuePair<K, V> Max<K, V>(this SortedList<K, V> dict) {
        var index = dict.Count - 1; //O(1) again
        return new KeyValuePair<K, V>(dict.Keys[index], dict.Values[index]);
    }

}

}