using System;

namespace TrekSharp {
    
public class BasicTask {
    public string Name {get; set;}
    public int Difficulty {get; set;}

    public BasicTask() {}

    public BasicTask (string name, int difficulty = 1) {
        this.Name = name;
        this.Difficulty = difficulty;
    }

    public bool IsSuccessful (int successes) {
        return this.Difficulty <= successes;
    }

    public bool Attempt(Character character, Func<Attributes, double> attribute, Func<Disciplines, double> discipline) {
        var dice = new D20();
        var successes = 0;
        var targetNumber = attribute(character.Attributes) + discipline(character.Disciplines);
        dice.Roll();
        successes += dice.NumericValue <= targetNumber ? 1 : 0;
        dice.Roll();
        successes += dice.NumericValue <= targetNumber ? 1 : 0;
        
        return IsSuccessful(successes);
    }
}

public class ExtendedTask {
    public string Name {get; set;}
    public int Difficulty {get; set;}
    public int Magnitude {get; set;}
    public int Resistance {get; set;}
    public int TotalWork {get; set;} = 0;
    public int WorkTrack {get; set;}
    public int Breakthroughs {get; set;}

    public int RollsAgainst {get; set;}
    public void ApplyRollsAgainst() {
        var work = RollsAgainst;
        this.RollsAgainst = 0;

        work -= this.Resistance;
        if (work <= 0)
            return;

        if (work >= 5) {
            this.Breakthroughs++;
        }

        this.TotalWork += work;
        if (this.TotalWork >= WorkTrack)
            this.TotalWork = WorkTrack;
        if (this.TotalWork == WorkTrack)
            this.Breakthroughs++;
    }

    public bool IsDone => Breakthroughs >= Magnitude;

    public ExtendedTask() {}

    public ExtendedTask (string name, int difficulty, int workTrackSize, int magnitude, int resistance) {
        this.Name = name;
        this.Difficulty = difficulty;
        this.Magnitude = magnitude;
        this.Resistance = resistance;
        this.WorkTrack = workTrackSize;
        this.Breakthroughs = 0;
    }
}


}