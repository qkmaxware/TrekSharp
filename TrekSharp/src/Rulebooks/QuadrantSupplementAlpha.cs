using System;
using System.Collections.Generic;

namespace TrekSharp.Rulebooks {

public class QuadrantSupplementAlpha : BaseRulebook {
    private QuadrantSupplementAlpha () {}

    public static readonly QuadrantSupplementAlpha Instance = new QuadrantSupplementAlpha() {
        Species = new List<Species> {
            new Species(
                "Arbazan", 
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1
                }
            ),
            new Species(
                "Arkarian",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Aurelian",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Insight = 1
                }
            ),
            new Species(
                "Caitian",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Insight = 1,
                }
            ),
            new Species(
                "Cardassian",
                new Attributes {
                    Control = 1,
                    Presence = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Edosian",
                new Attributes {
                    Fitness = 1,
                    Insight = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Ferengi",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Grazerite",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Haliian",
                new Attributes {
                    Daring = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Ktarian",
                new Attributes {
                    Control = 1,
                    Reason = 1,
                    Fitness = 1,
                }
            ),
            new Species(
                "Zaranite",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Reason = 1,
                }
            )
        },
        Talents = new List<CharacterTalent> {
            new SpeciesRestrictedTalent("Arbazan", "Cold Shoulder", "Strong self-discipline and conservative cultural values prevent Arbazan from being susceptible to their baser desires. Any character attempting to use their physical attractiveness or seductive nature against an Arbazan during a Social Conflict increases their Difficulty by 1."),
            new SpeciesRestrictedTalent("Arbazan", "The Protocol of Politics", "Arbazan are naturally adept at the subtleties of social protocol, and often come to rely on it heavily during social interactions. To many other species, the Arbazan’s focus on such rules and guidelines is often viewed as obsessive, but to the Arbazan, it is simply the natural way to engage in interactions. Whenever a character with this Talent attempts a test during Social Conflict, they may re-roll a d20 so long as they succeeded at an earlier Test relating to the recollection or research of appropriate social graces, protocols, or faux pas."),

            new SpeciesRestrictedTalent("Arkarian", "Cool Under Pressure", "Demands of Arkarian society place strict requirements on social interactions. You are able to keep your outward expressions neutral, revealing as little as possible. Whenever you are engaged in a Social Conflict, you are considered to have an Advantage until you fail a Composure Test."),
            new SpeciesRestrictedTalent("Arkarian", "Quick Recovery", "The increased bone density of the brow and nasal areas are also found throughout the rest of their physical frame and provide Arkarians with superior protection from blunt trauma. They gain 2 additional Resistance against any attack made with blunt weapons."),

            new SpeciesRestrictedTalent("Aurelian", "Aerial Combat", "While most Aurelians avoid confrontation, they understand that sometimes it is necessary for survival. Some Aurelians have learned to take advantage of their natural flying ability. Characters with this Talent may use a Minor Action to move to any Zone within Long Range instead of Medium, and ignore any Difficulty increases associated with terrestrial terrain – however, they increase the Difficulty of any weather-related hazards by 1. Characters with this Talent are also considered to have the Advantage when making an attack against ground-based Targets."),
            new SpeciesRestrictedTalent("Aurelian", "Keen Senses", "Aurelians are known for their keen vision, hearing, and directional sense. Characters with this Talent reduce the Difficulty due to Distance of Perception Tasks by 1."),
        
            new SpeciesRestrictedTalent("Caitian", "Disarming Nature", "Despite their reputation for being fierce warriors, Caitians are extremely sociable and adept at putting others at ease. Whenever you are engaged in a Social Conflict, you reduce the Difficulty of any Test to make your target relax or to trust you by 1."),
            new SpeciesRestrictedTalent("Caitian", "Prehensile Tail", "While most Caitians have some functional control over their tail, characters with this Talent have worked to increase their control over the appendage to the point of it becoming fully functional. This provides the character with the ability to hold and operate an additional piece of equipment, like an additional hand. In addition, the character gains a bonus d20 to any Fitness Test to maintain balance or to climb."),

            new SpeciesRestrictedTalent("Cardassian", "Duty and Discipline", "When the character assists a superior, the superior gains a bonus Momentum."),
            new SpeciesRestrictedTalent("Cardassian", "Suspicious by Nature", "When attempting to detect hidden enemies, traps or other forms of danger, the character may re-roll a die."),
            new SpeciesRestrictedTalent("Cardassian", "Regimented Mind", "Whenever this character spends Momentum to Obtain Information, they reduce the Difficulty of their next Task by 1 so long as that Task in some way relates to the information gained."),
            new SpeciesRestrictedTalent("Cardassian", "The Ends Justify the Means", "When the character challenges a Directive, they gain a bonus die – in addition to any other benefits."),

            new SpeciesRestrictedTalent("Edosian", "Multi-Tasking", "Edosians are capable, with extensive training and great effort, of compartmentalizing their thoughts and operating each arm completely independent of the others. Characters with this Talent may spend 3 Momentum to gain the benefit of an additional Senior Officer Role until the end of the current scene. This Talent may only be used once per episode."),
            new SpeciesRestrictedTalent("Edosian", "The Long View", "Due to their extremely long lifespans, Edosians come to understand and gain knowledge more extensively than most other individuals. When a character with this Talent uses a Milestone to exchange a Focus, they may do so twice instead of once."),
        
            new SpeciesRestrictedTalent("Ferengi", "Every Man Has His Price", "The character gains a bonus die whenever engaged in Social Conflict where the opponent can be bribed, bought, or otherwise enticed by monetary gain."),
            new SpeciesRestrictedTalent("Ferengi", "Hear All, Trust Nothing", "Increase the Difficulty of any Social Conflict to deceive the character by 1."),
            new SpeciesRestrictedTalent("Ferengi", "Knowledge Equals Profit", "When the character spends Momentum to Obtain Information, an additional Momentum is added to the group’s Momentum Pool after all other Momentum spends are resolved."),
        
            new SpeciesRestrictedTalent("Grazerite", "Communal", "Grazerites are deeply communal and work well in coordination with others. Whenever a character with this Talent is providing assistance to another, they increase the Focus range to generate 2 successes by 1."),
            new SpeciesRestrictedTalent("Grazerite", "Horn-Sense", "A small minority of Grazerites are born with a genetic variance that causes their horns to be hollow. This gives them a highly sensitive organ that can detect subtle changes in air pressure, sound, and all manner of vibrations. When a character with this Talent attempts a Task that involves the detection or analysis of sound or vibrations of any kind, they may re-roll a d20."),
        
            new SpeciesRestrictedTalent("Haliian", "Contact Empathy", "Haliians possess minor empathic abilities which, without the canar focusing crystal, is limited to touch. Once you make contact with another character, you can sense the emotions of that individual – as well as communicate telepathically with other empaths or telepaths. You cannot choose to not sense the emotions of those you make contact with. It may require effort and a Task to gain information from beings that are resistant to forms of telepathy. Such information can most often be used as an Advantage during Social Conflicts."),
            new SpeciesRestrictedTalent("Haliian", "Faceted Attention", "Characters with this Talent can suddenly divert their attention to other Tasks, leaving their current Task in whatever state it was in, and immediately begin work on the second. To many this may seem undisciplined and unfocused, but to characters with this Talent it is simply an effective way of completing several Tasks at once. Whenever this character is participating in a Challenge, they may choose to use this Talent and attempt two Tasks simultaneously. The attempt is made against the Task with the highest Difficulty, which is then attempted using the appropriate pool. Successes are then divided between the two Tasks. When attempting Tasks using this Talent – the Complication range is increased by one and any Complications rolled can be from either Task – as thematically appropriate."),
        
            new SpeciesRestrictedTalent("Ktarian", "Deep Determination", "Ktarians have a well-earned reputation for becoming deeply committed to a particular goal – a single-minded determination to achieve success. When a character with this Talent succeeds at a Task where they could have spent a point of Determination, but choose not to, they may spend 3 Momentum to gain a point of Determination. This Talent may only be used once per Episode."),
            new SpeciesRestrictedTalent("Ktarian", "Negotiate From Strength", "Ktarians are loath to enter into negotiations unless they feel they are at an advantage. When a Character with this Talent enters into a Social Conflict and attempts to use negotiation, they may gain the benefit of an Advantage twice – however, the Advantage must be used differently each time. This Talent may only be used once per scene."),

            new SpeciesRestrictedTalent("Zaranite", "Hardened Hide", "Zaranite skin is extremely tough and capable of withstanding pressures, temperatures, and acidity levels that would prove lethal to other species. Characters with this Talent gain 2 natural Resistance."),
            new SpeciesRestrictedTalent("Zaranite", "Multispectrum Vision", "Zaranites can see a broader spectrum of light than most humanoid species. Characters with this Talent gain a bonus Momentum on a Perception Task based on vision. This bonus Momentum may only be used on the Gain Information Momentum spend."),
        },
        NpcSpaceframes = new List<Spaceframe> {
            new Spaceframe {
                Name = "Hideki Class Corvette",
                Scale = 2,
                Systems = new Systems {
                    Comms = 05,
                    Engines = 05,
                    Structure = 05,
                    Computers = 05,
                    Sensors = 08,
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 01,
                    Conn = 02,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Disruptor Cannon"
                },
                StartingTalents = new List<string> {
                    "Improved Impulse Drive"
                }
            },
            new Spaceframe {
                Name = "Keldon Class Heavy Cruiser",
                Scale = 4,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 09,
                    Structure = 09,
                    Computers = 08,
                    Sensors = 07,
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 01,
                    Conn = 02,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Disruptor Banks",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Command Ship",
                    "Improved Hull Integrity"
                }
            },
            new Spaceframe {
                Name = "Acquisition Class Scout",
                Scale = 1,
                Systems = new Systems {
                    Comms = 02,
                    Engines = 03,
                    Structure = 01,
                    Computers = 02,
                    Sensors = 02,
                    Weapons = 01,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 02,
                    Science = 01,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Particle Beam",
                },
                StartingTalents = new List<string> {}
            },
            new Spaceframe {
                Name = "Ul'ess Class Mobile Cruiser",
                Scale = 7,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 08,
                    Structure = 14,
                    Computers = 10,
                    Sensors = 08,
                    Weapons = 12,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 04,
                    Science = 02,
                    Conn = 01,
                    Engineering = 04,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Electro-Magnetic Pulse",
                    "Photom Torpedoes",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {
                    "Diplomatic Suites",
                    "Secondary Reactors"
                }
            },
            new Spaceframe {
                Name = "Chel Greet",
                Scale = 4,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 10,
                    Structure = 11,
                    Computers = 09,
                    Sensors = 09,
                    Weapons = 11,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 04,
                    Science = 02,
                    Conn = 03,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Breen Torpedo",
                    "Disruptor Cannons",
                    "Tractor Beam (Strength 3)",
                    "Breen Energy Dissipation Weapon"
                },
                StartingTalents = new List<string> {
                    "Improved Power Systems",
                    "Redundant Systems"
                }
            },
            new Spaceframe {
                Name = "Bes Ghant",
                Scale = 3,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 11,
                    Structure = 07,
                    Computers = 10,
                    Sensors = 10,
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 02,
                    Science = 03,
                    Conn = 03,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Breen Torpedo",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Close to the Chest",
                    "Improved Warp Drive"
                }
            },
            new Spaceframe {
                Name = "Q'Maire",
                Scale = 4,
                Systems = new Systems {
                    Comms = 05,
                    Engines = 05,
                    Structure = 05,
                    Computers = 05,
                    Sensors = 04,
                    Weapons = 03,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 02,
                    Science = 01,
                    Conn = 02,
                    Engineering = 03,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "X-Ray Laser Cannon",
                    "Merculite Rocket",
                    "Tractor Beam (Strength 1)"
                },
                StartingTalents = new List<string> {
                    "Improved Damage Control",
                    "Rugged Design"
                }
            },
            new Spaceframe {
                Name = "Talarian Bulk Freighter",
                Scale = 2,
                Systems = new Systems {
                    Comms = 05,
                    Engines = 03,
                    Structure = 04,
                    Computers = 03,
                    Sensors = 02,
                    Weapons = 02,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 01,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Merculite Rocket",
                    "Tractor Beam (Strength 1)"
                },
                StartingTalents = new List<string> {
                    "Rugged Design"
                }
            },
            new Spaceframe {
                Name = "Tholian Spinner",
                Scale = 2,
                Systems = new Systems {
                    Comms = 05,
                    Engines = 08,
                    Structure = 05,
                    Computers = 05,
                    Sensors = 07,
                    Weapons = 05,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 01,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Disruptor Banks",
                    "Plasma Torpedo",
                    "Tractor Beam (Strength 1)"
                },
                StartingTalents = new List<string> {
                    "Web Spinner"
                }
            },
            new Spaceframe {
                Name = "Tholian Weaver",
                Scale = 5,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 06,
                    Structure = 11,
                    Computers = 08,
                    Sensors = 09,
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 02,
                    Science = 02,
                    Conn = 01,
                    Engineering = 03,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Disruptor Banks",
                    "Plasma Torpedo",
                    "Tractor Beam (Strength 1)"
                },
                StartingTalents = new List<string> {
                    "Ablative Armor",
                    "Improved Damage Control",
                    "Standing Graviton Field"
                }
            },
        },
        ShipTalents = new List<ShipTalent> {
            new ShipTalent("Web Spinner", "As long as two ships that have the Web Spinner Talent are active and at Close range, they can use this special ability. While this Talent is being used, the Tholian vessels are unable to make normal weapons attacks. An Engines + Conn Task with a Difficulty of 1 is attempted (based on the lowest stats of the ships involved); for every success the ship that is being ensnared in the web loses 1 Power. All weapons fire at targets outside of the web (including the ships making it) have their Difficulty increased by 1. No weapons fire from inside the web is possible if a ship is brought to 1 Power or less."),
            new ShipTalent("Standing Graviton Field", "This ship can produce as many Tractor Beams as it wishes, but they are each Strength 1.")
        }
    };
}

}