using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools {

public class Logbook : IEnumerable<LogEntry> {
    public SortedList<double, LogEntry> Entries {get; set;}
    public LogEntry Earliest => Entries?.Min().Value;
    public LogEntry Latest => Entries?.Max().Value;
    public int Count => Entries?.Count ?? 0;
    public Logbook() {
        this.Entries = new SortedList<double, LogEntry>();
    }
    public void Record(LogEntry entry) {
        this.Entries.Add(entry.Stardate, entry);
    }
    public void Delete(LogEntry entry) {
        this.Entries.Remove(entry.Stardate);
    }

    public IEnumerator<LogEntry> GetEnumerator() {
        return this.Entries?.Values?.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}

public class LogEntry {
    public double Stardate {get; set;}
    public DateTime CalendarDate { 
        get => Stardate.AsStardate();
        set {
            Stardate = value.Stardate();
        }
    }
    public bool Flagged {get; set;} = false;
    public string Content {get; set;}

    public IEnumerable<char> ExcerptIterator() {
        if (Content == null || Content.Length < 1)
            yield break;

        int i = 0;
        for (i = 0; i < 120; i++) {
            if (i >= Content.Length)
                break;

            char c = Content[i];
            if (c == '\n')
                break;
            else 
                yield return c;
        }
        if (i == 120) {
            yield return '.';
            yield return '.';
            yield return '.';
        }
    }
    public string ExcerptString() {
        return new string(ExcerptIterator().ToArray());
    }
}

}