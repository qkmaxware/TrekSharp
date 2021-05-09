using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools {

public class LogbookEnumerator : IEnumerable<LogEntry> {
    private Logbook logs;
    public LogbookEnumerator(Logbook logs) {
        this.logs = logs;
    }

    public IEnumerator<LogEntry> GetEnumerator() {
        if (this.logs == null || this.logs.Entries == null)
            yield break;

        foreach (var entry in this.logs.Entries) {
            yield return entry;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}

public class Logbook {
    public List<LogEntry> Entries {get; set;}
    public LogEntry Earliest => Entries.FirstOrDefault();
    public LogEntry Latest {
        get {
            if (Entries.Count < 1)
                return null;
            else    
                return Entries[Entries.Count - 1];
        }
    }
    public int Count => Entries?.Count ?? 0;
    public Logbook() {
        this.Entries = new List<LogEntry>();
    }
    public void Record(LogEntry entry) {
        this.Entries.Add(entry);
        this.Entries = this.Entries.OrderBy(e => e.Stardate).ToList();
    }
    public void Delete(LogEntry entry) {
        this.Entries.Remove(entry);
    }
    public LogbookEnumerator Enumerate() {
        return new LogbookEnumerator(this);
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