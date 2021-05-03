using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools {

public class Logbook : IEnumerable<LogEntry> {
    public SortedList<double, List<LogEntry>> Entries {get; set;}
    public LogEntry Earliest => Entries?.Min().Value.FirstOrDefault();
    public LogEntry Latest {
        get {
            var last_set = Entries?.Max().Value;
            if (last_set.Count < 1)
                return null;
            var last_value = last_set[last_set.Count - 1];
            return last_value;
        }
    }
    public int Count => Entries?.Count ?? 0;
    public Logbook() {
        this.Entries = new SortedList<double, List<LogEntry>>();
    }
    public void Record(LogEntry entry) {
        if (Entries.ContainsKey(entry.Stardate)) {
            this.Entries[entry.Stardate].Add(entry);
        } else {
            this.Entries.Add(entry.Stardate, new List<LogEntry> { entry });
        }
    }
    public void Delete(LogEntry entry) {
        if (this.Entries.ContainsKey(entry.Stardate)) {
            var list = this.Entries[entry.Stardate];
            list.Remove(entry);
            if (list.Count < 1) {
                this.Entries.Remove(entry.Stardate);
            }
        }
    }

    public IEnumerator<LogEntry> GetEnumerator() {
        foreach (var log_set in this.Entries) {
            foreach (var entry in log_set.Value) {
                yield return entry;
            }
        }
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