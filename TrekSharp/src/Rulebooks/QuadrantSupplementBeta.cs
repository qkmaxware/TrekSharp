using System;
using System.Collections.Generic;

namespace TrekSharp.Rulebooks {

public class QuadrantSupplementBeta : BaseRulebook {
    private QuadrantSupplementBeta () {}

    public static readonly QuadrantSupplementBeta Instance = new QuadrantSupplementBeta() {
        Species = new List<Species> {
            new Species(
                "Ardanan",
                new Attributes {
                    Fitness = 1,
                    Presence = 1,
                    Reason = 1,    
                }
            ),
            new Species(
                "Benzite",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Reason = 1,    
                }
            ),
            new Species(
                "Bolian",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Deltan",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Efrosian",
                new Attributes {
                    Fitness = 1,
                    Presence = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Klingon",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Rigellian Chelon",
                new Attributes{
                    Daring = 1,
                    Fitness = 1,
                    Insight = 1,
                }
            ),
            new Species(
                "Rigellian Jelna",
                new Attributes{
                    Presence = 1,
                    Fitness = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Risian",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Xindi-Arboreal",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Xindi-Primate",
                new Attributes {
                    Daring = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Xindi-Reptilian",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Xindi-Insectoid",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Zakdorn",
                new Attributes {
                    Insight = 1,
                    Presence = 1,
                    Reason = 1,
                }
            )
        },
        Talents = new List<CharacterTalent> {
            new SpeciesRestrictedTalent("Ardanan", "Above the Clouds", "While engaged in Social conflict in a lavish environment (or one of excess), you reduce the Difficulty of any Persuade Tasks by 1 to a minimum of 1."),
            new SpeciesRestrictedTalent("Ardanan", "Zeniet in the Soul", "Your ancestry is steeped in toil in the mines on Ardana’s surface and, you roll one additional d20 whenever using Engineering or Science in relation to geology, mining or mine equipment."),
        
            new SpeciesRestrictedTalent("Benzite", "Meticulous Analysis", "Your ancestry is steeped in toil in the mines on Ardana’s surface and, you roll one additional d20 whenever using Engineering or Science in relation to geology, mining or mine equipment. When you encounter unidentified phenomena through sensors, you may immediately make a Swift Task, without the need to spend Momentum or an increase in Difficulty. This Task may only be used to attempt to analyze the preliminary data you have received using Reason + Science and a relevant Focus."),
            new SpeciesRestrictedTalent("Benzite", "All Fingers and Thumbs", "When you succeed at a Task using a computer console (including a bridge station), you gain one bonus Momentum. This bonus Momentum cannot be saved into the group pool."),
        
            new SpeciesRestrictedTalent("Bolian", "Warm Welcome", "A cheerful, outgoing personality is the perfect thing to put diplomatic guests at ease. Whenever assisting another character the Bolian may use their Presence Attribute instead of their own. Further, both the Bolian and the character being assisted may ignore any increases in Complication Range for the Task."),
            new SpeciesRestrictedTalent("Bolian", "Born Near a Warp Core", "Bolian traditions say that a child born near an active Warp Core has an improved, more positive, disposition. Optimism and an upbeat attitude certainly lends credence to this tradition, allowing the Bolian to weather misfortune. When they suffer a Complication from a Task, roll 1A; if the result is an Effect, the Complication is ignored. Once a Complication has been ignored in this way, the Bolian may not ignore another Complication for the remainder of the scene."),
        
            new SpeciesRestrictedTalent("Deltan", "Deltan Pheromones", "The character excretes a natural aphrodisiac pheromone. Whenever they attempt a Task using Presence to influence an attracted creature, they gain one bonus d20. However, they also increase their Complication Range by 2, as the effect can be distracting or lead to unwanted consequences. This talent can be switched off, losing both the bonus and the drawback, by applying chemical suppressants."),
            new SpeciesRestrictedTalent("Deltan", "Empath", "The Deltan can sense the emotions of most nearby living beings, and can communicate telepathically with other empaths and telepaths, as well as those with whom they are extremely familiar. Not sensing the nearby emotions is impossible, except for those who are resistant to telepathy. It may require serious effort and a Task to pick out the emotions of a specific individual in a crowd, or to block out the emotions of those nearby. Increase the Difficulty of this Task if the situation is stressful, if there are a lot of beings present, if the target has resistance to telepathy, or if the Gamemaster decides there are other relevant factors."),

            new SpeciesRestrictedTalent("Efrosian", "Visual Spectrum", "An Efrosian can see beyond what others think of as the visual spectrum, from some infra-red to ultra-violet light. Any Tasks in which detecting those parts of the spectrum is useful reduce in Difficulty by 1. Circumstances, such as low light levels, do not affect the Difficulty of Tasks, as long as those Tasks do not relate to perceiving minutiae of a subject."),
            new SpeciesRestrictedTalent("Efrosian", "Oral Scholar", "Efrosians are taught and learn through oral practices or ‘by rote’. Any Obtain Information Momentum spends that relate to their own knowledge using Reason or Insight may ask one additional question, for free, in addition to those bought with Momentum."),

            new SpeciesRestrictedTalent("Klingon", "To Battle!", "Whenever a Klingon buys additional dice for a melee attack using Threat, for each Threat added to the pool, you gain 1 bonus Momentum that can only be spent on Bonus Damage, increasing the damage of the attack by 1 per Momentum spent."),
            new SpeciesRestrictedTalent("Klingon", "Brak'Lul", "Various physiological redundancies mean that wounds that would kill other humanoid species don’t affect Klingons as badly. The character gains +2 Resistance against all Non-lethal attacks. In addition, whenever the Klingon is target of a First Aid Task, reduce the Difficulty of that Task by 1, to a minimum of 1."),
            new SpeciesRestrictedTalent("Klingon", "R'uustai", "This Klingon has lit candles, spoken words to honor their parents, and given their house’s sash to another, joining in a fellowship with another person, and becoming members of the same house (the original house of either party). The R’uustai Talent grants a Klingon an additional Value, which must reflect their relationship with the ritual sibling. In addition, whenever the Klingon assists, or is assisted by another, the character offering assistance may re-roll their die."),
        
            new SpeciesRestrictedTalent("Rigellian Chelon", "Chelon Shell", "The hard shell extending over a Chelon’s body provides added protection from physical and radioactive threats. This natural armor gives the character a Resistance of 1. They may also ignore any Complications from radiation sources."),
            new SpeciesRestrictedTalent("Rigellian Chelon", "Toxic Claws", "In times of danger Chelons excrete a contact toxin onto their claws that can be used to debilitate foes. Their Unarmed Strike is replaced with a melee attack Claw Strike (Melee, 1 Challenge die, Piercing 1, Debilitating, Non-lethal)."),
            new SpeciesRestrictedTalent("Rigellian Jelna", "Esosex", "The character possess a Z chromosome that strengthens their physical and survival instincts and abilities. Whenever attempting a Task using Fitness or Daring, roll 1 additional d20 and gain one bonus Momentum on such Tasks."),
            new SpeciesRestrictedTalent("Rigellian Jelna", "Industrious Mind", "The Jelna are naturally enterprising and industrious, and have an affinity for technological developments and industrial engineering. When succeeding an Engineering or Science Task relating to fixing or adapting technology, and spending 2 or more Momentum, a Jelna may add an Advantage related to that technology for free."),
        
            new SpeciesRestrictedTalent("Risian", "Peaceful Existence", "Your upbringing in a peaceful society, one that promotes harmony and has an outright ban on weapons, has developed the Risian ability for peaceful resolutions. Whenever a Risian attempts a Task to dissuade another individual or group from resorting to conflict, they reduce the Difficulty of that Task by 1."),
            new SpeciesRestrictedTalent("Risian", "Open and Insightful", "Risian open, and often frank, discussion of problems and personal opinion enables conversation and understanding when working in a team. Whenever a Risian assists another character using Insight or Reason they may re-roll a single d20 in their dice pool. In addition, if the lead character succeeds in the Task using Insight or Reason, they gain 1 bonus Momentum."),
        
            new SpeciesRestrictedTalent("Xindi-Arboreal", "Calm Under Pressure", "Arboreals possess an unwaveringly calm nature, allowing them to ignore the stress of a crisis. When attempting Tasks with Control to resist stress or mental affliction they may re- roll one die in your pool."),
            new SpeciesRestrictedTalent("Xindi-Primate", "A Mind for Design", "Xindi-Primates are natural engineers and scientists, pushing at the frontiers of design and construction. When following the Scientific Method, they may suggest an additional Focus, which they do not have to possess, as ‘The Good Way’. Every Task they attempt in an Extended Task related to the Scientific Method automatically gains the Piercing 1 effect."),
            new SpeciesRestrictedTalent("Xindi-Reptilian", "Stun Resistance", "Reptillians are naturally resistant to energy weapons stun settings. They gain +1 Resistance against Non-lethal attacks from energy weapons. They may always Avoid an Injury from a Non-lethal attack with a cost of 1 Momentum (Immediate), even if they have already Avoided an Injury during the scene."),
            new SpeciesRestrictedTalent("Xindi-Insectoid", "Protective Instinct", "Insectoids have a profound instinct to defend your eggs and their off-spring, and this transfers onto teams or groups with which they develop a close bond. Whenever an Insectoid attempts a Guard Task in combat, and confers the benefits to another Main Character, ignore the increase in Difficulty when attempting the Task."),
        
            new SpeciesRestrictedTalent("Zakdorn", "Tactical Voice", "In command positions, the speed of Zakdorn tactical calculations enables them to give concise orders to their crew. During combat, a Zakdorn leader may use the Direct Task one additional time per scene (so, twice per scene overall). Further, when they use the Swift Task Momentum Spend for an extra Task, the cost is reduced to 1 Momentum, so long as the second Task is the Assist or Direct Task."),
            new SpeciesRestrictedTalent("Zakdorn", "Master Strategist", "Zakdorn strategic sense is unparalleled in contemporary military theory. Whenever a Zakdorn attempts a Task to Create an Advantage related to strategy or tactics (as opposed to spending Momentum), reduce the Difficulty by 1."),
        },
        NpcSpaceframes = new List<Spaceframe> {
            new Spaceframe {
                Name = "D5 Battle Cruiser",
                Scale = 2,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 07,
                    Structure = 07,
                    Computers = 07,
                    Sensors = 06,
                    Weapons = 08,
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
                    "Disruptor Cannons",
                    "Photon Torpedoes"
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                    "Improved Hull Integrity",
                }
            },
            new Spaceframe {
                Name = "Raptor Scout",
                Scale = 2,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 07,
                    Structure = 07,
                    Computers = 06,
                    Sensors = 07,
                    Weapons = 06,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 01,
                    Conn = 04,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Photon Torpedoes"
                },
                StartingTalents = new List<string> {
                    "Improved Reaction Control System",
                    "Ablative Armor",
                }
            },
            new Spaceframe {
                Name = "K'T'inga Battle Cruiser",
                Scale = 3,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 08,
                    Structure = 09,
                    Computers = 07,
                    Sensors = 07,
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 04,
                    Security = 03,
                    Science = 01,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Command Ship",
                    "Cloaking Devices",
                }
            },
            new Spaceframe {
                Name = "Negh'Var Warship",
                Scale = 6,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 09,
                    Structure = 10,
                    Computers = 10,
                    Sensors = 08,
                    Weapons = 12,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 04,
                    Science = 01,
                    Conn = 02,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Disruptor Array",
                    "Disruptor Cannon",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {
                    "Fast Targeting Systems",
                    "Cloaking Devices",
                    "Secondary Reactors",
                    "Extensive Shuttlebays"
                }
            },
            new Spaceframe {
                Name = "Romulan Scout Craft",
                Scale = 2,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 09,
                    Structure = 07,
                    Computers = 07,
                    Sensors = 08,
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 08,
                    Security = 01,
                    Science = 02,
                    Conn = 03,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                },
                StartingTalents = new List<string> {
                    "High Resolution Sensors",
                    "Cloaking Devices",
                }
            },
            new Spaceframe {
                Name = "Orion Scout Ship",
                Scale = 3,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 10,
                    Structure = 06,
                    Computers = 06,
                    Sensors = 07,
                    Weapons = 06,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 02,
                    Conn = 03,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Array",
                    "Photon Torpedoes"
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                }
            },
            new Spaceframe {
                Name = "Orion Interceptor",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 09,
                    Structure = 07,
                    Computers = 07,
                    Sensors = 07,
                    Weapons = 08,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 03,
                    Science = 01,
                    Conn = 04,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Particle Beam",
                },
                StartingTalents = new List<string> {
                    "Improved Reaction Control System",
                    "Improved Impulse Drive"
                }
            },
            new Spaceframe {
                Name = "Orion Cruiser",
                Scale = 4,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 07,
                    Structure = 11,
                    Computers = 09,
                    Sensors = 09,
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Disruptor Array",
                    "Disruptor Cannons",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Improved Hull Integrity",
                    "Command Ship"
                }
            },
            new Spaceframe {
                Name = "Orion Pleasure Barge",
                Scale = 5,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 06,
                    Structure = 10,
                    Computers = 08,
                    Sensors = 09,
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 01,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 04,
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {
                    "Diplomatic Suites",
                    "Improved Hull Integrity",
                    "Extensive Shuttlebays",
                    "Hidden Emplacements"
                }
            },
            new Spaceframe {
                Name = "Gorn Raider",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 08,
                    Structure = 07,
                    Computers = 07,
                    Sensors = 08,
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 01,
                    Conn = 02,
                    Engineering = 03,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Disruptor Array",
                    "Photon Torpedo",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                    "Backup EPS Conduits",
                }
            },
            new Spaceframe {
                Name = "Gorn Varanus Battleship",
                Scale = 6,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 07,
                    Structure = 12,
                    Computers = 09,
                    Sensors = 08,
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 02,
                    Conn = 02,
                    Engineering = 03,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Disruptor Array",
                    "Photon Torpedo",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {
                    "Redundant Systems",
                    "Rugged Design",
                    "Duranium Armor Plating"
                }
            },
            new Spaceframe {
                Name = "Generic Freighter",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 07,
                    Structure = 09,
                    Computers = 07,
                    Sensors = 08,
                    Weapons = 06,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 01,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                },
                StartingTalents = new List<string> {
                    "Rugged Design",
                }
            },
            new Spaceframe {
                Name = "Generic Transport",
                Scale = 2,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 06,
                    Structure = 07,
                    Computers = 06,
                    Sensors = 08,
                    Weapons = 00,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 01,
                    Conn = 02,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                }
            },
            new Spaceframe {
                Name = "Generic Survey Ship",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 07,
                    Structure = 07,
                    Computers = 10,
                    Sensors = 11,
                    Weapons = 00,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 04,
                    Conn = 01,
                    Engineering = 01,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    
                },
                StartingTalents = new List<string> {
                    "Advanced Sensor Suites",
                    "Modular Labratories"
                }
            },
            new Spaceframe {
                Name = "Colony Ship",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 08,
                    Structure = 09,
                    Computers = 07,
                    Sensors = 07,
                    Weapons = 00,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 02,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    
                },
                StartingTalents = new List<string> {
                    "Extensive Shuttlebays",
                }
            },
            new Spaceframe {
                Name = "Vulcan Science Academy Survey Vessel",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 08,
                    Structure = 07,
                    Computers = 11,
                    Sensors = 12,
                    Weapons = 00,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 04,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    
                },
                StartingTalents = new List<string> {
                    "Advanced Sensor Suites",
                    "Modular Labratories",
                    "High Resolution Sensors",
                    "No Shuttlebay",
                }
            },
        },
        ShipTalents = new List<ShipTalent> {
            new ShipTalent("Cloaking Devices", "This vessel is equipped with a cloaking device, allowing the ship to effectively ‘disappear’ from visual and sensor detection methods. To cloak, a crewmember at the tactical station is required to attempt a Control + Engineering Task with a Difficulty of 2, assisted by the ship’s Engines + Security. This Task has a Power requirement of 3. If successful, the ship gains the Cloaked Trait. While cloaked, the ship cannot be the target of any attack nor can it use any of its attacks. While cloaked the ship has Shields 0. It requires a Minor Action to decloak."),
            new ShipTalent("Hidden Emplacements", "Hull plating disguises the weapons aboard this ship. These weapons are not immediately detectable, and when hidden require an Insight + Security Task assisted by a ship’s Sensors + Security with a Difficulty of 3, to detect. Before attacking, the crew must spend a Minor Action to ready the emplacements. To hide them also requires a Minor Action."),
            new ShipTalent("Duranium Armor Plating", "The ship’s Resistance is increased by 2."),
            new ShipTalent("No Shuttlebay", "The starship cannot support any small craft."),
        }
    };

}

}