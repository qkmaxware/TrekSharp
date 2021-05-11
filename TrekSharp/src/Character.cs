using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {

public enum HealthState {
    Healthy,
    Unconscious,
    Dying,
    Dead
}

public class NpcCharacter : Character {
    public List<string> Focuses {get; set;} 
    public List<string> Values {get; set;} 
    public List<string> SpecialRules {get; set;} 
    public int BaseStress {get; set;}
    public override int TotalStress => this.BaseStress + this.BonusStress;

    public float PlayerDifficulty {
        get {
            var sum = Disciplines.Enumerate().Select(x => x.Value).Sum();
            return Math.Max(0, 0.0571f * sum + 0.1429f); // will be 0.6 at 8 disciplines and 1 for 15 disciplines allows scaling for more powerful creatures
        }
    } 
    public bool IsMinor => Disciplines.Enumerate().Select(x => x.Value).Sum() <= 8;
    public bool IsNotable => !IsMinor && !IsMajor;
    public bool IsMajor => Disciplines.Enumerate().Select(x => x.Value).Sum() > 16;
}

public class Character {
    public virtual string Name {get; set;}
    public Faction Faction => Rank?.Faction;
    public Rank Rank {get; set;}
    public string Assignment {get; set;}
    public Species Species {get; set;}

    public Attributes Attributes {get; set;}
    public Disciplines Disciplines {get; set;}

    public Avatar Avatar {get; set;} = null;

    public virtual int TotalStress => Attributes.Fitness + Disciplines.Security + BonusStress;
    public virtual int BonusStress {get;} = 0;
    public int UsedStress {get; set;}
    public int Resistance {get; set;}

    public int BonusDamageDice => Disciplines.Security;

    public List<Item> Equipment {get; set;}

    public void ApplyDamage(int damage) {
        damage -= Resistance;
        if (damage > 0) {
            this.UsedStress += damage;
            if (this.UsedStress >= this.TotalStress) {
                // Reduce health state
            }
        }
    }
}

public class SupportCharacter : Character {
    public List<string> Focuses {get; set;} 
}

public class PlayerCharacter : Character {

    public List<string> Values {get; set;}
    public List<string> Focuses {get; set;}
    public List<CharacterTalent> Talents {get; set;}

    public string Environment {get; set;}
    public string Upbringing {get; set;}

    private int _det = 1;
    public int Determination {
        get => _det;
        set => _det = (value < 0 ? 0 : value);
    }

    public override int BonusStress => Talents.Select(talent => talent.StressModifier).Sum();

}

}