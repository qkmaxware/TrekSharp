using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TrekSharp {

public class TimelineEvent {
    public DateTime Timestamp {get; private set;}
    public string Title {get; private set;}

    public TimelineEvent (DateTime timestamp, string title) {
        this.Timestamp = timestamp;
        this.Title = title;
    }
}

public class Timeline : IList<TimelineEvent> {
    private SortedList<DateTime, TimelineEvent> events = new SortedList<DateTime, TimelineEvent>();

    public static Timeline PrimeTimeline() {
        var timeline = new Timeline();

        timeline.Add(new TimelineEvent(new DateTime(year: 1992, month: 01, day: 01), "Eugenics Wars Starts"));
        timeline.Add(new TimelineEvent(new DateTime(year: 1996, month: 01, day: 01), "Eugenics Wars Ends"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2063, month: 01, day: 01), "First Contact"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2161, month: 01, day: 01), "United Federation of Planets Founded"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2266, month: 01, day: 01), "USS Enterprise Starts 5 Year Mission"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2270, month: 01, day: 01), "USS Enterprise Ends 5 Year Mission"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2273, month: 01, day: 01), "V'ger Discovered"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2285, month: 01, day: 01), "Khan Defeated"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2286, month: 01, day: 01), "Whale Probe Disaster Averted"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2293, month: 01, day: 01), "Praxis Destroyed"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2363, month: 04, day: 30), "First Contact with the Q"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2365, month: 01, day: 28), "First Contact with the Borg"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2366, month: 06, day: 06), "Battle of Wolf 359"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2369, month: 01, day: 06), "Bajoran Wormhole Discovered"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2371, month: 02, day: 12), "USS Voyager is Lost"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2371, month: 06, day: 28), "USS Enterprise-D Destroyed"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2373, month: 07, day: 29), "Cardassia Joins the Dominion"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2373, month: 08, day: 01), "Dominion War Starts"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2374, month: 08, day: 01), "Operation Return"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2375, month: 01, day: 01), "Dominion War Ends"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2378, month: 05, day: 18), "USS Voyager Returns to Earth"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2380, month: 01, day: 01), "USS Titan Fends off Packled Attack"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2385, month: 01, day: 01), "Synth Attack on Utopia Planitia"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2387, month: 01, day: 01), "Romulus Destroyed"));

        return timeline;
    }

    public static Timeline KelvinTimeline() {
        var timeline = new Timeline();

        timeline.Add(new TimelineEvent(new DateTime(year: 2233, month: 01, day: 01), "Romulan Temporal Incursion"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2258, month: 01, day: 01), "Kirk Assumes Command of the Enterprise"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2260, month: 01, day: 01), "Khan is Defeated"));
        timeline.Add(new TimelineEvent(new DateTime(year: 2262, month: 01, day: 01), "USS Franklin Found"));

        return timeline;
    }

    public TimelineEvent this[int index] { 
        get => events.Values.ElementAt(index);
        set => throw new ArgumentException("Cannot set objects in timeline by position");
    }

    public int Count => events.Count;

    public bool IsReadOnly => false;

    public void Add(TimelineEvent item) {
        this.events.Add(item.Timestamp, item);
    }

    public void Clear() {
        events.Clear();
    }

    public bool Contains(TimelineEvent item) {
        return events.ContainsValue(item);
    }

    public void CopyTo(TimelineEvent[] array, int arrayIndex) {
        this.events.Values.ToArray().CopyTo(array,arrayIndex);
    }

    public IEnumerator<TimelineEvent> GetEnumerator() {
        return events.Values.GetEnumerator();
    }

    public IEnumerable<TimelineEvent> FromDate(DateTime date) {
        foreach(var kv in this.events) {
            if (kv.Key < date) {
                continue;
            } else {
                yield return kv.Value;
            }
        }
    }

    public int IndexOf(TimelineEvent item) {
        return events.Values.IndexOf(item);
    }

    public void Insert(int index, TimelineEvent item) {
        Add(item);
    }

    public bool Remove(TimelineEvent item) {
        return events.Remove(item.Timestamp);
    }

    public void RemoveAt(int index) {
        Remove(this.events.Values.ElementAt(index));
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return events.Values.GetEnumerator();
    }

}

}