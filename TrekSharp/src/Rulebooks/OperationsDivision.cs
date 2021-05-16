using System;
using System.Collections.Generic;

namespace TrekSharp.Rulebooks {
    
public class OperationsDivision : BaseRulebook {
    private OperationsDivision() {}

    public static OperationsDivision Instance = new OperationsDivision() {
        Talents = new List<CharacterTalent> {
            /*
            new DisciplineLimitedTalent(
                new Discipline {

                },
                "",
                ""
            )
            */
            new DisciplineLimitedTalent(
                new Disciplines {
                    Security = 2,
                    Medicine = 2
                },
                "Combat Medic",
                "The character’s abilities in field medicine and battle triage are exceptional and their presence inspires allies to continue any fight. Whenever the character attempts the First Aid Task, they may spend one Momentum to cause the recipient to regain points of Stress equal to the number of the character's Medicine Discipline. A character may only regain Stress in this way once per scene."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Security = 3
                },
                "Criminal Minds",
                "By imagining they are a suspect, and thinking in the same way, the character gains insight into a criminal’s thought processes or actions. Whenever a character succeeds at a Task to interpret information about a suspect using Reason, a character generates 1 bonus Momentum which may only be used for the Obtain Information Momentum Spend."
            ),
            new DisciplineLimitedTalent(
                new Disciplines[]{
                    new Disciplines {
                        Security = 3
                    },
                    new Disciplines {
                        Command = 3
                    }
                },
                "Crisis Management",
                "Small squad tactics can mean the difference between life and death in a dangerous, hostile situation, and the character excels at coordinating action in battle. The character may make use of the Direct Task. If they already have access to the Direct Task, they may do so twice per scene instead of once."
            ),
            new AttributeAndDisciplineLimitedTalent(
                new Attributes {
                    Control = 10
                },
                new Disciplines {
                    Security = 3
                },
                "Deadeye Marksman",
                "The character has spent time at the target range every day, working on their aim. When the character takes the Aim Minor Action, they reduce the Difficulty of their next Attack by 1, in addition to the normal effects of the Aim Minor Action."
            ),
            new AttributeAndDisciplineLimitedTalent(
                new Attributes {
                    Daring = 9
                },
                new Disciplines {
                    Security = 2
                },
                "Fire At Will",
                "The character is capable of tracking multiple targets and making attacks against them with great effect. Whenever the character makes a ranged weapon attack, and then uses the Swift Task Momentum spend to make a second ranged attack, they ignore the normal Difficulty increase from Swift Task."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Security = 3
                },
                "Full Spread - Maximum Yield!",
                "The character is skilled in setting up torpedo attacks. In addition to the normal benefits of a Salvo, the attack also gains the benefit of the Devastating Attack Momentum Spend as though 2 Momentum had been spent. The Devastating Attack Momentum Spend may not be selected again for this attack."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Security = 2
                },
                "Hunker Down",
                "Making good use of the surroundings for protection is one of the hallmarks of a skilled soldier. Whenever the character rolls Cover Dice, they may add +1 Resistance to the total for each Effect rolled."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Security = 3,
                    Conn = 2
                },
                "Lead Investigator",
                "The character has a mind intrigued by mystery and investigation, and is often called upon to review and coordinate response to lawbreaking. The character generates two bonus Momentum after a successful Task to investigate a crime."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Security = 4,
                },
                "Martial Artist",
                "There are countless forms and styles of hand-to-hand combat, and the character has mastered several of them. The character’s Unarmed Strike attacks gain the Intense Damage Effect. If the character also has the Mean Right Hook Talent, then both Damage Effect apply when Effects are rolled."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Security = 4,
                    Conn = 3
                },
                "Precision Targeting",
                "Having extensive knowledge of ship systems and operations, the character can easily target specific systems when attacking an enemy vessel. When the character makes an attack that targets a specific System they may reroll 1d20 in their dice pool, and the attack gains the Piercing 1 damage effect."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Engineering = 4
                },
                "Experimental Device",
                "You have designed and constructed a new piece of equipment that is either a brand new invention or is heavily modified from its original to the point of being barely recognizable. In either case, the device performs a function that you determine when you select this Talent. When used appropriately, it automatically provides you an Advantage. However, its experimental nature means there are lingering design bugs that sometimes plagues its function. Increase the Complication Range of any Task by 2 when using this device. This Talent may be selected multiple times with a different device for each selection."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 3,
                    Conn = 3
                },
                "Explot Engineering Flaw",
                "Following an ally’s successful Scan for Weakness Task, you may highlight an identified engineering flaw in the opponent’s ship. In addition to the bonus granted by the Scan for Weakness Task, you may assist anyone making an Attack against the target ship, which does not count against the normal limit for providing assistance. If the Attack is successful, it generates 1 bonus Momentum. You must be able to communicate with the ally making the Attack to offer this assistance."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 3
                },
                "Mainenance Specialist",
                "You are an expert in conducting and directing normal, day- to-day, maintenance and repairs on Starfleet equipment. Whenever they are required to perform maintenance, reduce the Difficulty by 1, to a minimum of 1, and halve the time required to complete the Task."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Control = 10
                },
                new Disciplines {
                    Engineering = 3
                },
                "Meticulous",
                "You are patient, methodical, and check for errors before considering Tasks complete. Whenever they use Engineering to complete a Task, you may negate one Complication generated from the roll. However, during timed Tasks or Challenges, you take 1 more interval to complete the Task."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Daring = 10
                },
                new Disciplines {
                    Engineering = 4
                },
                "Past The Redline",
                "Engineers understand that safety tolerances and operating margins are always designed into the acceptable performance range of equipment. While not recommended the equipment is usually capable of higher performance, if the consequences are risky. This Talent provides bonus Momentum for using a ship’s System until the end of the scene. Select the System you wish to enhance, and the number of bonus Momentum to be provided. Attempt a Daring + Engineering Task with a Difficulty equal to the bonus Momentum selected. If the you succeed, subsequent Tasks using that System automatically generate that amount of bonus Momentum. However, to represent the risks involved, the Task also increases its Complication Range by the same number as the Bonus Momentum provided. If a Complication is rolled, the System no longer provides bonus Momentum and the System suffers a number of Breaches equal to half the ship's Scale."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 3,
                    Command = 2
                },
                "Repair Team Leader",
                "You are trained to direct and lead damage repair parties during emergencies, giving them guidance and expert knowledge of the ships systems. If you succeed at the Damage Control Task you may spend 3 Momentum (Repeatable) to also repair one Breach."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 3
                },
                "Right Tool For The Right Job",
                "Engineers are trained to identify and use appropriate tools whenever they are working on the delicate components that make up complex ship systems. Whenever you acquire an engineering tool with an Opportunity Cost, the tool grants an Advantage if it did not do so originally, or increases the Advantage it provides by one step."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 5
                },
                "Miracle Worker",
                "You have a reputation of doing the impossible: repairs or modifications well in advance of expectations; getting offline systems up and running when most needed and so on. Whenever you use Engineering on an Extended Task, if you achieve a Breakthrough and roll at least one Effect on a Challenge Die, you achieve a second Breakthrough."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 3,
                    Conn = 2
                },
                "Procedural Compliance",
                "You are well versed in established Starfleet engineering practices and guidelines. By spending 2 Momentum to Create an Advantage (obtaining the proper technical manuals and documentation prior to attempting a Task to work on a ship’s system), you may reroll 1d20 during the next Engineering Task."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 4,
                    Science = 2
                },
                "Rocks Into Replicators",
                "Starfleet engineers are famed for being able to build or create nearly anything needed from the most basic of available components. Once per session, you may destroy any single piece of equipment to create any other piece of equipment of an equal or lower Opportunity Cost. This new piece of equipment has a Complication range increase of 2, with the Complication being a malfunction that renders it useless. You should provide a reasonable explanation as to how a repurposed or cannibalized device could function and the Gamemaster has final say if there is any question about the “reasonableness” of the new device."
             )
        },
        Items = new List<Item> {
            new Item { Name = "Engineering Tricorder", Size = ItemSize.OneHanded },
            new Item { Name = "Micro-Optic Drill", Size = ItemSize.OneHanded  },
            new Item { Name = "Phaser Drill", Size = ItemSize.TwoHanded  },
            new Item { Name = "Field Destabilizer", Size = ItemSize.OneHanded  },
            new Item { Name = "Hyperspanner", Size = ItemSize.OneHanded  },
            new Item { Name = "Magnetic Probe", Size = ItemSize.OneHanded  },
            new Item { Name = "Sonic Driver", Size = ItemSize.OneHanded  },
            new Item { Name = "Transport Inhibitor", Size = ItemSize.OneHanded  },
        },
        NpcCharacters = new List<NpcCharacter> {
            new NpcCharacter {
                Name = "Human Intelligence Agent",
                BaseStress = 13,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "I Am the Unseen Hand of Starfleet"
                },
                Focuses = new List<string> {
                    "Undercover Operations",
                    "Espionage",
                    "Intelligence Analysis"
                },
                Attributes = new Attributes {
                    Control = 10,
                    Fitness = 09,
                    Presence = 09,
                    Daring = 10,
                    Insight = 08,
                    Reason = 08
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 04,
                    Science = 01,
                    Conn = 01, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Constantly Watching: When the agent attempts a Task to detect danger or hidden enemies, reduce the difficulty by 1.",
                    "Trained to Withstand Interrogation: Whenever the agent attempts a Task to resist being intimidated or threatened, they add one d20 to their dice pool.",
                    "Menacing"
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Informant",
                BaseStress = 10,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 07,
                    Fitness = 08,
                    Presence = 09,
                    Daring = 08,
                    Insight = 10,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 00,
                    Security = 02,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Special Focus: The informant gains one Focus, equal to their species, as chosen by the Game-Master. This Focus applies when they are trying to get information about someone of their own species."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Quartermaster",
                BaseStress = 9,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "Fail to Prepare and You Prepare to Fail"
                },
                Focuses = new List<string> {
                    "Resource Management",
                    "Repair Procedures"
                },
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 08,
                    Presence = 10,
                    Daring = 08,
                    Insight = 10,
                    Reason = 08
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 01,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 03,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Requisitions: Whenever the quartermaster asssits Main Characters in creating an Advantage by supplying equipment they may re-roll their d20.",
                    "Contacts in Fleet Ops: Whenever the quartermaster is attempting a Persuasion Task to request additional resources from Starfleet COmmand, they may add 1d20 to their dice pool."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Transporter Chief",
                BaseStress = 10,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "Are You Sure These Are the Right Coordinates"
                },
                Focuses = new List<string> {
                    "Transporters",
                    "Containment Procedures"
                },
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 08,
                    Presence = 08,
                    Daring = 08,
                    Insight = 10,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 03,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Technical Expertise: Whenever this character is assisted by the ship's Computers or Sensors, they may re-roll one d20.",
                    "Emergency Transport: Whenever the character attempts a transport using Daring instead of Control they may reduce the difficulty by 1, to a minimum of 1."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Engineering Specialist",
                BaseStress = 10,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 10,
                    Fitness = 08,
                    Presence = 07,
                    Daring = 08,
                    Insight = 09,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 02,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Field of Expertise: The specialist gains on Focus in the engineering field of their expertise and while attempting a Task in which it applies adds 1 d20 to the dice pool."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Communications Officer",
                BaseStress = 8,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "Language is the Key to Exploring New Civilizations"
                },
                Focuses = new List<string> {
                    "Alien Languages",
                    "Translation"
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
                    Command = 02,
                    Security = 01,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 03,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Cautious (Engineering): Whenever the character attempts a Task with Engineering, and buys dice with Momentum, they may re-roll one d20.",
                    "Interpretive Translation: The character may choose to Succeed at Cost when attempting to translate a language with which they are unfamiliar. The Complication limits the understanding to the most basic version of the message."
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Operations Officer",
                BaseStress = 9,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "From This Chair I Am in Control"
                },
                Focuses = new List<string> {
                    "Sensor Operations",
                    "Starfleet Reporting Procedures"
                },
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 08,
                    Presence = 08,
                    Daring = 08,
                    Insight = 10,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 02,
                    Conn = 03, 
                    Engineering = 02,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Operations Oversight: Whenever this character attempts a Task of another Station or Department, they ignore increases in difficulty.",
                },
                Equipment = new List<Item> {
                    new Item { Name = "Phaser Type 1", Size = ItemSize.OneHanded, DamageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
                    new Item { Name = "Unarmed Strike",Size = ItemSize.OneHanded, DamageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
                }
            },
            new NpcCharacter {
                Name = "Human Repair Team Leader",
                BaseStress = 11,
                Resistance = 0,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "We'll Get it Done..."
                },
                Focuses = new List<string> {
                    "Damage Control Procedures",
                    "Damage Reporting",
                    "Hazard Containment",
                },
                Attributes = new Attributes {
                    Control = 10,
                    Fitness = 10,
                    Presence = 07,
                    Daring = 10,
                    Insight = 19,
                    Reason = 08
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 02,
                    Conn = 02, 
                    Engineering = 03,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Pushing the Deadline: Whenever this character succeeds in an Engineering or Science Task as a part of a Timed Challenge or Extended Task, they may halve the number of time intervals taken by spending 1 Momentum."
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