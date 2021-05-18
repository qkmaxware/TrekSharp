using System;
using System.Collections.Generic;

namespace TrekSharp.Rulebooks {

public class QuadrantSupplementGamma : BaseRulebook {
    private QuadrantSupplementGamma () {}

    public static readonly QuadrantSupplementGamma Instance = new QuadrantSupplementGamma() {
        Species = new List<Species> {
            new Species(
                "Agrathi",
                new Attributes {
                    Fitness = 1,
                    Insight = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Changelings",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Dosi",
                new Attributes {
                    Fitness = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Drai",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Karemma",
                new Attributes {
                    Control = 1,
                    Reason = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Lerians",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Paradans",
                new Attributes {
                    Fitness = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Rakhari",
                new Attributes {
                    Daring = 1,
                    Insight = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Skreeaa",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Son`a",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Insight = 1,
                }
            ),
            new Species(
                "Tosk",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Fitness = 1,
                }
            ),
            new Species(
                "Wadi",
                new Attributes {
                    Fitness = 1,
                    Insight = 1,
                    Presence = 1,
                }
            )
        },
        Talents = new List<CharacterTalent> {
            new SpeciesRestrictedTalent("Agrathi", "Absoluet Conviction", "The Argrathi come from a culture where crime has been systematically eliminated and therefore they view themselves as the true arbiters of justice across the Gamma Quadrant. They view criminals with disdain, and they live to show others the true greatness of their beliefs. An Argrathi gains +1 to all rolls when dealing with someone they know to be a criminal or who engages in criminal behavior."),
            new SpeciesRestrictedTalent("Agrathi", "Mind Games", "The Argrathi’s memory technology is used in more ways than just their penal system. From education to entertainment, the average Argrathi is exposed to the effects of this technology at a very young age and learns how to tell when their memory has been altered or when they are under the effect of mind- altering abilities or powers. An Argrathi receives a +1 bonus to all rolls when attempting to resist these effects or uncover whether they have been affected at all."),
    
            new SpeciesRestrictedTalent("Changelings", "Morphogenic Matrix", "The character may spend 1 Momentum as a Minor Action once per Turn to assume a different form, gaining an additional Trait to reflect whatever form they have chosen, though they cannot yet mimic an individual, and they must return to a liquid state for a few hours of rest every 16 hours. While in an alternate form, it is next to impossible (Difficulty 5) to discern the Changeling’s true nature, without separating some part of the Changeling’s substance. The character also has a Resistance of 4."),
            new SpeciesRestrictedTalent("Changelings", "Morphogenic Mastery", "The Changeling may, when assuming an alternate form, assume the form of a specific individual, mimicking their appearance and personality sufficiently that even close friends may be unable to discern the truth. Further, the Changeling no longer needs to revert to a liquid state in order to rest."),

            new SpeciesRestrictedTalent("Dosi", "Strength and Cunning", "While they are a warrior culture, the Dosi do not teach their children to solve every matter with only one aspect of their being. In order to thrive in Dosi culture, they must utilize every skill and asset they possess and must combine them in ways they never thought possible. A Dosi may use their Fitness Attribute in situations where they must use Insight, and their Presence Attribute when they need to use their Reason."),
            new SpeciesRestrictedTalent("Dosi", "Glorious Notoriety", "The Dosi’s culture has adapted itself to being able to look at an individual Dosi’s skin and being able to read their accomplishments before the other Dosi has even had a chance to open their mouth. The Dosi know other races are not as civilized as theirs and therefore they know how to radiate a sense of intimidation and respect to those who are around them, whether by flexing their muscles or by adding implied threats as they attempt to negotiate their deals. The Dosi reduces the Difficulty of all checks involving negotiations or diplomacy by 1."),
        
            new SpeciesRestrictedTalent("Drai", "Genetic Mastery", "Research into the field of genetics has become the cornerstone of the Drai’s technology. Some families have begun experimenting on their own children in order to produce the most powerful heirs and offspring possible. The character must choose one attribute to be the focus of Genetic Mastery. Once an attribute is assigned to Genetic Mastery, the character reduces the Difficulty of all Tasks that involve that attribute by 1."),
            new SpeciesRestrictedTalent("Drai", "Born Stalker", "The Drai consider the Hunt to be the most important thing they will ever do in their lives, and their entire culture revolves around it. Whether it is pursuing the Tosk or other prey, the Drai have structured the very way they teach their children to view the world to be from the mind-set of a hunter stalking their prey. This helps the Drai in every walk of life as they are able to approach each task with precision and careful attention rather than blindly rushing into things. Once per scene the Drai may ignore their Complications when determining the Difficulty for a Task."),
        
            new SpeciesRestrictedTalent("Karemma", "My Honor is my Shield", "While it can be difficult to maintain a sterling reputation and in doing so lead to hardship and loss, there are times when pursuing a higher path can reap great benefits for the individual. It is the difficult road, but one that will ultimately lead towards fulfilling the needs of the many rather than the selfish desires of the one. As long as the character has behaved honourably throughout the scene, they may use their Presence Attribute for any declared Attacks. The character is also assumed to pass any challenges involving impugning their character in front of witnesses."),
            new SpeciesRestrictedTalent("Karemma", "Instant Appraisal", "A tricorder can tell someone what an object is composed of in only a few seconds but it is rumoured that the Karemma can do it in only one. Drawing upon past experience, the Karemma is able to instinctively identify the materials that make up an object that they interact with physically. In the event of dealing with unknown or exotic substances, they are able to identify familiar patterns within the material that can point the characters in the right direction while performing the Scientific Method and reduce the difficulty by 1."),

            new SpeciesRestrictedTalent("Lerians", "Into The Breach", "Life is not worth living to a Lurian if there is not some risk involved. Always willing to dare greater than others, the Lurian finds that the real thrill lurks just beyond the edge of danger and that is what they should strive for even if their comrades do not. The character gains an additional point of Momentum if they succeed at a task that requires extreme acts of bravery to overcome."),
            new SpeciesRestrictedTalent("Lerians", "Resistant Anatomy", "The Lurians are known for having one of the hardiest constitutions in the quadrant. Capable of taking a knife to one of their hearts and keep on fighting, the Lurians have evolved a musculature and cardiovascular system that rivals that of the Klingons. When mortally wounded or suffering under a Condition that affects their physiology, a Lurian can choose to ignore the effect for the remainder of the scene, after which they collapse from exhaustion and are incapacitated for a scene."),
        
            new SpeciesRestrictedTalent("Paradans", "Replicating Past Success", "When encountering scientific tasks that they have already successfully completed for this scene, the character may spend a point of Momentum to replicate the dice result from the previous challenge."),
            new SpeciesRestrictedTalent("Paradans", "Distracting Senses", "Paradans are infamous throughout the Gamma Quadrant for their pervasive odors, but some of them have been able to channel this portion of their physiology and use it as a weapon. A Paradan may spend their turn focusing on emitting obnoxious pheromones around them and increase the Difficulty towards attacking them in hand to hand combat by 1."),
        
            new SpeciesRestrictedTalent("Rakhari", "The Truth of the Matter", "The Rakhari culture is peppered with thousands of stories and legends that are shared by the Rakhari with their children as they grow up. This has led to the Rakhari being capable storytellers, and a skilled Rakhari knows how to incorporate small snippets of the truth into any web of lies he starts to weave. The Rakhari gains a free point of Momentum when they successfully convince another sentient being of a lie."),
            new SpeciesRestrictedTalent("Rakhari", "Disciplined Mind", "The brutal laws that the Rakhari government has passed over the years has kept the population under control but led to most Rakhari being too afraid to share their intimate thoughts in public. This has led to several Rakhari becoming particularly adept at not only shielding their emotions while around others but also being able to discern the true feelings of those they communicate with. The Rakhari is able to reduce any psychic damage they may suffer by 1 and they gain a free reroll on one die in their pool when attempting to determine lies."),

            new SpeciesRestrictedTalent("Skreeaa", "Agricultural Specialist", "When tasked with dealing with matters that relate to a planet’s biosphere or agriculture, a Skreeaan may always use their Insight or Control attributes, depending on which is higher."),
            new SpeciesRestrictedTalent("Skreeaa", "Strength Through Struggle", "Though some believe it is the Skreeaan’s history of being conquered that has made them expert laborers the truth is they are a tough and hardy people eager to throw off the reins of oppression. The fact that they are physically gifted when it comes to labor only means they are able to succeed easily where others struggle. When they succeed at performing a physically arduous Task they gain one bonus Momentum. This bonus Momentum cannot be saved into the group pool."),
        
            new SpeciesRestrictedTalent("Son`a", "At All Costs", "Though a small power in the Alpha Quadrant, the Son’a have not become one of the dominant powers in the Briar Patch by engaging only in half measures or pulling their punches. When a Son’a declares their attack action, they may add an additional point of Momentum as long as they are not dealing Non-lethal damage."),
            new SpeciesRestrictedTalent("Son`a", "Particle Engineering", "The Son’a are hedonists who embrace all the pleasures that life has to offer but that does not mean they are not well educated. A large portion of the Son’a’s scientific research is dedicated towards understanding the unique particles that cling to the atmosphere of their former homeworld. When dealing with subatomic particles and the effects of radiation, the Son’a may ignore the effects of any Condition for the scene and may roll an additional d20 when attempting to understand the nature of these effects."),
        
            new SpeciesRestrictedTalent("Tosk", "Survivor's Luck", "For the Drai, the greatest hunts always come when their prey manages to continually outwit them and the Tosk are cunning adversaries. Some are given extra stores of information when they are created while others are able to pick up survival techniques as they try to escape from the Hunters. The Tosk adds 1 bonus Momentum to the pool for each adversary they are trying to escape in the scene to a maximum of 3."),
            new SpeciesRestrictedTalent("Tosk", "Last Breath", "The Tosk are designed to keep running no matter what, and refuse to allow themselves to be captured because they start to feel the effects of fatigue or exhaustion. A Tosk with this talent gains a free point of Momentum to their next action when attempting to escape while they are under the effects of a Complication."),
        
            new SpeciesRestrictedTalent("Wadi", "Come With Me", "Life can be difficult if you are competitive, and sometimes people can get angry over perceived slights very quickly. By staying jovial and attempting to lighten the mood, you are better able to reduce sources of conflict and bring people over to your side. You can reroll one die when attempting to use social skills to alter someone’s feelings regarding something you have done this scene."),
            new SpeciesRestrictedTalent("Wadi", "Life Is A Game", "Life is meant to be enjoyed, and the more risk one puts into their life the sweeter the victory. A Wadi has a distinct ability to sense patterns when it comes to solving tasks, and the more involved they are with something the more competitive they get and the quicker they are at solving puzzles. When attempting to solve a task or a riddle that involves them becoming competitive they gain an additional point of Momentum."),
        },
        NpcSpaceframes = new List<Spaceframe> {
            new Spaceframe {
                Name = "Jem'Hadar Battleship",
                Scale = 6,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 07,
                    Structure = 13,
                    Computers = 08,
                    Sensors = 10,
                    Weapons = 12,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 02,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Phased Polaron Beam Cannon",
                    "Phased Polaron Beam Array",
                    "Photon Torpedo Arrays",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {
                    "Improved Power Systems",
                    "Rapid Fire Torpedo Launcher",
                }
            },
            new Spaceframe {
                Name = "Karemma Cruiser",
                Scale = 4,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 07,
                    Structure = 09,
                    Computers = 06,
                    Sensors = 08,
                    Weapons = 06,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 02,
                    Science = 02,
                    Conn = 02,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phased Polaron Beam Array",
                    "Photon Torpedo Arrays",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Improved Hull Integrity",
                }
            },
            new Spaceframe {
                Name = "Vorta Explorer",
                Scale = 3,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 07,
                    Structure = 09,
                    Computers = 08,
                    Sensors = 09,
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 01,
                    Science = 03,
                    Conn = 01,
                    Engineering = 01,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Phased Polaron Beam Array",
                    "Photon Torpedo Arrays",
                },
                StartingTalents = new List<string> {
                    "Diplomatic Suites",
                    "Redundant Systems (Propulsion)"
                }
            },
            new Spaceframe {
                Name = "Son`a Flagship",
                Scale = 4,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 09,
                    Structure = 11,
                    Computers = 08,
                    Sensors = 08,
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 02,
                    Science = 01,
                    Conn = 02,
                    Engineering = 02,
                    Medicine = 04,
                },
                Weapons = new List<string> {
                    "Phaser Array",
                    "Photon Torpedoes",
                    "Isolytic Array"
                },
                StartingTalents = new List<string> {
                    "Command Ship",
                    "Advanced Sick Bay"
                }
            },
            new Spaceframe {
                Name = "Son`a Battlecruiser",
                Scale = 6,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 08,
                    Structure = 11,
                    Computers = 08,
                    Sensors = 09,
                    Weapons = 11,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 04,
                    Science = 01,
                    Conn = 03,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Array",
                    "Photon Torpedoes",
                    "Isolytic Array"
                },
                StartingTalents = new List<string> {
                    "Improved Impulse Drive",
                    "Ablative Armor",
                    "Ramscoop Enhancement"
                }
            },
            new Spaceframe {
                Name = "Dominion Dispatch Vessel",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 09,
                    Structure = 07,
                    Computers = 07,
                    Sensors = 09,
                    Weapons = 08,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 03,
                    Science = 01,
                    Conn = 04,
                    Engineering = 03,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phased Polaron Beam Cannons",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                    "Improved Impulse Power",
                    "High Power Tractor Beam"
                }
            },
        },
        ShipTalents = new List<ShipTalent> {
            
        },
        NpcCharacters = new List<NpcCharacter> {
            
        }
    };

}

}