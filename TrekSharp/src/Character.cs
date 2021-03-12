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
}

public class Character {
    public virtual string Name {get; set;}
    public Faction Faction => Rank.Faction;
    public Rank Rank {get; set;}
    public string Assignment {get; set;}
    public Species Species {get; set;}

    public Attributes Attributes {get; set;}
    public Disciplines Disciplines {get; set;}

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

    public override int BonusStress => Talents.Select(talent => talent.StressModifier).Sum();

}

}