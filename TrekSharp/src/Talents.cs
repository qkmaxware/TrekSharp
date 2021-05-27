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
        return character.Species.Name == this.species || (character.Species.OtherHeritage != null && character.Species.OtherHeritage.Select(s => s.Name).Contains(this.species));
    }
    
}

public class HiddenTalent : CharacterTalent {
    public HiddenTalent (string name, string desc) : base(name, desc) {}

    public override bool CanBeUsedBy(Character character) {
        return false;
    }
    
}

public class DisciplineAndTalentTalent : CharacterTalent {
    public Disciplines Disciplines {get; set;}
    public string TalentName {get; set;}
    public DisciplineAndTalentTalent() {}
    public DisciplineAndTalentTalent(Disciplines disciplines, string talent, string name, string desc) : base(name, desc) {
        this.Disciplines = disciplines;
        this.TalentName = talent;
    }
    private bool Matches(Disciplines match, Disciplines against) {
        for (var i = 0; i < 6; i++) {
            if (match[i] < against[i])
                return false; // Not a match for this set
        }
        return true;
    }

    public override bool CanBeUsedBy(Character character) {
        if (character is PlayerCharacter player) {
            if (player.Talents == null)
                return false;
            return Matches(character.Disciplines, Disciplines) && player.Talents.Select(talent => talent.Name).Contains(TalentName);
        } else {
            return false;
        }
    }
}

public class DisciplineAndFocusTalent : CharacterTalent {
    public Disciplines Disciplines {get; set;}
    public string Focus {get; set;}
    public DisciplineAndFocusTalent() {}
    public DisciplineAndFocusTalent(Disciplines disciplines, string focus, string name, string desc) : base(name, desc) {
        this.Disciplines = disciplines;
        this.Focus = focus;
    }
    private bool Matches(Disciplines match, Disciplines against) {
        for (var i = 0; i < 6; i++) {
            if (match[i] < against[i])
                return false; // Not a match for this set
        }
        return true;
    }

    public override bool CanBeUsedBy(Character character) {
        if (character is PlayerCharacter player) {
            if (player.Focuses == null)
                return false;
            return Matches(character.Disciplines, Disciplines) && player.Focuses.Contains(Focus);
        } else {
            return false;
        }
    }
}

public class AttributeAndDisciplineLimitedTalent : CharacterTalent {
    public Disciplines Disciplines {get; set;}
    public Attributes Attributes {get; set;}

    public AttributeAndDisciplineLimitedTalent() {}
    public AttributeAndDisciplineLimitedTalent(Attributes attr, Disciplines disc, string name, string desc) : base(name, desc) {
        this.Disciplines = disc;
        this.Attributes = attr;
    }
    private bool Matches(Disciplines match, Disciplines against) {
        for (var i = 0; i < 6; i++) {
            if (match[i] < against[i])
                return false; // Not a match for this set
        }
        return true;
    }
    private bool Matches(Attributes match, Attributes against) {
        for (var i = 0; i < 6; i++) {
            if (match[i] < against[i])
                return false; // Not a match for this set
        }
        return true;
    }
    public override bool CanBeUsedBy(Character character) {
        return Matches(character.Disciplines, Disciplines) && Matches(character.Attributes, Attributes);
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