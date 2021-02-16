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

    public static PlayerCharacter Random (params Rulebook[] rules) {
        var allSpecies = rules.SelectMany(book => book.Species).ToList();
        
        // 1.a Pick species
        var spec = allSpecies.Random();
        return RandomInSpecies(spec, rules);
    }
    public static PlayerCharacter RandomInSpecies (Species species, params Rulebook[] rules) {
        var random = new System.Random();
        var character = new PlayerCharacter {
            Name = null,
            Rank = null,
            Species = species,
            Attributes = new Attributes {
                Control     = 7,
                Fitness     = 7,
                Presence    = 7,
                Daring      = 7,
                Insight     = 7,
                Reason      = 7,          
            },
            Disciplines = new Disciplines {
                Command     = 1,
                Security    = 1,
                Science     = 1,
                Conn        = 1,
                Engineering = 1,
                Medicine    = 1,
            },
            Equipment = new List<Item>(),
            Values = new List<string>(),
            Focuses = new List<string>(),
            Talents = new List<CharacterTalent>(),
        };

        List<string> values = new List<string>() {
            "Doesn’t Believe in a No-Win Situation"
            , "There’s No Such Thing as The Unknown — Only the Temporarily Hidden"
            , "Married to the Enterprise"
            , "Risk is Our Business"
            , "Logic is the Beginning, not the end, of Wisdom"
            , "Seek Out New Life, and New Civilizations"
            , "Angry at the Xindi"
            , "Proud Son/Daughter of Andoria"
            , "Faith in the Prophets"
            , "Compassion through Understanding"
            , "Safety in Numbers"
            , "The Drive for Exploration"
            , "All Ideas must Withstand Scrutiny"
            , "Four Lifetimes of Adventure"
            , "The Needs of the Many Outweigh the Needs of the Few, or the One"
            , "A Starship is a Home, it’s Crew a Family"
            , "Most Comfortable in a Crowd"
            , "Body and Mind Alike Must Be Healthy"
            , "No Stranger to Violence"
            , "Emotion in a Crisis only Makes Things Worse"
            , "Engineer at Heart"
            , "Understanding is the Purpose of Life"
            , "Serving Starfleet is a Family Tradition"
            , "Indefatigable Confidence"
            , "Proud and Honest"
            , "Insatiable Curiosity"
            , "Understands Technology Better Than People"
            , "A Responsibility to the Truth"
            , "Inexperienced and Idealistic"
            , "Threw Out The Handbook and Wrote My Own"
            , "Always Prepared, Always Vigilant"
            , "Precise to a Fault"
            , "Fast Ships and Strange New Worlds"
            , "Exploring to Test New Theories"
            , "A Theory For Every Situation"
            , "Seen Too Much to be Surprised"
            , "Holds Everyone to the Highest Standards"
            , "Nothing Better Than Practical Experience"
            , "Understands Machines Better Than People"
            , "Meticulous Scrutiny and Pride in His/Her Work"
            , "The Price of Peace is Vigilance"
            , "Driven to Ease Suffering"
            , "Voice of the Crew"
            , "The Captain’s Second Opinion"
            , "Living with Your Ideals is Harder than Dying for Them"
            , "Rough and Tumble Doctor"
            , "There Is No Higher Calling Than to Serve"
            , "We Endure Hardship, So That Others Do Not Have To"
            , "A Failure to Act Can Be As Dangerous As Acting Rashly"
            , "Wisdom is the Beginning of Logic, Not the End"
        };
        List<string> focuses = new List<string>() {
            "Finances",
            "Geology",
            "Linguistics",
            "Manufacturing",
            "Metallurgy",
            "Negotiation",
            "Survey",
            "Animal Handing",
            "Athletics",
            "Emergency Medicine",
            "Endurance",
            "Ground Vehicles",
            "Infectious Diseases",
            "Navigation",
            "Toxicology",
            "Astrophysics",
            "Astronavigation",
            "Computers",
            "Cybernetics",
            "Botany",
            "Cultural Studies",
            "Holoprogramming",
            "Music",
            "Observation",
            "Persuasion",
            "Psychology",
            "Composure",
            "Debate",
            "Diplomacy",
            "Espionage",
            "Interrogation",
            "Law",
            "Philosophy",
            "Starfleet Protocol",
            "Composure",
            "Extra-Vehicular Activity",
            "Evasive Action",
            "Helm Operations",
            "Inspiration",
            "Small Craft",
            "Starship Recognition",
            "Team Dynamics",
            "Power Systems",
            "Tactical Systems",
            "Transporters",
            "Replicators",
            "Warp Dynamics",
            "Quantum Mechanics",
            "Trauma Surgery",
            "Virology",
            "Xenobiology",
            "Genetics",
        };

        // 1.b Apply species
        character.Attributes.Add(character.Species.AttributeModifiers);
        if (character.Species.AttributeModifiers == null) {
            // Randomly pick 3 attributes to increase
            character.Attributes.RandomlyIncrement(3);
        }

        // 1.c Pick starting talent
        var allTalents = rules.SelectMany(book => book.Talents).ToList();
        character.Talents.Add(
            allTalents.Where(talent => talent.CanBeUsedBy(character)).ToList().Random()
        );

        // 2.a Pick environment
        var allEnviron = rules.SelectMany(book => book.Environments).ToList();
        var environ = allEnviron.Random();
        character.Attributes.RandomlyIncrement(environ.AttributeSelectionMask ?? character.Species.AttributeModifiers);
        character.Disciplines.RandomlyIncrement(environ.DisciplineSelectionMask);
            // Add value
            character.Values.Add(values.Random());

        // 3.a Pick upbringing
        var allUps = rules.SelectMany(book => book.Upbringings).ToList();
        var up = allUps.Random();
        character.Attributes.Add(random.NextDouble() > 0.5 ? up.AcceptAttributeModifier : up.RejectAttributeModifier);
        character.Disciplines.RandomlyIncrement(up.DisciplineMask);
            // Pick focus
            character.Focuses.Add(focuses.Random());
            // Pick talent
            character.Talents.Add(
                allTalents.Where(talent => talent.CanBeUsedBy(character)).ToList().Random()
            );

        // 4. Starfleet academy
        var path = random.Next(6);
        if (path >= 0 && path <= 1) {
            // Command  
                // Attributes
                character.Attributes.RandomlyIncrement(3);

                // Disciplines
                var major = random.NextDouble() < 0.5 ? 0 : 3 ;
                character.Disciplines[major] += 2;          // Major
                character.Disciplines[random.Next(6)] += 1; // Minor A
                character.Disciplines[random.Next(6)] += 1; // Minor B
        } else if (path >= 2 && path <= 3) {
            // Operations
                // Attributes
                character.Attributes.RandomlyIncrement(3);

                // Disciplines
                var major = random.NextDouble() < 0.5 ? 1 : 4 ;
                character.Disciplines[major] += 2;          // Major
                character.Disciplines[random.Next(6)] += 1; // Minor A
                character.Disciplines[random.Next(6)] += 1; // Minor B
        } else if (path >= 4 && path <= 5) {
            // Sciences
                // Attributes
                character.Attributes.RandomlyIncrement(3);

                // Disciplines
                var major = random.NextDouble() < 0.5 ? 2 : 5 ;
                character.Disciplines[major] += 2;          // Major
                character.Disciplines[random.Next(6)] += 1; // Minor A
                character.Disciplines[random.Next(6)] += 1; // Minor B
        }
            // Pick value
            character.Values.Add(values.Random());
            // Pick focuses (3)
            character.Focuses.Add(focuses.Random());
            character.Focuses.Add(focuses.Random());
            character.Focuses.Add(focuses.Random());
            // Pick talent
            character.Talents.Add(
                allTalents.Where(talent => talent.CanBeUsedBy(character)).ToList().Random()
            );

        // 5.a Career
            // Pick value
            character.Values.Add(values.Random());
            // Pick talent (Veteran talent for Veteran officer, and Untapped Potential for Young Officer)
            character.Talents.Add(
                allTalents.Where(talent => talent.CanBeUsedBy(character)).ToList().Random()
            );
            // Pick focuses (2)
            character.Focuses.Add(focuses.Random());
            character.Focuses.Add(focuses.Random());

        // 6.a Career Events
        var allEvents = rules.SelectMany(book => book.CareerEvents).ToList();
        for (var evt = 0; evt < 2; evt ++) {
            var e = allEvents.Random();
            character.Attributes.RandomlyIncrement(e.AttributeSelectionMask);
            character.Disciplines.RandomlyIncrement(e.DisciplineSelectionMask);
        }

        // 7.a 
            // Add value
            character.Values.Add(values.Random());
            // Clamp attributes to 12
            for (var i = 0; i < 6; i++) {
                if (character.Attributes[i] > 12) {
                    var difference = character.Attributes[i] - 12;
                    character.Attributes[i] = 12;
                    // redistribute to lowest
                    var parts = new int[]{0, 1, 2, 3, 4, 5};
                    for (var j = 0; j < difference; j++) {
                        var index = parts.OrderBy(index => character.Attributes[i]).First();
                        character.Attributes[index] += 1;
                    }
                }
            }
            // Clamp disciplines to 5 (4 for the rest)
            for (var i = 0; i < 6; i++) {
                if (character.Disciplines[i] > 4) {
                    var difference = character.Attributes[i] - 4;
                    character.Attributes[i] = 4;
                    // redistribute
                    var parts = new int[]{0, 1, 2, 3, 4, 5};
                    for (var j = 0; j < difference; j++) {
                        var index = parts.OrderBy(index => character.Disciplines[i]).First();
                        character.Disciplines[index] += 1;
                    }
                }
            }
            // Compute stress
            var stress = character.Attributes.Fitness + character.Disciplines.Security;
            // Damage bonus
            var bonus = character.Disciplines.Security;
            // Name
            // Rank
            character.Rank = Rank.Lieutenant;
            // Equipment
        
        return character;
    } 

}

}