using System;
using System.Collections.Generic;

namespace TrekSharp.Rulebooks {

public class QuadrantSupplementDelta : BaseRulebook {
    private QuadrantSupplementDelta () {}

    public static readonly QuadrantSupplementDelta Instance = new QuadrantSupplementDelta() {
        Species = new List<Species> {
            new Species(
                "Ankari",
                new Attributes {
                    Fitness = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Jye",
                new Attributes {
                    Control = 1,
                    Reason = 1,
                    Presence = 1,
                }
            ),
            new Species (
                "Borg",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Lokirrim",
                new Attributes {
                    Daring = 1,
                    Insight = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Mari",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Monean",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Ocampa",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Pendari",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Sikarian",
                new Attributes {
                    Control = 1,
                    Reason = 1,
                    Presence = 1,
                }
            ),
            new Species(
                "Talaxian",
                new Attributes {
                    Control = 1,
                    Presence = 1,
                    Insight = 1,
                }
            ),
            new Species(
                "Turei",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Reason = 1,
                }
            ),
            new Species (
                "Zahl",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence =1,
                }
            )
        },
        Talents = new List<CharacterTalent> {
            new SpeciesRestrictedTalent("Ankari", "Favored by Fortune", "If the character is successful on a Task, the next Task performed during that scene gains one bonus Momentum if successful."),
            new SpeciesRestrictedTalent("Ankari", "Vibration Senses", "The character has learned to use their unique physiology to allow them to detect vibrations, enhancing their ability to see and hear, even in darkness. Characters with this Talent reduce the Difficulty of perception-related Tasks by 1."),

            new SpeciesRestrictedTalent("Jye", "Maximized Efficiency", "When assisting another character, the Jye may re-roll their assist die. In addition, if the assist die generated one or more successes, the lead character gains a bonus Momentum if the Task is successful."),
            new SpeciesRestrictedTalent("Jye", "Natural Coordinator", "When assisting, or being assisted, the character is always considered to have an applicable Focus for that Task. In addition, the character counts as having a Command of 4 for the purposes of learning Talents."),

            new SpeciesRestrictedTalent("Borg", "Borg Implants", "A Liberated Borg character must select this Talent during character creation. When this Talent is chosen, pick one, two, or three Borg Implants (see sidebar). The character gains the benefits of those implants, but the Difficulty of Medicine Tasks performed on them increases by the number of implants they have. The character also increases the Complication range of all social interaction Tasks by the number of implants they have. An ordinary milestone may be used to remove one implant at a time, not the whole Talent; once all implants have been removed, this Talent can be swapped for another."),
            new SpeciesRestrictedTalent("Borg", "Direct Neural Interface", "Having existed as an extension of one of the largest and most complex computer networks in the known Galaxy, Liberated Borg possess a natural affinity for computers and data processing equipment of all kinds, and are almost organic computers themselves. When the character attempts a Task that involves, or is assisted by, a computer (including the ship’s Computers system), the character gains a bonus d20 for their dice pool."),
        
            new SpeciesRestrictedTalent("Lokirrim", "Hologram Taskmaster", "In decades past, the Lokirrim designed and utilized holograms to perform countless tasks. The character’s ship’s Crew Support is increased by 1. In addition, the character’s ship gains the Photonic Crew Trait. This increase can only be applied to a ship once, regardless of the number of Main Characters who possess this Talent."),
            new SpeciesRestrictedTalent("Lokirrim", "Photonic Prosecutor", "The Lokirrim have a long history of interrogating rogue photonic individuals. When engaged in a Social Conflict with a hologram or other photonic character, this character is considered to have an Advantage."),
        
            new SpeciesRestrictedTalent("Mari", "Empath", "The character can sense the emotions of most nearby living beings, and can communicate telepathically with other empaths and telepaths, as well as those with whom they are extremely familiar. Not sensing nearby emotions is impossible, except for those who are resistant to telepathy. It may require serious effort and a Task to pick out the emotions of a specific individual in a crowd, or to block out the emotions of those nearby. Increase the Difficulty of this Task if the situation is stressful, if there are a lot of beings present, if the target has resistance to telepathy, or if the Gamemaster decides there are other relevant factors."),
            new SpeciesRestrictedTalent("Mari", "Passive Persuader", "During Social Conflict, the character reduces the Difficulty of all evidence and negotiation based Tasks but increases the Difficulty of intimidation Tasks by 1."),

            new SpeciesRestrictedTalent("Monean", "Nomadic Heritage", "Generations of traversing the stars ingrained a natural affinity for navigation and positioning. The character may reroll a d20 during any Task associated with positioning, course determination, and other forms of navigation."),
            new SpeciesRestrictedTalent("Monean", "Submariner", "Having lived underwater for centuries, the Moneans have long since developed a keen understanding of navigating underwater environments. The character reduces any Difficulty penalties to Conn Tasks while navigating or piloting underwater by 1."),

            new SpeciesRestrictedTalent("Ocampa", "Quick Learner", "Ocampa possess keen minds and enjoy near-perfect memories, and they take to new situations and new challenges quickly. When a character with this talent attempts a Task which they have seen at least one ally perform during this mission, you may add an additional d20 to that Task."),
            new SpeciesRestrictedTalent("Ocampa", "Telepath", "The character can sense the surface thoughts and emotions of most living beings nearby, and can communicate telepathically with other empaths and telepaths, as well as those with whom they are extremely familiar. Surface thoughts are whatever a creature is thinking about at that precise moment. The character cannot choose not to sense the emotions or read the surface thoughts of those nearby, except for those who are resistant to telepathy. It will require effort and a Task to pick out the emotions or thoughts of a specific individual in a crowd, to search a creature’s mind for specific thoughts or memories, or to block out the minds of those nearby. Unwilling targets may resist with an Opposed Task. While all Ocampa are telepathic, their short lifespan and rapid development means that a young Ocampa character may not fully develop their abilities until later in life, so it is possible to choose the Talent after character creation. Unlike other telepathic/empathic species, the Ocampa have demonstrated the ability to develop even greater psychic abilities, including precognition, mental projection, telekinesis, and the ability to manipulate matter at a subatomic level."),

            new SpeciesRestrictedTalent("Pendari", "Born to Fight", "The character may reroll one d20 when making an attack. In addition, if an attack is successful, the character generates one point of bonus Momentum which may only be spent to re-roll the damage roll or to increase the total damage. Bonus Momentum may not be saved."),
            new SpeciesRestrictedTalent("Pendari", "Robust Physiology", "Various physiological redundancies mean that wounds that would kill other humanoid species don’t affect Pendari as much. The character gains +2 Resistance against all non- lethal attacks. In addition, whenever the Pendari is the target of a First Aid Task, reduce the Difficulty of that Task by 1, to a minimum of 1."),
        
            new SpeciesRestrictedTalent("Sikarian", "Canonic Law", "A deep respect for and adherence to established laws provides the character with emotional assuredness. When spending Determination to bring one of their Values into play, the character may select two benefits instead of one. The circumstances of this Task and the Value being used must relate to the character’s belief and adherence to the laws of their people. This Talent may only be used once per mission, and it cannot be used when challenging the selected Value."),
            new SpeciesRestrictedTalent("Sikarian", "Riveting Storyteller", "When engaged in a Social Conflict, if the character can tell a story as part of their interaction, they may reroll a d20."),
            new SpeciesRestrictedTalent("Sikarian", "Well Regarded", "When engaged in a Social Conflict, the character increases the Difficulty of Tasks that target them by 1."),
        
            new SpeciesRestrictedTalent("Talaxian", "Being of Many Talents", "The character has developed a degree of ability across a broad range of disciplines. When attempting a Task where more than one of the character’s Focuses apply, the character may reroll a d20."),
            new SpeciesRestrictedTalent("Talaxian", "Infectious Nature", "The character comes from a race of social beings that are outgoing, good-natured, and enjoy the company of others. This exuberance has the pleasant side effect of improving the attitude and outlooks of the people around them – regardless of whether those beings like it or not. When engaged in a Social Conflict, the character may spend 2 Momentum to improve the outlook and attitude of those around them. This provides one of two effects. The character is considered to have an Advantage in subsequent social interactions with the individual affected by this Talent. In addition, the character may choose to allow the individual to recover Stress equal to the character’s Command score."),
            new SpeciesRestrictedTalent("Talaxian", "Widely Traveled", "Having traveled space for more of their adult life, the character has seen much and has picked up bits of knowledge and unusual skills along the way. Once per mission, the character may add 1 to Threat to gain an additional Focus for the remainder of that mission, representing a specific skill or field of knowledge the character possesses which is useful in the current situation."),
        
            new SpeciesRestrictedTalent("Turei", "Deep Determination", "Turei have a well-earned reputation for becoming deeply committed to a particular goal – a single- minded determination to achieve success. When a Character with this Talent succeeds at a Task where they could have spent a point of Determination, but chose not to, they may spend 3 Momentum to gain a point of Determination. This Talent may only be used once per mission."),
            new SpeciesRestrictedTalent("Turei", "Underdweller", "When attempting any Task involving navigating subspace realms, such as Underspace corridors, the character reduces the Difficulty of that Task by 1, to a minimum of 1."),
        
            new SpeciesRestrictedTalent("Zahl", "Termal Regulation", "This species is capable of regulating their body temperatures such that they can survive in hostile environments with ease. Reduce the severity of any negative Trait dealing with temperature by 1. This can eliminate any ongoing damage the character would normally be required to suffer due to these Traits."),
            new SpeciesRestrictedTalent("Zahl", "Warm Welcome", "A cheerful, outgoing personality is the perfect thing to put diplomatic guests at ease. Whenever assisting another character, the Zahl may use the active character’s Presence Attribute instead of their own. Further, both the Zahl and the character being assisted may ignore any increases in Complication Range for the Task."),
        },
        NpcSpaceframes = new List<Spaceframe> {
            new Spaceframe {
                Name = "Borg Octahedron",
                Scale = 14,
                Systems = new Systems {
                    Comms = 12,
                    Engines = 12,
                    Structure = 15,
                    Computers = 12,
                    Sensors = 12,
                    Weapons = 12,
                },
                Departments = new Disciplines {
                    Command = 05,
                    Security = 03,
                    Science = 03,
                    Conn = 03,
                    Engineering = 03,
                    Medicine = 03,
                },
                Weapons = new List<string> {
                    "Cutting Beam",
                    "Energy Draining Weapon",
                    "Quantum Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Ablative Armor",
                    "Adaptive Subspace Field",
                    "Advanced Shields",
                    "Advanced Transporters",
                    "Auto-Regeneration Units",
                    "Colossal",
                    "Quantum Torpedoes",
                    "Regenerative Systems",
                    "Threat Protocols",
                    "Transwarp Capable"
                }
            },
            new Spaceframe {
                Name = "Borg Probe",
                Scale = 4,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 12,
                    Structure = 09,
                    Computers = 12,
                    Sensors = 10,
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 03,
                    Conn = 03,
                    Engineering = 03,
                    Medicine = 03,
                },
                Weapons = new List<string> {
                    "Cutting Beam",
                    "Energy Draining Weapon",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Advanced Transporters",
                    "Improved Damage Control",
                    "Regenerative Systems",
                    "Threat Protocols",
                    "Transwarp Capable"
                }
            },
            new Spaceframe {
                Name = "Borg Tactical Cube",
                Scale = 13,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 09,
                    Structure = 18,
                    Computers = 12,
                    Sensors = 10,
                    Weapons = 15,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 03,
                    Conn = 03,
                    Engineering = 03,
                    Medicine = 03,
                },
                Weapons = new List<string> {
                    "Cutting Beam",
                    "Energy Draining Weapon",
                    "Quantum Torpedoes",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {
                    "Ablative Armor",
                    "Adaptive Subspace Field",
                    "Advanced Shields",
                    "Advanced Transporters",
                    "Auto-Regeneration Units",
                    "Colossal",
                    "Quantum Torpedoes",
                    "Regenerative Systems",
                    "Threat Protocols",
                    "Transwarp Capable"
                }
            },
            new Spaceframe {
                Name = "Borg Torus",
                Scale = 4,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 12,
                    Structure = 07,
                    Computers = 10,
                    Sensors = 12,
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 03,
                    Conn = 03,
                    Engineering = 02,
                    Medicine = 03,
                },
                Weapons = new List<string> {
                    "Cutting Beam",
                    "Energy Draining Weapon",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Advanced Transporters",
                    "Regenerative Systems",
                    "Threat Protocols",
                    "Improved Reaction Control Systems",
                    "Transwarp Capable"
                }
            },
            new Spaceframe {
                Name = "Delta Flyer",
                Scale = 2,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 09,
                    Structure = 08,
                    Computers = 08,
                    Sensors = 08,
                    Weapons = 08,
                },
                Departments = new Disciplines {
                    Command = 00,
                    Security = 02,
                    Science = 01,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 00,
                },
                Weapons = new List<string> {
                    "Phaser Array",
                    "Photonic Missiles",
                },
                StartingTalents = new List<string> {
                    "Ablative Armor",
                    "Improved Warp Drive",
                    "Hot Rod",
                }
            },
            new Spaceframe {
                Name = "Talaxian Freighter",
                Scale = 2,
                Systems = new Systems {
                    Comms = 05,
                    Engines = 06,
                    Structure = 05,
                    Computers = 07,
                    Sensors = 08,
                    Weapons = 05,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 00,
                    Science = 01,
                    Conn = 01,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Tractor Beam (Strength 1)",
                },
                StartingTalents = new List<string> {
                    "Rugged Design",
                }
            },
            new Spaceframe {
                Name = "Kazon Raider",
                Scale = 3,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 07,
                    Structure = 08,
                    Computers = 06,
                    Sensors = 06,
                    Weapons = 08,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 01,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Cannons",
                    "Photonic Charges",
                    "Grappler Cables (Strength 1)",
                },
                StartingTalents = new List<string> {
                    "Extensive Shuttlebays",
                    "Improved Damage Control"
                }
            },
            new Spaceframe {
                Name = "Kazon Predator",
                Scale = 9,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 06,
                    Structure = 12,
                    Computers = 08,
                    Sensors = 10,
                    Weapons = 14,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 01,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Cannons",
                    "Plasma Torpedoes",
                    "Grappler Cables (Strength 4)",
                },
                StartingTalents = new List<string> {
                    "Extensive Shuttlebays",
                    "Fast Targeting Systems",
                    "Independent Phaser Supply",
                    "Rugged Design"
                }
            },
            new Spaceframe {
                Name = "Hirogen Warship",
                Scale = 3,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 09,
                    Structure = 08,
                    Computers = 08,
                    Sensors = 10,
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Array",
                    "Subnucleonic Beam",
                    "Photon Torpedoes",
                },
                StartingTalents = new List<string> {
                    "Redundant Systems",
                    "Rugged Design",
                }
            },
            new Spaceframe {
                Name = "Hirogen Venatic",
                Scale = 5,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 09,
                    Structure = 10,
                    Computers = 08,
                    Sensors = 08,
                    Weapons = 11,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Array",
                    "Subnucleonic Beam",
                    "Photon Torpedoes",
                },
                StartingTalents = new List<string> {
                    "High Resolution Sensors",
                    "Improved Warp Drive",
                    "Redundant Systems",
                    "Rugged Design"
                }
            },
            new Spaceframe {
                Name = "Krenim Warship",
                Scale = 5,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 10,
                    Structure = 11,
                    Computers = 10,
                    Sensors = 12,
                    Weapons = 12,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 02,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Array",
                    "Chroniton Torpedoes",
                },
                StartingTalents = new List<string> {
                    "High Resolution Sensors",
                    "Improved Power Systems",
                    "Rapid-Fire Torpedo Launcher",
                }
            },
            new Spaceframe {
                Name = "Krenim Timeship",
                Scale = 8,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 08,
                    Structure = 06,
                    Computers = 14,
                    Sensors = 13,
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 02,
                    Science = 04,
                    Conn = 01,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Temporal Weapon",
                },
                StartingTalents = new List<string> {
                    "Advanced Research Facilities",
                    "Advanced Sensor Suites",
                }
            },
            new Spaceframe {
                Name = "Lokirrim Aria Patrol Ship",
                Scale = 3,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 09,
                    Structure = 07,
                    Computers = 09,
                    Sensors = 09,
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 03,
                    Science = 02,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photonic Disruptor Cannon",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Electronic Warfare Systems",
                    "Redundant Systems (Sensors)",
                }
            },
            new Spaceframe {
                Name = "Lokirrim Pavteal Warship",
                Scale = 5,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 09,
                    Structure = 10,
                    Computers = 09,
                    Sensors = 08,
                    Weapons = 11,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 02,
                    Engineering = 01,
                    Medicine = 01,
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photonic Disruptor Banks",
                    "Photon Torpedoes"
                },
                StartingTalents = new List<string> {
                    "Command Ship",
                    "Electronic Warfare Systems",
                    "Redundant Systems (Sensors)",
                }
            },
            new Spaceframe {
                Name = "Species 8472 Bioship",
                Scale = 3,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 13,
                    Structure = 10,
                    Computers = 10,
                    Sensors = 12,
                    Weapons = 15,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 03,
                    Science = 02,
                    Conn = 03,
                    Engineering = 02,
                    Medicine = 04,
                },
                Weapons = new List<string> {
                    "Fluidic Space Energy Weapon",
                },
                StartingTalents = new List<string> {
                    "Improved Damage Control",
                    "Regenerative Systems",
                    "Transwarp Capable",
                }
            },
            new Spaceframe {
                Name = "Vidiian Warship",
                Scale = 5,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 11,
                    Structure = 11,
                    Computers = 08,
                    Sensors = 11,
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 02,
                    Science = 03,
                    Conn = 01,
                    Engineering = 02,
                    Medicine = 03,
                },
                Weapons = new List<string> {
                    "Particle Beam Cannons",
                    "Photon Torpedoes",
                    "Grappler Cables (Strength 3)",
                },
                StartingTalents = new List<string> {
                    "Advanced Research Facilities",
                    "Advanced Sickbay",
                    "Rapid-Fire Torpedo Launcher",
                }
            },
            new Spaceframe {
                Name = "Voth Research Vessel",
                Scale = 5,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 12,
                    Structure = 08,
                    Computers = 12,
                    Sensors = 12,
                    Weapons = 08,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 02,
                    Science = 04,
                    Conn = 03,
                    Engineering = 01,
                    Medicine = 02,
                },
                Weapons = new List<string> {
                    "Antiproton Beam Arrays",
                    "Photon Torpedoes",
                    "Chroniton Torpedoes",
                },
                StartingTalents = new List<string> {
                    "Advanced Research Facilities",
                    "Transwarp Capable",
                    "High Resolution Sensors",
                    "Voth Cloaking Device"
                }
            },
            new Spaceframe {
                Name = "Voth City Ship",
                Scale = 15,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 14,
                    Structure = 18,
                    Computers = 12,
                    Sensors = 10,
                    Weapons = 12,
                },
                Departments = new Disciplines {
                    Command = 04,
                    Security = 02,
                    Science = 03,
                    Conn = 01,
                    Engineering = 03,
                    Medicine = 03,
                },
                Weapons = new List<string> {
                    "Antiproton Beam Arrays",
                    "Photon Torpedoes",
                    "Chroniton Torpedoes",
                },
                StartingTalents = new List<string> {
                    "Advanced Shields",
                    "Colossal",
                    "Rugged Design",
                    "Transwarp Capable",
                    "Voth Cloaking Device"
                }
            },
        },
        ShipTalents = new List<ShipTalent> {
            new ShipTalent("Hot Rod", "The starship’s propulsion systems are designed to operate at peak efficiency even under adverse circumstances. All increases of Complication Range to a Task involving the Engines System resulting from adverse environmental conditions (such as Stellar Phenomena, core rulebook p. 154) are reduced by 1 to a minimum of zero."),
            new ShipTalent("Grappler Cables", "This precursor to tractor beams uses sturdy cables and magnetic grapplers to grab on to objects and ships. This functions as a tractor beam, but if the target breaks free, roll 1 Challenge die – on an Effect, the cables have been Damaged and cannot be used again until repaired."),
            new ShipTalent("Independent Phaser Supply", "Some ships’ phasers, especially Alpha and Beta Quadrant ships prior to 2270s and some vessels found within the Delta Quadrant, use an independent power supply rather than drawing directly from the ship’s other power sources. Attacking with the ship’s phasers no longer has a Power Requirement. However, the ship may not spend additional Power to boost the effectiveness of an attack with the phasers."),
            new ShipTalent("Voth Cloaking Device", "The Voth Cloaking Device operates in the same manner as presented on p.259 in the core rulebook. In addition, the Voth Cloak can also phase solid matter out of spacetime in the same way as seen in the Voyager episode “Distant Origin” and The Next Generation episode “The Pegasus.” In order to use this phased cloak, the operator must succeed at the standard cloaking Task, followed by a second Control + Engineering Task with a Difficulty of 3, assisted by the ship’s Engines + Security. This allows the vessel to be rendered immune to any damage from most sources even if they are detected. At the Gamemaster’s discretion, this immunity may not extend to very high energy events such as a passing through a black hole or neutron star, or being at the core of a star experiencing a supernova. While active, the Voth vessel may also not interact with objects in regular spacetime, but they may observe them with a successful Reason + Science Task with a Difficulty of 3."),

        }
    };

}

}