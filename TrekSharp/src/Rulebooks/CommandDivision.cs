using System;
using System.Collections.Generic;

namespace TrekSharp.Rulebooks {
    
public class CommandDivision : BaseRulebook {
    private CommandDivision() {}

    public static CommandDivision Instance = new CommandDivision() {
        Talents = new List<CharacterTalent>{
            new DisciplineLimitedTalent(
                new Disciplines {
                    Conn = 4
                },
                "Attack Run",
                "A success in the Attack Pattern Task lets a character spend two Momentum. Enemy Attacks against the character’s ship do not reduce in Difficulty due to the Attack Pattern Task."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 3
                },
                "Covering Advance",
                "A success at any Helm Task means two Momentum can be spent to block a single enemy vessel within Medium range, plus one additional enemy vessel for each additional Momentum spent beyond that (Repeatable). When a blocked vessel makes its next attack, before the beginning of the character’s next Turn, the Difficulty of any Attack that does not target your vessel has a base Difficulty equal to the character ship’s Scale, instead of normal Difficulty."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 3
                },
                "Efficient Evasion",
                "Attempting an Evasive Action Task for the second or subsequent time in a row during a scene reduces the Power Requirement for Evasive Action to 0."
            ),
            new CharacterTalent (
                "Flight Controller",
                "Whenever the character assists an NPC in a Conn Task, one d20 re-roll may be done. The second result must be used."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 4
                },
                "Glancing Impact",
                "Succeeding at the Evasive Action Task increases the Resistance of the ship being piloted by +2. This bonus lasts until the start of the character’s next Turn."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 3,
                },
                "Inertia",
                "When the character succeeds at a Maneuver Task, 1 Momentum may be spent to move one additional zone so long as the previous Turn included an Impulse or Warp Task."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 3
                },
                "Multi-Tasking",
                "Attempting the Override Task while at a bridge station including Helm and/or Navigator positions utilizes the character’s Conn Discipline instead of the Discipline normally required for the Task."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 4,
                },
                "Pathfinder",
                "When a character attempts a Task to plot a course through unknown territory, reduce the Difficulty of the Task by 1, 2, or 3, to a minimum of 1. Each point that reduces Difficulty increases the Complication Range of the Task."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 4
                },
                "Precision Manoeuvering",
                "Reduces the Difficulty of the Task by 1, to a minimum of 0, when attempting a Task that requires precise maneuvering, or where there is a collision risk."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 3
                },
                "Spacewalk",
                "Whenever the Difficulty of a Task is increased thanks to low- or zero-gravity, ignore the increase. A Task that is normally possible but isn’t because of low- or zero-gravity, may be attempted at +1 Difficulty to the Task."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Conn = 4
                },
                "Strafing Run",
                "When a character succeeds at the Attack Pattern Task and spends Momentum to keep the initiative, the cost to keep the initiative is 0."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 3
                },
                "Bargain",
                "When negotiating an offer with someone during Social Conflict, you may re-roll a d20 on your next Persuade Task to convince that person. If the Social Conflict involves an Extended Task, you gain the Progression 1 benefit when you roll your Challenge Dice."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 3,
                    Security = 3
                },
                "Call Out Targets",
                "Upon assisting a character making an attack (using either the Assist Task, the Direct Task, or some other means), the helped character generates one point of bonus Momentum if they succeed; bonus Momentum cannot be saved to the group pool."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 3
                },
                "Call To Action",
                "In a Conflict, a character may use the Prepare Minor Action to grant one ally a Minor Action of their choice (performed immediately) if they can communicate with that ally."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 4
                },
                "Cold Reading",
                "Succeeding at a Task during Social Conflict generates one bonus Momentum which must be used for the Obtain Information Momentum Spend to gain knowledge about an individual on the other side of the interaction. If the Social Conflict involves an Extended Task, the character gains the Scrutinize 1 benefit when rolling Challenge Dice."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 4
                },
                "Coordinated Efforts",
                "During an Extended Task, an assisted character may gain either the Scrutinize 2 or Progression 1 benefits when they roll their Challenge Dice."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 4
                },
                "Decisive Leadership",
                "In a Conflict, whenever the character performs the Assist Task and would then pay two Momentum to keep the initiative, the cost to keep the initiative is reduced to 0."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 4
                },
                "Fleet Commander",
                "Commanding a vessel during a fleet action reduces the Difficulty of a Task to grant a bonus to your vessel or group by 1, to a minimum of 1. Aboard a vessel during a fleet action, the character may treat the vessel as having a Command Department of 4+, regardless of the actual value."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 3
                },
                "Multi-Discipline",
                "The character may select one additional Role, but not Commanding Officer or Admiral."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 4
                },
                "Plan Of Action",
                "When an ally succeeds at a Task that was made possible or had reduced Difficulty because of an Advantage created by the character, if that Advantage represented a plan or strategy, they generate two bonus Momentum. Bonus Momentum cannot be saved into the group pool."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 4
                },
                "Time Management",
                "During any Challenge, Extended Task or other activity under time pressure, the character may attempt a Control + Command Task with a Difficulty 3. If this Task succeeds, reduce the total number of intervals the Players have taken by 1; for every 2 Momentum spent (Repeatable) reduce by a further 1. The character has managed to minimize lost time. If the Task fails, add one additional interval as the character’s efforts actually waste time."
            ),
        },
        Spaceframes = new List<Spaceframe> {
            new Spaceframe {
                Name = "Daedalus Class",
                DesignDate = new DateTime(2140, 1, 1),
                Scale = 3,
                Weapons = new List<string> {
                    "Phase Cannons",
                    "Spatial Torpedoes",
                    "Grappler Cable (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Polarized Hull Plating",
                    "Grappler Cable",
                    "Rugged Design"
                },
                Systems = new Systems {
                    Comms       = 06,
                    Engines     = 05,
                    Structure   = 08,
                    Computers   = 08,
                    Sensors     = 08,
                    Weapons     = 05,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 0,
                    Engineering = 2,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "NX Class",
                DesignDate = new DateTime(2151, 1, 1),
                Scale = 3,
                Weapons = new List<string> {
                    "Phase Cannons",
                    "Spatial Torpedoes",
                    "Grappler Cable (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Polarized Hull Plating",
                    "Grappler Cable",
                },
                Systems = new Systems {
                    Comms       = 06,
                    Engines     = 06,
                    Structure   = 07,
                    Computers   = 06,
                    Sensors     = 06,
                    Weapons     = 06,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Hermes Class",
                DesignDate = new DateTime(2242, 1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Phaser Bank",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Improved Reaction Control System",
                    "Independent Phaser Supply",
                    "Rugged Design",
                },
                Systems = new Systems {
                    Comms       = 07,
                    Engines     = 09,
                    Structure   = 08,
                    Computers   = 06,
                    Sensors     = 08,
                    Weapons     = 06,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 2,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Oberth Class",
                DesignDate = new DateTime(2269, 1, 1),
                Scale = 3,
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "High Resolution Scaners",
                    "Improved Warp Drive",
                },
                Systems = new Systems {
                    Comms       = 08,
                    Engines     = 07,
                    Structure   = 08,
                    Computers   = 09,
                    Sensors     = 09,
                    Weapons     = 07,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 2,
                    Conn        = 1,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Sydney Class",
                DesignDate = new DateTime(2279, 1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {
                    "Improved Impulse Drive",
                    "Rugged Design",
                },
                Systems = new Systems {
                    Comms       = 08,
                    Engines     = 09,
                    Structure   = 08,
                    Computers   = 08,
                    Sensors     = 09,
                    Weapons     = 07,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 0,
                    Conn        = 2,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Centaur Class",
                DesignDate = new DateTime(2285, 1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Improved Impulse Drive",
                    "Improved Warp Drive",
                },
                Systems = new Systems {
                    Comms       = 08,
                    Engines     = 09,
                    Structure   = 08,
                    Computers   = 08,
                    Sensors     = 08,
                    Weapons     = 09,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 1,
                    Science     = 0,
                    Conn        = 2,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Ambassador Class",
                DesignDate = new DateTime(2335, 1, 1),
                Scale = 5,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {
                    "High-Resolution Sensors",
                    "Improved Impulse Drive",
                    "Saucer Separation"
                },
                Systems = new Systems {
                    Comms       = 09,
                    Engines     = 09,
                    Structure   = 10,
                    Computers   = 09,
                    Sensors     = 09,
                    Weapons     = 09,       
                },
                Departments = new Disciplines {
                    Command     = 1,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Nebula Class",
                DesignDate = new DateTime(2361, 1, 1),
                Scale = 5,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {
                    "Saucer Separation",
                },
                Systems = new Systems {
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 10,
                    Computers   = 10,
                    Sensors     = 08,
                    Weapons     = 09,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 0,
                    Conn        = 0,
                    Engineering = 2,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "New Orleans Class",
                DesignDate = new DateTime(2364, 1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "High Resolution Sensors",
                    "Modular Laboratories",
                },
                Systems = new Systems {
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 08,
                    Computers   = 10,
                    Sensors     = 10,
                    Weapons     = 09,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Olympic Class",
                DesignDate = new DateTime(2368, 1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Advanced Sickbay",
                    "Modular Laboratories",
                    "Dedicated Personnel (Medicine)"
                },
                Systems = new Systems {
                    Comms       = 10,
                    Engines     = 10,
                    Structure   = 09,
                    Computers   = 10,
                    Sensors     = 09,
                    Weapons     = 07,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 0,
                    Engineering = 0,
                    Medicine    = 2,
                }
            },
            new Spaceframe {
                Name = "Steamrunner Class",
                DesignDate = new DateTime(2370, 1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Advanced Sensor Suites",
                    "Improved Warp Drive",
                },
                Systems = new Systems {
                    Comms       = 10,
                    Engines     = 11,
                    Structure   = 09,
                    Computers   = 09,
                    Sensors     = 10,
                    Weapons     = 10,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 1,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Norway Class",
                DesignDate = new DateTime(2371, 1, 1),
                Scale = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {
                    "Advanced Sickbay",
                    "Emergency Medical Hologram",
                },
                Systems = new Systems {
                    Comms       = 10,
                    Engines     = 10,
                    Structure   = 11,
                    Computers   = 19,
                    Sensors     = 10,
                    Weapons     = 09,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 0,
                    Conn        = 0,
                    Engineering = 1,
                    Medicine    = 2,
                }
            },
            new Spaceframe {
                Name = "Saber Class",
                DesignDate = new DateTime(2371, 1, 1),
                Scale = 3,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {
                    "High Power Tractor Beam",
                    "Improved Impulse Drive",
                },
                Systems = new Systems {
                    Comms       = 10,
                    Engines     = 10,
                    Structure   = 08,
                    Computers   = 09,
                    Sensors     = 10,
                    Weapons     = 09,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 1,
                    Science     = 0,
                    Conn        = 2,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Sovereign Class",
                DesignDate = new DateTime(2371, 1, 1),
                Scale = 6,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Quantum Torpedoes",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {
                    "Command Ship",
                    "Emergency Medical Hologram",
                    "Improved Warp Drive",
                    "Quantum Torpedoes",
                },
                Systems = new Systems {
                    Comms       = 09,
                    Engines     = 11,
                    Structure   = 10,
                    Computers   = 11,
                    Sensors     = 09,
                    Weapons     = 10,       
                },
                Departments = new Disciplines {
                    Command     = 1,
                    Security    = 1,
                    Science     = 1,
                    Conn        = 0,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name = "Luna Class",
                DesignDate = new DateTime(2372, 1, 1),
                Scale = 5,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {
                    "Advanced Research Facilities",
                    "Advanced Sensor Suites",
                    "Emergency Medical Hologram",
                },
                Systems = new Systems {
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 08,
                    Computers   = 10,
                    Sensors     = 10,
                    Weapons     = 09,       
                },
                Departments = new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
        },
        ShipTalents = new List<ShipTalent> {
            new ShipTalent(
                "Polarized Hull Plating",
                "The ship does not have deflector shielding, but rather is equipped with layers of hull plating that can be polarized to resist attack. This functions in the same way as Shields do, with one difference: the ship suffers a Breach if four or more damage is suffered after deductions for Resistance."
            ),
            new ShipTalent(
                "Grappler Cables",
                "This precursor to tractor beams uses sturdy cables and magnetic grapplers to grab on to objects and ships. This functions as a tractor beam, but if the target breaks free, roll 1A — on an Effect, the cables have been Damaged and cannot be used again until repaired."
            ),
            new ShipTalent(
                "Photonic Torpedoes",
                "The vessel is equipped with photonic torpedoes instead of spatial torpedoes."
            ),
            new ShipTalent(
                "Nuclear Warheads",
                "The vessel is equipped with nuclear warheads in addition to its spatial torpedoes. This Talent cannot be taken if the ship does not have spatial torpedoes."
            ),
            new ShipTalent(
                "Dedicated Personnel (Command)",
                "The ship gains two additional Crew Support, which may only be used to establish Supporting Characters who are part of the Command department."
            ),
            new ShipTalent(
                "Dedicated Personnel (Security)",
                "The ship gains two additional Crew Support, which may only be used to establish Supporting Characters who are part of the Security department."
            ),
            new ShipTalent(
                "Dedicated Personnel (Science)",
                "The ship gains two additional Crew Support, which may only be used to establish Supporting Characters who are part of the Science department."
            ),
            new ShipTalent(
                "Dedicated Personnel (Conn)",
                "The ship gains two additional Crew Support, which may only be used to establish Supporting Characters who are part of the Conn department."
            ),
            new ShipTalent(
                "Dedicated Personnel (Engineering)",
                "The ship gains two additional Crew Support, which may only be used to establish Supporting Characters who are part of the Engineering department."
            ),
            new ShipTalent(
                "Dedicated Personnel (Medicine)",
                "The ship gains two additional Crew Support, which may only be used to establish Supporting Characters who are part of the Medicine department."
            ),
            new ShipTalent(
                "High Power Tractor Beam",
                "The ship’s tractor beam systems channel far greater quantities of power and exert much more force on the target. The ship’s tractor beam has a strength two higher than normal. Further, the ship may spend Power whenever a target attempts to escape the tractor beam to increase its strength for that attempt; the strength increases by 1 for every two Power spent."
            ),
            new ShipTalent(
                "Independent Phaser Supply",
                "Common prior to the 2270s, the ship’s phasers use an independent power supply, rather than drawing directly from the ship’s other power sources. Attacking with the ship’s phasers no longer has a Power Requirement. However, the ship may not spend additional Power to boost the effectiveness of an attack with the phasers."
            )
        },
        NpcCharacters = new List<NpcCharacter> {
            new NpcCharacter {
                Name = "Human Diplomat",
                BaseStress = 8,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "Peace can be attained through effort and compromise"
                },
                Focuses = new List<string> {
                    "Diplomacy",
                    "Politics",
                    "Research"
                },
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 07,
                    Presence = 11,
                    Daring = 08,
                    Insight = 10,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 03,
                    Security = 01,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 02,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Defuse the Tension (Talent)"
                },
                Equipment = new List<Item> {
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Attache",
                BaseStress = 8,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 07,
                    Presence = 08,
                    Daring = 07,
                    Insight = 10,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 01,
                    Science = 02,
                    Conn = 00, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Specialist Subject: An Attache may be given a specialty granting them a single focus."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Negotiator",
                BaseStress = 8,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 08,
                    Fitness = 07,
                    Presence = 10,
                    Daring = 08,
                    Insight = 09,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 01,
                    Science = 02,
                    Conn = 00, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Focused Training: Negotiators have a single focus even though they are minor NPCs."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Pathfinder Specialist",
                BaseStress = 9,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "The First to See Those Stars Up Close"
                },
                Focuses = new List<string> {
                    "Astronavigation",
                    "Helm Operations"
                },
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 08,
                    Presence = 07,
                    Daring = 10,
                    Insight = 08,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 01,
                    Science = 02,
                    Conn = 03, 
                    Engineering = 01,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Find the Path: If the specialist buys additional d20 for Tasks to navigate or chart a dangerous region, they may re-roll a single d20. When performing an Extended Task the character gains scrutinize 2 when rolling Challenge Dice."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Academy Instructor",
                BaseStress = 9,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "There's Nothing as Important as Shaping the Next Generation"
                },
                Focuses = new List<string> {
                    "Teaching",
                },
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 08,
                    Presence = 10,
                    Daring = 07,
                    Insight = 10,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 03,
                    Security = 01,
                    Science = 01,
                    Conn = 01, 
                    Engineering = 01,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Collaboration (Talent)",
                    "Teacher: Choose a Discipline other than Command and increase it by 1. Then select a single Focus to represent the subject taught at the Academy."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Academy Cadet",
                BaseStress = 10,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 09,
                    Presence = 08,
                    Daring = 08,
                    Insight = 09,
                    Reason = 08
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 01,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Untapped Potential (Talent)"
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human JAG Officer",
                BaseStress = 9,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "Law is the Foundation Upon Which an Orderly Society is Built"
                },
                Focuses = new List<string> {
                    "Law",
                    "History",
                    "Rhetoric"
                },
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 07,
                    Presence = 10,
                    Daring = 08,
                    Insight = 09,
                    Reason = 11
                },
                Disciplines = new Disciplines {
                    Command = 03,
                    Security = 02,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 01,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Jurisprudence: The JAC Officer is extremely well-versed in the theory and philosophy of law, and may re-roll one d20 on a Task that uses the character's Reason and their Law Focus.",
                    "Advisor (Talent)",
                    "Threatening 3"
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
        }
    };
}

}