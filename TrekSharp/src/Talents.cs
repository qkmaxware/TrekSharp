using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {

public class CharacterTalent {

    public string Name {get; set;}
    public string Description {get; set;}

    public int StressModifier {get; set;} = 0;


    public CharacterTalent() {}

    public CharacterTalent (string name, string description) {
        this.Name = name;
        this.Description = description;
    }

    public virtual bool CanBeUsedBy(Character character) {
        return true;
    }

    public override string ToString() {
        return this.Name;
    }

}

public class SpeciesRestrictedTalent : CharacterTalent {
    public string species {get; set;}
    public SpeciesRestrictedTalent() {}
    public SpeciesRestrictedTalent (Species species, string name, string description) : base (name, description) {
        this.species = species.Name;
    }
    public SpeciesRestrictedTalent (string species, string name, string description) : base (name, description) {
        this.species = species;
    }
    public override bool CanBeUsedBy(Character character) {
        return character.Species.Name == this.species;
    }
    
}

public class DisciplineLimitedTalent : CharacterTalent {
    public List<Disciplines> minDisciplines {get; set;}
    public DisciplineLimitedTalent() {}
    public DisciplineLimitedTalent(Disciplines mins, string name, string desc) : base (name, desc) {
        this.minDisciplines = new List<Disciplines>(){ mins };
    }
    public DisciplineLimitedTalent(IEnumerable<Disciplines> minOptions, string name, string desc) : base (name, desc) {
        this.minDisciplines = minOptions.ToList();
    }
    private bool Matches(Disciplines match, Disciplines against) {
        for (var i = 0; i < 6; i++) {
            if (match[i] < against[i])
                return false; // Not a match for this set
        }
        return true;
    }
    public override bool CanBeUsedBy(Character character) {
        foreach (var disc in minDisciplines) {
            if (Matches(character.Disciplines, disc)) {
                return true;
            }
        }
        return false;
    }
}
    
}