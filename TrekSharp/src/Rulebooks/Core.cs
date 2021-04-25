using System.Collections.Generic;

namespace TrekSharp.Rulebooks {

public class CoreRulebook : BaseRulebook {
    private CoreRulebook(
        List<Species> species, 
        List<CharacterTalent> talents, 
        List<Environment> environments, 
        List<Upbringing> upbringing, 
        List<CareerEvent> events,
        List<Spaceframe> spaceframes,
        List<Spaceframe> npcframes,
        List<NpcCharacter> npcs,
        List<MissionProfile> profiles,
        List<ShipTalent> shipTalents,
        List<Item> items
    ) : base(
        species,
        talents,
        environments,
        upbringing,
        events,
        spaceframes,
        npcframes,
        npcs,
        profiles,
        shipTalents,
        items
    ){}

    public static readonly IRulebook Instance = new CoreRulebook(
        new List<Species> {
            new Species(
                "Andorian", 
                new Attributes {
                    Daring = 1,
                    Control = 1,
                    Presence = 1
                }
            ),
            new Species(
                "Bajoran",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Insight = 1
                }
            ),
            new Species(
                "Betazoid",
                new Attributes {
                    Insight = 1,
                    Presence = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Denobulan",
                new Attributes {
                    Fitness = 1,
                    Insight = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Human",
                null
            ),
            new Species(
                "Tellarite",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Insight = 1,
                }
            ),
            new Species(
                "Trill",
                new Attributes {
                    Control = 1,
                    Presence = 1,
                    Reason = 1,
                }
            ),
            new Species(
                "Vulkan",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Reason = 1,
                }
            )
        },
        new List<CharacterTalent> {
            // Species special talents
            new SpeciesRestrictedTalent("Andorian", "Proud and Honorable", "Your personal integrity is unimpeachable, and you will not willingly break a promise made. Whenever you attempt a Task to resist being coerced into breaking a promise, betraying your allies, or otherwise acting dishonorably, you redice the Difficulty by 1."),
            new SpeciesRestrictedTalent("Andorian", "The Ushaan", "You are experienced in the tradition of honor-dueling known as the Ushaan, having spilt much blood upon the ice. When you make a melee Attack, or are targeted by a melee Attack, and buy one or more d20s by adding to the Threat, you may re-roll the dice pool for the Task. Further, you own an Ushaan-tor mining tool traditionally used on these duels."),
            new SpeciesRestrictedTalent("Bajoran", "Orb Experience", "You have received a vision from the Bajoran Prophets, through one of the Orbs. This rare experience, though confusing at first, has shaped your life and outlook. YOu have one additional Value, reflecting the insights you received. The first time this Value is challenged, roll 1 challenge die; if an effect is rolled, then some foretold element of the Orb Experience has come to pass, and the Value is not crossed out."),
            new SpeciesRestrictedTalent("Bajoran", "String Pagh", "You believe profoundly in the Prophets, and rely heavily upon that faith to see you through hardship. Whenever you attempt a Task to resist being coerced or threatened, you reduce the Difficulty of that Task by 1."),
            new SpeciesRestrictedTalent("Betazoid", "Empath", "You can sense the emotions of most living beings nearby, and can communicate telepathically with other empaths and telepaths, as well as with whom you are extremely familiar. YOu cannot choose not to sense the emotions of those nearby except for those who are resistant to telepathy. It may require effort and a Task to pick out the emotions of a specific individual in a crowd, or to block out the emotions of those nearby. Increase the difficulty of the Task if the situation is stressful, there are lats of people present, if the target has resistance to telepathy, or other relevant factors."),
            new SpeciesRestrictedTalent("Betazoid", "Telepath", "You can sense the surface thoughts and emotions of most living beings nearby, and can communicate telepathically with other empaths and telepaths, as well as those with whom you are extremely familiar. Surface thoughts are whatever a creature is thinking about at that precise moment. The character cannot choose not to sense the emotions or read the surface thoughts of those nearby, except for those that are resistant to telepathy. If will require effort and a Task to pick out the emotions or thoughts od a specific individual in a crowd, to search a creature;s mind for specific thoughts or memories, or to block out the minds of those nearby."),
            new SpeciesRestrictedTalent("Denobulan", "Cultural Flexibility", "Your people are friendly, patient, and inquisitive, and you exemplify those traits. You are at ease when meeting new cultures, and adapt to unfamiliar social structures easily. When you attempt a Task to learn about an unfamiliar culture, or to act in the appropriate manner when interating with members of such a culture, you reduce the Difficulty by 1."),
            new SpeciesRestrictedTalent("Denobulan", "Parent Figure", "You have a large family, with many children, nieces, and nephews, and you've learned how to coordinate even the most unruly and fractious of groups. When attempting or assisting in a Task, and two or more other characters are involved in the Task, the first Complication generated on the task may be ignored."),
            new SpeciesRestrictedTalent("Human", "Resolute", "You are indomitable, and unwilling to succumb to adversity. You increase your maximum Stress by 3."){ StressModifier = 3 },
            new SpeciesRestrictedTalent("Human", "Spirit of Discovery", "You have the drive, spirit, and courage to voyage into the unknown. You may spend one Determination to add three points of Momentum to the group pool."),
            new SpeciesRestrictedTalent("Tellarite", "Incisive Scrutiny", "You have a knack for finding weak spots in arguments, theories, and machines alike to glean information from them, learning about things and how they respond to pressure against vulnerable points. When you succeed at a Task using Control or Insight, you gain one bonus Momentum which may be used for an Obtain Information Spend."),
            new SpeciesRestrictedTalent("Tellarite", "Sturdy", "YOu have a blend of physical resilience and mental fortitude such that you're difficult to subdue. You reduce the cost to resist being knocked prone by the Knockdown damage effect bty 1, to a minimum of 0, and gain +1 Resistance against all non-lethal attacks."),
            new SpeciesRestrictedTalent("Trill", "Former Initiate", "You joined the Initiate program, hoping to be chosen by the Symbiosis Commission to become joined. As there are far more initiates than there are Symbionts, you were one of the many who failed. When you attempt a task using Control or Reason, and spend Determination to buy a bonus d20 for that Task, you may re-roll your dice pool."),
            new SpeciesRestrictedTalent("Trill", "Joined", "You have a symbiont, with lifetimes of memories to draw upon, Once per mission, you may declare that a former host had expertise in a relevant skill or field of study; you gain a single Focus for the remainder of the scene as you draw upon those memories."),
            new SpeciesRestrictedTalent("Vulkan", "Mind-Meld", "You have undergone training in telepathic techniques that allow the melding of minds through physical contact. This will always require a Task with Difficulty of at least 1, which can be opposed by an unwilling participant. If successful, you link minds sharing thoughts and memories; Momentum may be spent to gain more information, or perform deeper telepathic exchanges."),
            new SpeciesRestrictedTalent("Vulkan", "Nerve Pinch", "You have learned numerous techniques for the stimulation and control of nerve impulses. Some applications of this cna be used to swiftly and non-lethally incapacitate assailants. The nerve-pinch counts as a melee weapon with 1 challenge die, Size 1H, and the Intense and Non-lethal qualities. You may use Science or Medicine instead of Security when attempting to perform a nerve-pinch."),

            // General talents
            new CharacterTalent("Bold (Command)", "When you attempt a task with the Command discipline and you buy one or more d20s by adding to the threat pool, you may re-roll a single d20."),
            new CharacterTalent("Bold (Security)", "When you attempt a task with the Security discipline and you buy one or more d20s by adding to the threat pool, you may re-roll a single d20."),
            new CharacterTalent("Bold (Science)", "When you attempt a task with the Science discipline and you buy one or more d20s by adding to the threat pool, you may re-roll a single d20."),
            new CharacterTalent("Bold (Conn)", "When you attempt a task with the Conn discipline and you buy one or more d20s by adding to the threat pool, you may re-roll a single d20."),
            new CharacterTalent("Bold (Engineering)", "When you attempt a task with the Engineering discipline and you buy one or more d20s by adding to the threat pool, you may re-roll a single d20."),
            new CharacterTalent("Bold (Medicine)", "When you attempt a task with the Medicine discipline and you buy one or more d20s by adding to the threat pool, you may re-roll a single d20."),
        
            new CharacterTalent("Cautious (Command)", "When you attempt a task with the Command discipline and you buy one or more d20s by spending Momentum, you may re-roll a single d20."),
            new CharacterTalent("Cautious (Security)", "When you attempt a task with the Security discipline and you buy one or more d20s by spending Momentum, you may re-roll a single d20."),
            new CharacterTalent("Cautious (Science)", "When you attempt a task with the Science discipline and you buy one or more d20s by spending Momentum, you may re-roll a single d20."),
            new CharacterTalent("Cautious (Conn)", "When you attempt a task with the Conn discipline and you buy one or more d20s by spending Momentum, you may re-roll a single d20."),
            new CharacterTalent("Cautious (Engineering)", "When you attempt a task with the Engineering discipline and you buy one or more d20s by spending Momentum, you may re-roll a single d20."),
            new CharacterTalent("Cautious (Medicine)", "When you attempt a task with the Medicine discipline and you buy one or more d20s by spending Momentum, you may re-roll a single d20."),

            new CharacterTalent("Collaboration (Command)", "Whenever an ally attempts a task with the Command discipline, you may spend one Momentum to allow them to use your discipline score instead as well as one of your focuses."),
            new CharacterTalent("Collaboration (Security)", "Whenever an ally attempts a task with the Security discipline, you may spend one Momentum to allow them to use your discipline score instead as well as one of your focuses."),
            new CharacterTalent("Collaboration (Science)", "Whenever an ally attempts a task with the Science discipline, you may spend one Momentum to allow them to use your discipline score instead as well as one of your focuses."),
            new CharacterTalent("Collaboration (Conn)", "Whenever an ally attempts a task with the Conn discipline, you may spend one Momentum to allow them to use your discipline score instead as well as one of your focuses."),
            new CharacterTalent("Collaboration (Engineering)", "Whenever an ally attempts a task with the Engineering discipline, you may spend one Momentum to allow them to use your discipline score instead as well as one of your focuses."),
            new CharacterTalent("Collaboration (Medicine)", "Whenever an ally attempts a task with the Medicine discipline, you may spend one Momentum to allow them to use your discipline score instead as well as one of your focuses."),

            new CharacterTalent("Constantly Watching", "When you attempt a task to detect danger or hidden enemies, reduce the Difficulty by 1."),
            new CharacterTalent("Dauntless", "Whenever you attempt a task to resist being intimidated or threatened, you may add a bonus d20 to your dice pool."),
            new CharacterTalent("Personal Effects", "The character possesses some significant and uncommon item or device that is not Starfleet standard issue. The character may select one item with an Opportunity Cost of 2 or two items with an Opportunity Cost of 1 for each item. Neither item may have an Escalation Cost greater than 1."),
            new CharacterTalent("Studious", "Whenever you spend one or more Momentum to Obtain Information, you may ask one additional question."),
            new CharacterTalent("Technical Expertise", "Whenever you attempt a Task assisted by the ship's Computers or Sensors, you may re-roll one d20."),
            new CharacterTalent("Tough", "Whenever you Avoid an Injury, the cost is reduced by 1 to a minimum of 1."),

            // Command talents
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 2
                },
                "Advisor",
                "Whenever you assist another character using your Command Discipline, the character being assisted may re-roll one d20."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Command = 3
                },
                "Defuse The Tension",
                "Whenever you attempt a Task to persuade someone not to resort to violence, you may add a bonus d20 to your dice pool."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Command = 3
                },
                "Follow My Lead",
                "Once per scene, when you succeed at a Task during combat or another perilous situation, you may spend one Determination. If you do, choose a single ally. The next Task that ally performs counts as having assistance from you using your Presence + Command."
            ),
            new CharacterTalent(
                "Supervisor",
                "The ship's Crew Support increases by one."
            ),

            // Conn Talents
            new DisciplineLimitedTalent (
                new Disciplines {
                    Conn = 2
                },
                "Fly-By",
                "Whenever you use the Swift Task Momentum spend, you do not increase the Difficulty of the second task if one of the Tasks you attempt is to pilot a vessel of vehicle."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Conn = 4
                },
                "Precise Evasion",
                "Whenever you succeed at the Evasive Action Task, you may spend two Momentum. If you do, the ship does not suffer the increased Difficulty for attacks normally caused by Evasive Action."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Conn = 4
                },
                "Push The Limits",
                "When you attempt a Conn Task that has increased in difficulty due to environmental conditions or damage to the engines, reduce the Difficulty by 1, to a minimum of 1."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Conn = 3
                },
                "Starship Expert",
                "Whenever you succeed at a Conn Task to identify a type of starship, you obtain bonus Momentum, which may only be used on the Obtain Information Spend or to pay part of the cost of the Create Advantage Spend."
            ),

            // Security Talents
            new DisciplineLimitedTalent (
                new Disciplines{
                    Security = 4
                },
                "Close Protection",
                "When you make a successful Attack, you may spend one Momentum to protect a single ally within Close range. The next Attack against that ally before the start of your next turn increases in difficulty by 1."
            ),
            new DisciplineLimitedTalent (
                new Disciplines{
                    Security = 3
                },
                "Interrogation",
                "When you succeed at a Task to coerce someone to reveal information in a social conflict, you will gain one bonus Momentum which may only be spent on the Obtain Information Spend."
            ),
            new CharacterTalent(
                "Mean Right Hook",
                "Your Unarmed Strike Attack has the Vicious 1 Damage Effect"
            ),
            new CharacterTalent(
                "Pack Tactics",
                "Whenever you assist another character during combat, the character you assisted gains one bonus Momentum if they Succeed."
            ),
            new DisciplineLimitedTalent (
                new Disciplines{
                    Security = 3
                },
                "Quick To Action",
                "During the first round of any combat, you and your allies may ignore the normal cost to Retain the Initiative."
            ),

            // Engineering Talents
            new DisciplineLimitedTalent(
                new Disciplines {
                    Engineering = 3
                },
                "A Little More Power",
                "Whenever you succeed at an Engineering Task aboard your own ship, you may spend on Momentum to regain one spent Power"
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Engineering = 4
                },
                "I Know My Ship",
                "Whenever you attempt a Task to determine the source of a technical problem with your ship, add one bonus d20."
            ),
            new DisciplineLimitedTalent(
                new Disciplines[]{
                    new Disciplines{
                        Engineering = 3
                    },
                    new Disciplines {
                        Science = 3
                    }
                },
                "In The Nick Of Time",
                "Whenever you succeed at an Engineering or Science Task as part of an Extended Task, you score an additional 1 Work for every Effect rolled."
            ),
            new DisciplineLimitedTalent(
                new Disciplines[]{
                    new Disciplines{
                        Engineering = 3
                    },
                    new Disciplines {
                        Science = 3
                    }
                },
                "Intense Scrutiny",
                "Whenever you succeed at a Task using Reason or Control as part of an Extended Task, you may ignore up to two Resistance for every Effect rolled."
            ),
            new DisciplineLimitedTalent(
                new Disciplines {
                    Engineering = 4
                },
                "Jury-Rig",
                "Whenever you attempt an Engineering Task to perform repairs, you may reduce the Difficulty by two, to a minimum of 0. If you do this, however, then the repairs are only temporary and will only last a single scene, plus one additional scene per Momentum spend before they fail again. Jury-rigged repairs can only be applied once and the Difficulty to repair a device that has be Jury-rigged increases by 1."
            ),

            // Science Talents
            new DisciplineLimitedTalent(
                new Disciplines{
                    Science = 2
                },
                "Computer Expertise",
                "Whenever you attempt a Task that involves the programming or study of a compuder system, you may add a bonus d20 to your pool."
            ),
            new DisciplineLimitedTalent(
                new Disciplines[]{
                    new Disciplines{
                        Engineering = 2
                    },
                    new Disciplines {
                        Science = 2
                    }
                },
                "Testing A Theory",
                "When you attempt a Task using Engineering ot Science, you may roll one additional d20, so long as you succeed at a previous Task covering the same scientific or technological field from earlier in the same adventure."
            ),

            // Medical Talents
            new DisciplineLimitedTalent(
                new Disciplines {
                    Medicine = 4
                },
                "Doctor's Orders",
                "When you attempt a Task to coodinate others, or to coerce someone into taking or refraining from a specific course of action, you may use your Medicine Discipline instead of Command."
            ),
            new CharacterTalent(
                "Field Medicine",
                "When attempting a Medicine Task, you may ignore any increase in Difficulty from working without the proper tools or equipment."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Medicine = 3
                },
                "First Response",
                "Whenever you attempt the First Aid Task during combat, you gain a bonus d20. Further, you may always succeed at a cost, with each Complication you suffer adding +1 to the Difficulty of healing the patient's injury subsequently."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Medicine = 3
                },
                "Quick Study",
                "When attempting a Task that will involve an unfamiliar medial procedure, or which is to treat an unfamiliar species, ignore any Difficulty increase stemming from your unfamiliarity."
            ),
            new DisciplineLimitedTalent(
                new Disciplines{
                    Medicine = 3
                },
                "Triage",
                "When you attempt a Task to identify a specific injury or illness, or to determine the severity of a patient's condition, you may spend on Momentum to diagnose one additional patient."
            ),
            new HiddenTalent("Untapped Potential", "The character’s is inexperienced, but talented and with a bright future in Starfleet. The character may not have or increase any Attribute above 11, or any Discipline above 4 while they have this Talent (and may have to adjust Attributes and Disciplines accordingly at the end of character creation). Whenever the character succeeds at a Task for which they bought one or more additional dice with either Momentum or Threat, they may roll 1 challenge die. The character receives bonus Momentum equal to the roll of the challenge die, and adds one point to Threat if an Effect is rolled. The character cannot gain any higher rank than lieutenant (junior grade) while they possess this Talent."),
            new HiddenTalent("Veteran", "The character’s is inexperienced, but talented and with a bright measured and considered way. Whenever the character spends a point of Determination, roll 1 challenge die. If an Effect is rolled, immediately regain that spent point of Determination. The character has a rank of at least lieutenant commander."),
        },
        new List<Environment> {
            new Environment(
                "Homeworld", 
                "The character comes from the world that birthed their civilization, and has been surrounded by cultural and spiritual legacies their entire life. Species homeworlds are often utopian and idyllic, serving as the platonic ideal of the species' culture. They also exemplify aspects of a culture's most revered traditions, adn serve as the heart of that civilization's legal and political landscape.",
                null,
                new Disciplines {
                    Command = 1,
                    Security = 1,
                    Science = 1,
                }
            ),
            new Environment(
                "Busy Colony",
                "The character comes from one of their culture's oldest or most prosperous colonies, which may be another world within their home system, or one of the first worlds colonized after the species achieved interstellar flight. These coloniesdevelop a fiercely independent outlook, often having developed with little direct aid from their homeworld, and a sense of pride that accompanies being amongst the first of their kind to tame another world.", 
                new Attributes {
                    Daring = 1,
                    Presence = 1,
                },
                new Disciplines {
                    Command = 1,
                    Security = 1,
                    Science = 1,
                }
            ),
            new Environment(
                "Isolated Colony",
                "The character comes from a colony that is isolated from broader galactic society. Worlds like the Vulkan monastery of P'Jem use the vast distances between star systems as an opportunity for contemplative isolation, while others are settled because they present unique research opportunities. The cultures of these colonies tend to focus on learning and introspection.", 
                new Attributes {
                    Reason = 1,
                    Insight = 1,
                },
                new Disciplines {
                    Command = 1,
                    Security = 1,
                    Science = 1,
                }
            ),
            new Environment(
                "Frontier Colony", 
                "The character comes from a colony located on the fringes of known space, either on the edge of uncharted space or on the border with another civilization. Frontier colonists tend to be handy and determined, even stubborn, and well-prepared for the dangers that their home may pose.",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                },
                new Disciplines {
                    Conn = 1,
                    Security = 1,
                    Medicine = 1,
                }
            ),
            new Environment(
                "Starship or Starbase", 
                "The character grew up in space, travelling aboard a starship or living aboard a space station or starbase. While they're unlikely to have lived onboard a Starfleet vessel, many freighters, transports, and other civilian vessels have a tradition of family or generational crews. Many officers with families take postings aboard starbases rather than ships. Those raised in space learn the ins-and-outs of starship life as children, and many are groomed for leadership, or learn to fly a shuttle in their formative years.",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                },
                new Disciplines {
                    Command = 1,
                    Conn = 1,
                    Engineering = 1,
                }
            ),
        },
        new List<Upbringing> {
            new Upbringing(
                "Starfleet",
                "The character's family may have a strong tradition of Starfleet service, with at least one member of the family in every generation serving the Federation this way. Perhaps both the chracters parents were Starfleet officers who met in service. Either way, the character's formative years were influenced by Starfleet.",
                new Attributes {
                    Control = 2,
                    Fitness = 1,
                },
                new Attributes {
                    Daring = 2,
                    Insight = 1,
                },
                new Disciplines {
                    Command     = 1,
                    Security    = 1,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 1,
                }
            ),
            new Upbringing(
                "Business or Trade",
                "The character's family may have connections on countless worlds, overseeing and directing some grand business endeavour. They might have been traders, or involved in interplanetary freight. Either way, the character has grown up encountering people from all walks of life, including those from outside the Federation, and their outlook on life has been shaped accordingly.",
                new Attributes {
                    Daring = 2,
                    Presence = 1,
                },
                new Attributes {
                    Insight = 2,
                    Reason = 1,
                },
                new Disciplines {
                    Command     = 1,
                    Science     = 1,
                    Engineering = 1,
                }
            ),
            new Upbringing(
                "Agriculture or Rural",
                "The character grew up surrounded more by nature than by people, in rural communities, or on the frontier, or somewhere else distanced from the bustle of cities. They might be heavily involved in agriculture, growing real food to supplement synthesized or replicated meals.",
                new Attributes {
                    Fitness = 2,
                    Control = 1,
                },
                new Attributes {
                    Reason = 2,
                    Presence = 1,
                },
                new Disciplines {
                    Conn     = 1,
                    Security     = 1,
                    Medicine = 1,
                }
            ),
            new Upbringing(
                "Science and Technology",
                "The character's home was one filled with the potential of science, and cutting edge developments were familiar ground. Perhaps the character was raised by scientists or engineers, or had mentors and teachers that encouraged a talent for the technical.",
                new Attributes {
                    Control = 2,
                    Reason = 1,
                },
                new Attributes {
                    Insight = 2,
                    Daring = 1,
                },
                new Disciplines {
                    Conn     = 1,
                    Engineering     = 1,
                    Science = 1,
                    Medicine = 1,
                }
            ),
            new Upbringing(
                "Artistic and Creative",
                "The character's life was filled with arts and creativity of all kinds, and no matter what persuits the character favours, they are exposed to the great works of many cultures, and given every opportunity to express themselves.",
                new Attributes {
                    Presence = 2,
                    Insight = 1,
                },
                new Attributes {
                    Fitness = 2,
                    Daring = 1,
                },
                new Disciplines {
                    Command     = 1,
                    Engineering     = 1,
                    Science = 1,
                }
            ),
            new Upbringing(
                "Diplomacy and Politics",
                "The character has been exposed to the complexities of political thought and the nuances of diplomacy since they were young, perhaps because a family member was involved in those fields.",
                new Attributes {
                    Presence = 2,
                    Control = 1,
                },
                new Attributes {
                    Reason = 2,
                    Fitness = 1,
                },
                new Disciplines {
                    Command     = 1,
                    Conn     = 1,
                    Security = 1,
                }
            ),
        },
        new List<CareerEvent> {
            new CareerEvent(
                "Ship Destroyed",
                new Attributes {
                    Daring = 1,
                },
                new Disciplines {
                    Security = 1
                }
            ),
            new CareerEvent(
                "Death of a Friend",
                new Attributes {
                    Insight = 1,
                },
                new Disciplines {
                    Medicine = 1
                }
            ),
            new CareerEvent(
                "Negotiate a Treaty",
                new Attributes {
                    Control = 1,
                },
                new Disciplines {
                    Command = 1
                }
            ),
            new CareerEvent(
                "Required to Take Command",
                new Attributes {
                    Daring = 1,
                },
                new Disciplines {
                    Command = 1
                }
            ),
            new CareerEvent(
                "Encounter with a Truly Alien Being",
                new Attributes {
                    Reason = 1,
                },
                new Disciplines {
                    Science = 1
                }
            ),
            new CareerEvent(
                "Serious Injury",
                new Attributes {
                    Fitness = 1,
                },
                new Disciplines {
                    Medicine = 1
                }
            ),
            new CareerEvent(
                "Conflict with a Hostile Culture",
                new Attributes {
                    Fitness = 1,
                },
                new Disciplines {
                    Security = 1
                }
            ),
            new CareerEvent(
                "Mentored",
                new Attributes {
                    Control     = 1,
                    Fitness     = 1,
                    Presence    = 1,
                    Daring      = 1,
                    Insight     = 1,
                    Reason      = 1, 
                },
                new Disciplines {
                    Conn = 1
                }
            ),
            new CareerEvent(
                "Dealing with a Plague",
                new Attributes {
                    Insight = 1,
                },
                new Disciplines {
                    Medicine = 1
                }
            ),
            new CareerEvent(
                "Betrayed Ideals for a Superior",
                new Attributes {
                    Presence = 1,
                },
                new Disciplines {
                    Command = 1
                }
            ),
            new CareerEvent(
                "Called out by a Superior",
                new Attributes {
                    Reason = 1,
                },
                new Disciplines {
                    Conn = 1
                }
            ),
            new CareerEvent(
                "New Battle Strategy",
                new Attributes {
                    Daring = 1,
                },
                new Disciplines {
                    Security = 1
                }
            ),
            new CareerEvent(
                "Learns Unique Language",
                new Attributes {
                    Insight = 1,
                },
                new Disciplines {
                    Science = 1
                }
            ),
            new CareerEvent(
                "Discovers an Artifact",
                new Attributes {
                    Reason = 1,
                },
                new Disciplines {
                    Engineering = 1
                }
            ),
            new CareerEvent(
                "Special Commendation",
                new Attributes {
                    Fitness = 1,
                },
                new Disciplines {
                    Command     = 1,
                    Security    = 1,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 1,
                }
            ),
            new CareerEvent(
                "Solved an Engineering Crisis",
                new Attributes {
                    Control = 1,
                },
                new Disciplines {
                    Engineering = 1
                }
            ),
            new CareerEvent(
                "Breakthrough or Invention",
                new Attributes {
                    Control     = 1,
                    Fitness     = 1,
                    Presence    = 1,
                    Daring      = 1,
                    Insight     = 1,
                    Reason      = 1, 
                },
                new Disciplines {
                    Engineering = 1
                }
            ),
            new CareerEvent(
                "First Contact",
                new Attributes {
                    Presence    = 1,
                },
                new Disciplines {
                    Command     = 1,
                    Security    = 1,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 1,
                }
            ),
        },
        new List<Spaceframe> {
            new Spaceframe {
                Name    = "Akira Class",
                DesignDate = new System.DateTime(2366, 1, 1),
                Scale   = 5,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)", 
                },
                StartingTalents = new List<string> {
                    "Ablative Armor",
                    "Extensive Shuttlebays",
                    "Rapid-Fire Torpedo Launcher"
                },
                Systems = new Systems{
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 11,
                    Computers   = 09,
                    Sensors     = 09,
                    Weapons     = 11,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 2,
                    Science     = 0,
                    Conn        = 0,
                    Engineering = 0,
                    Medicine    = 1,
                }
            },
            new Spaceframe {
                Name    = "Constellation Class",
                DesignDate = new System.DateTime(2285, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)", 
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                    "Extensive Shuttlebays",
                },
                Systems = new Systems{
                    Comms       = 08,
                    Engines     = 09,
                    Structure   = 08,
                    Computers   = 07,
                    Sensors     = 09,
                    Weapons     = 09,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 1,
                    Science     = 0,
                    Conn        = 1,
                    Engineering = 1,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Constitution Class",
                DesignDate = new System.DateTime(2243, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)", 
                },
                StartingTalents = new List<string> {
                    "Rugged Design",
                    "Modular Laboratories",
                },
                Systems = new Systems{
                    Comms       = 07,
                    Engines     = 08,
                    Structure   = 08,
                    Computers   = 07,
                    Sensors     = 08,
                    Weapons     = 08,
                },
                Departments= new Disciplines {
                    Command     = 1,
                    Security    = 1,
                    Science     = 1,
                    Conn        = 0,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Defiant Class",
                DesignDate = new System.DateTime(2371, 1, 1),
                Scale   = 3,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Phaser Cannons",
                    "Photon Torpedoes",
                    "Quantum Torpedoes",
                    "Tractor Beam (Strength 2)", 
                },
                StartingTalents = new List<string> {
                    "Ablative Armor",
                    "Quantum Torpedoes",
                },
                Systems = new Systems{
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 08,
                    Computers   = 09,
                    Sensors     = 09,
                    Weapons     = 13,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 2,
                    Science     = 0,
                    Conn        = 1,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Excelsior Class",
                DesignDate = new System.DateTime(2285, 1, 1),
                Scale   = 5,
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)", 
                },
                StartingTalents = new List<string> {
                    "Improved Impulse Drive",
                    "Secondary Reactors",
                },
                Systems = new Systems{
                    Comms       = 08,
                    Engines     = 09,
                    Structure   = 09,
                    Computers   = 08,
                    Sensors     = 08,
                    Weapons     = 09,
                },
                Departments= new Disciplines {
                    Command     = 1,
                    Security    = 0,
                    Science     = 0,
                    Conn        = 0,
                    Engineering = 2,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Galaxy Class",
                DesignDate = new System.DateTime(2359, 1, 1),
                Scale   = 6,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 5)", 
                },
                StartingTalents = new List<string> {
                    "Saucer Separation",
                    "Modular Laboratories",
                    "Redundant Systems"
                },
                Systems = new Systems{
                    Comms       = 09,
                    Engines     = 10,
                    Structure   = 10,
                    Computers   = 10,
                    Sensors     = 09,
                    Weapons     = 10,
                },
                Departments= new Disciplines {
                    Command     = 1,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 0,
                    Engineering = 0,
                    Medicine    = 1,
                }
            },
            new Spaceframe {
                Name    = "Intrepid Class",
                DesignDate = new System.DateTime(2371, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)", 
                },
                StartingTalents = new List<string> {
                    "Improved Warp Drive",
                    "Advanced Sensor Suites",
                    "Emergency Medical Hologram"
                },
                Systems = new Systems{
                    Comms       = 10,
                    Engines     = 11,
                    Structure   = 08,
                    Computers   = 11,
                    Sensors     = 10,
                    Weapons     = 09,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 2,
                    Conn        = 1,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Miranda Class",
                DesignDate = new System.DateTime(2274, 1, 1),
                Scale   = 4,
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)", 
                },
                StartingTalents = new List<string> {
                    "Extensive Shuttlebays",
                },
                Systems = new Systems{
                    Comms       = 08,
                    Engines     = 08,
                    Structure   = 08,
                    Computers   = 08,
                    Sensors     = 09,
                    Weapons     = 08,
                },
                Departments= new Disciplines {
                    Command     = 1,
                    Security    = 0,
                    Science     = 1,
                    Conn        = 1,
                    Engineering = 0,
                    Medicine    = 0,
                }
            },
            new Spaceframe {
                Name    = "Nova Class",
                DesignDate = new System.DateTime(2368, 1, 1),
                Scale   = 3,
                Weapons = new List<string> {
                    "Phaser Arrays",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 2)", 
                },
                StartingTalents = new List<string> {
                    "Advanced Sensors",
                },
                Systems = new Systems{
                    Comms       = 10,
                    Engines     = 09,
                    Structure   = 08,
                    Computers   = 10,
                    Sensors     = 10,
                    Weapons     = 08,
                },
                Departments= new Disciplines {
                    Command     = 0,
                    Security    = 0,
                    Science     = 2,
                    Conn        = 0,
                    Engineering = 1,
                    Medicine    = 0,
                }
            }
        },
        new List<Spaceframe> {
            new Spaceframe {
                Name = "D7 Battle Cruiser",
                Scale = 4,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 08,
                    Structure = 07,
                    Computers = 07,
                    Sensors = 07, 
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 03, 
                    Engineering = 02,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Phaser Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "K'Vort Class Bird-of-Prey",
                Scale = 5,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 09,
                    Structure = 08,
                    Computers = 08,
                    Sensors = 08, 
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 04,
                    Science = 01,
                    Conn = 03, 
                    Engineering = 02,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "B'Rel Class Bird-of-Prey",
                Scale = 4,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 07,
                    Structure = 07,
                    Computers = 08,
                    Sensors = 09, 
                    Weapons = 08,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 02,
                    Conn = 04, 
                    Engineering = 02,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Vor'Cha Class Attack Cruiser",
                Scale = 5,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 10,
                    Structure = 10,
                    Computers = 09,
                    Sensors = 09, 
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 04,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 02,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Disruptor Cannons",
                    "Disruptor Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Romulan Bird-of-Prey",
                Scale = 4,
                Systems = new Systems {
                    Comms = 06,
                    Engines = 07,
                    Structure = 07,
                    Computers = 08,
                    Sensors = 09, 
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 02,
                    Conn = 02, 
                    Engineering = 03,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Disruptor Banks",
                    "Plasma Torpedoes",
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "D'Deridex Warbird",
                Scale = 6,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 10,
                    Structure = 11,
                    Computers = 10,
                    Sensors = 10, 
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 02,
                    Conn = 02, 
                    Engineering = 03,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Disruptor Banks",
                    "Plasma Torpedoes",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Galor Class Cruiser",
                Scale = 4,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 09,
                    Structure = 08,
                    Computers = 08,
                    Sensors = 07, 
                    Weapons = 09,
                },
                Departments = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 02,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Disruptor Banks",
                    "Phaser Arrays",
                    "Tractor Beam (Strength 3)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Jem'Hadar Attack Ship",
                Scale = 3,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 07,
                    Structure = 07,
                    Computers = 07,
                    Sensors = 09, 
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 04,
                    Science = 01,
                    Conn = 04, 
                    Engineering = 02,
                    Medicine = 01
                },
                Weapons = new List<string> {
                    "Disruptor Cannon",
                    "Phased Polaron Bank",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Jem'Hadar Battle Cruiser",
                Scale = 6,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 09,
                    Structure = 12,
                    Computers = 08,
                    Sensors = 10, 
                    Weapons = 11,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 04,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 02,
                    Medicine = 01
                },
                Weapons = new List<string> {
                    "Phased Polaron Array",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Borg Sphere",
                Scale = 7,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 11,
                    Structure = 12,
                    Computers = 12,
                    Sensors = 10, 
                    Weapons = 10,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 03,
                    Conn = 03, 
                    Engineering = 03,
                    Medicine = 03
                },
                Weapons = new List<string> {
                    "Cutting Beam",
                    "Energy Drain Beam",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Borg Cube",
                Scale = 13,
                Systems = new Systems {
                    Comms = 10,
                    Engines = 11,
                    Structure = 15,
                    Computers = 12,
                    Sensors = 10, 
                    Weapons = 12,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 03,
                    Science = 03,
                    Conn = 03, 
                    Engineering = 03,
                    Medicine = 03
                },
                Weapons = new List<string> {
                    "Cutting Beam",
                    "Energy Drain Beam",
                    "Tractor Beam (Strength 5)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "D'Kora Marauder",
                Scale = 5,
                Systems = new Systems {
                    Comms = 09,
                    Engines = 10,
                    Structure = 10,
                    Computers = 08,
                    Sensors = 09, 
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 03,
                    Security = 02,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 02,
                    Medicine = 02
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Electro-Magnetic Pulse",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 4)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Maquis Raider",
                Scale = 3,
                Systems = new Systems {
                    Comms = 08,
                    Engines = 08,
                    Structure = 06,
                    Computers = 07,
                    Sensors = 09, 
                    Weapons = 07,
                },
                Departments = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 01,
                    Conn = 04, 
                    Engineering = 02,
                    Medicine = 01
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photon Torpedoes",
                    "Tractor Beam (Strength 2)"
                },
                StartingTalents = new List<string> {},
            },
            new Spaceframe {
                Name = "Maquis Fighter",
                Scale = 1,
                Systems = new Systems {
                    Comms = 07,
                    Engines = 07,
                    Structure = 06,
                    Computers = 06,
                    Sensors = 06, 
                    Weapons = 06,
                },
                Departments = new Disciplines {
                    Command = 00,
                    Security = 01,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                Weapons = new List<string> {
                    "Phaser Banks",
                    "Photon Torpedoes",
                },
                StartingTalents = new List<string> {},
            },
        },
        new List<NpcCharacter>() {
            new NpcCharacter {
                Name = "Minor Starfleet Conn Officer",
                BaseStress = 9,
                Species = new Species{ Name="Human" },
                Attributes = new Attributes {
                    Control = 10,
                    Fitness = 10,
                    Presence = 10,
                    Daring = 10,
                    Insight = 08,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 02,
                    Medicine = 01
                }
            },
            new NpcCharacter {
                Name = "Minor Starfleet Security Officer",
                BaseStress = 11,
                Species = new Species{ Name="Human" },
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
                    Security = 02,
                    Science = 01,
                    Conn = 01, 
                    Engineering = 01,
                    Medicine = 01
                }
            },
            new NpcCharacter {
                Name = "Minor Starfleet Engineer",
                BaseStress = 10,
                Species = new Species{ Name="Human" },
                Attributes = new Attributes {
                    Control = 10,
                    Fitness = 09,
                    Presence = 08,
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
                }
            },
            new NpcCharacter {
                Name = "Minor Starfleet Science Officer",
                BaseStress = 9,
                Species = new Species{ Name="Human" },
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 08,
                    Presence = 08,
                    Daring = 09,
                    Insight = 10,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 01,
                    Medicine = 02
                }
            },
            new NpcCharacter {
                Name = "Notable Section 31 Operative",
                BaseStress = 11,
                Species = new Species{ Name="Human" },
                Values = new List<string> {
                    "The Ends Justify the Means"
                },
                Focuses = new List<string> {
                    "Espionage",
                    "Infiltration"
                },
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 08,
                    Presence = 10,
                    Daring = 09,
                    Insight = 10,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 02,
                    Conn = 01, 
                    Engineering = 02,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Adaptable: May spend 2 Threat to immediately gain a single Focus for the remainder of the scene",
                    "Covert: Whenever required to attempt a Task to conceal their activities, they may roll an aditional d20"
                }
            },
            new NpcCharacter {
                Name = "Minor Klingon Warrior",
                BaseStress = 13,
                Resistance = 1,
                Species = new Species{ Name="Klingon" },
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 11,
                    Presence = 10,
                    Daring = 11,
                    Insight = 08,
                    Reason = 08
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Brak'lul: Resistance increased by +2 against non-lethal attacks",
                    "Warrior's Spirit: When attempting a melee attack, and purchases one or more dice, re-roll any number of dice."
                }
            },
            new NpcCharacter {
                Name = "Notable Klingon Warrior",
                BaseStress = 14,
                Resistance = 1,
                Values = new List<string> {
                    "Today is a Good Day to Die!"
                },
                Focuses = new List<string> {
                    "Hand-toHand Combat",
                    "Resilience"
                },
                Species = new Species{ Name="Klingon" },
                Attributes = new Attributes {
                    Control = 09,
                    Fitness = 11,
                    Presence = 10,
                    Daring = 11,
                    Insight = 08,
                    Reason = 08
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "First into Battle: Spend 3 Momentum to assist andother Klingon's next attack using Daring + Command",
                    "Brak'lul: Resistance increased by +2 against non-lethal attacks",
                    "Warrior's Spirit: When attempting a melee attack, and purchases one or more dice, re-roll any number of dice."
                }
            },
            new NpcCharacter {
                Name = "Minor Romulan Uhlan",
                BaseStress = 11,
                Resistance = 0,
                Species = new Species{ Name="Romulan" },
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 09,
                    Presence = 08,
                    Daring = 08,
                    Insight = 10,
                    Reason = 11
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Guile and Cunning: When attempting to remain hidden or unnoticed, spend one Threat to increase the difficulty of enemy detection Tasks",
                    "Wary: When attempting to detect an enemy or hazard you may re-roll one d20"
                }
            },
            new NpcCharacter {
                Name = "Notable Romulan Centurion",
                BaseStress = 11,
                Resistance = 0,
                Species = new Species{ Name="Romulan" },
                Values = new List<string> {
                    "I Will Not Fail in My Duty to the Empire"
                },
                Focuses = new List<string> {
                    "Paranoid",
                    "Guerilla Tactics"
                },
                Attributes = new Attributes {
                    Control = 12,
                    Fitness = 09,
                    Presence = 09,
                    Daring = 10,
                    Insight = 10,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 03,
                    Security = 02,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Ambush: When attacking an unaware opponent, spend 2 Threat to allow for all Centurion under their command to re-roll any number of d20 on attack rolls",
                    "Guile and Cunning: When attempting to remain hidden or unnoticed, spend one Threat to increase the difficulty of enemy detection Tasks",
                    "Wary: When attempting to detect an enemy or hazard you may re-roll one d20"
                }
            },
            new NpcCharacter {
                Name = "Minor Ferengi Menial",
                BaseStress = 9,
                Resistance = 0,
                Species = new Species{ Name="Ferengi" },
                Values = new List<string> {
                    
                },
                Focuses = new List<string> {
                    
                },
                Attributes = new Attributes {
                    Control = 10,
                    Fitness = 08,
                    Presence = 11,
                    Daring = 08,
                    Insight = 11,
                    Reason = 09
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 01,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 02,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Greed Is Eternal: When enraged in negotiations that have the potential for profit, spend 1 Threat during the Task to re-roll the dice pool"
                }
            },
            new NpcCharacter {
                Name = "Minor Ferengi Salesman",
                BaseStress = 9,
                Resistance = 0,
                Species = new Species{ Name="Ferengi" },
                Values = new List<string> {
                    "First Rule of Acquisition - Once You Have Their Money, Never Give It Back"
                },
                Focuses = new List<string> {
                    "Economics",
                    "Negotiation"
                },
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 08,
                    Presence = 12,
                    Daring = 09,
                    Insight = 10,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 03,
                    Security = 01,
                    Science = 02,
                    Conn = 00, 
                    Engineering = 02,
                    Medicine = 01
                },
                SpecialRules = new List<string> {
                    "Greed Is Eternal: When enraged in negotiations that have the potential for profit, spend 1 Threat during the Task to re-roll the dice pool",
                    "Free Advice Is Seldom Cheap: Increase the difficulty og all social conflict to persuasion by 2. Remove this difficulty if something is offered in trade.",
                }
            },
            new NpcCharacter {
                Name = "Minor Cardassian Soldier",
                BaseStress = 11,
                Resistance = 1,
                Species = new Species{ Name="Cardassian" },
                Values = new List<string> {
                
                },
                Focuses = new List<string> {
                
                },
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 09,
                    Presence = 09,
                    Daring = 10,
                    Insight = 08,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 01,
                    Security = 02,
                    Science = 00,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Ambushes and Traps: Whenever a Ready Task is used to ready a Ranged attack, that Ranged attack gets a bonus d20",
                    "Loyal and Disciplined: Whenever a Cardassian recieves assistance from a superior, that Cardassian may re-roll a single d20"
                }
            },
            new NpcCharacter {
                Name = "Notable Cardassian Glinn",
                BaseStress = 12,
                Resistance = 1,
                Species = new Species{ Name="Cardassian" },
                Values = new List<string> {
                "Cardassians Dot Not Choose to Be Superior, Fate Made Us This Way"
                },
                Focuses = new List<string> {
                    "Military Tactics",
                    "Willpower"
                },
                Attributes = new Attributes {
                    Control = 12,
                    Fitness = 09,
                    Presence = 11,
                    Daring = 10,
                    Insight = 08,
                    Reason = 10
                },
                Disciplines = new Disciplines {
                    Command = 02,
                    Security = 03,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Expects Success: Whenever a Glinn uses the Direct or Asssit Task to aid a subordinate, that Task may always Succeed at Cost",
                    "Ambushes and Traps: Whenever a Ready Task is used to ready a Ranged attack, that Ranged attack gets a bonus d20",
                    "Loyal and Disciplined: Whenever a Cardassian recieves assistance from a superior, that Cardassian may re-roll a single d20"
                }
            },
            new NpcCharacter {
                Name = "Borg Tactical Drone",
                BaseStress = 14,
                Resistance = 3,
                Species = new Species{ Name="Borg" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 12,
                    Presence = 06,
                    Daring = 09,
                    Insight = 06,
                    Reason = 12
                },
                Disciplines = new Disciplines {
                    Command = 00,
                    Security = 02,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 01,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Adaptive Shielding: Each time a drone is injured by energy based attacks, roll 1 challenge die for each drone effected. If an effect is rolled, all drones in the scene become immune to that type of weapon",
                    "Assimilation: A character injured by assimilation tubules must fight off the injected nano-probes. If the character dies from the injury the character becomes a drone, otherwise add 1 threat to the begining of each scene to avoid succumbing to the nano-probes. This can be healed by a Control + Medicine task with difficulty 4.",
                    "Immune to Fear",
                    "Immune to Pain",
                    "Machine 3",
                    "Night Vision",
                    "Threat Protocols: Drones do not attack until they see people as threats. In order to attack before being attacked, one threat per drone must be spent per scene.",
                }
            },
            new NpcCharacter {
                Name = "Borg Technical Drone",
                BaseStress = 11,
                Resistance = 2,
                Species = new Species{ Name="Borg" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 10,
                    Presence = 06,
                    Daring = 09,
                    Insight = 06,
                    Reason = 12
                },
                Disciplines = new Disciplines {
                    Command = 00,
                    Security = 01,
                    Science = 01,
                    Conn = 02, 
                    Engineering = 02,
                    Medicine = 00
                },
                SpecialRules = new List<string> {
                    "Adaptive Shielding: Each time a drone is injured by energy based attacks, roll 1 challenge die for each drone effected. If an effect is rolled, all drones in the scene become immune to that type of weapon",
                    "Assimilation: A character injured by assimilation tubules must fight off the injected nano-probes. If the character dies from the injury the character becomes a drone, otherwise add 1 threat to the begining of each scene to avoid succumbing to the nano-probes. This can be healed by a Control + Medicine task with difficulty 4.",
                    "Immune to Fear",
                    "Immune to Pain",
                    "Machine 2",
                    "Night Vision",
                    "Threat Protocols: Drones do not attack until they see people as threats. In order to attack before being attacked, one threat per drone must be spent per scene.",
                }
            },
            new NpcCharacter {
                Name = "Borg Medical Drone",
                BaseStress = 11,
                Resistance = 2,
                Species = new Species{ Name="Borg" },
                Values = new List<string> {},
                Focuses = new List<string> {},
                Attributes = new Attributes {
                    Control = 11,
                    Fitness = 10,
                    Presence = 06,
                    Daring = 09,
                    Insight = 06,
                    Reason = 12
                },
                Disciplines = new Disciplines {
                    Command = 00,
                    Security = 01,
                    Science = 02,
                    Conn = 00, 
                    Engineering = 01,
                    Medicine = 02
                },
                SpecialRules = new List<string> {
                    "Adaptive Shielding: Each time a drone is injured by energy based attacks, roll 1 challenge die for each drone effected. If an effect is rolled, all drones in the scene become immune to that type of weapon",
                    "Assimilation: A character injured by assimilation tubules must fight off the injected nano-probes. If the character dies from the injury the character becomes a drone, otherwise add 1 threat to the begining of each scene to avoid succumbing to the nano-probes. This can be healed by a Control + Medicine task with difficulty 4.",
                    "Immune to Fear",
                    "Immune to Pain",
                    "Machine 2",
                    "Night Vision",
                    "Threat Protocols: Drones do not attack until they see people as threats. In order to attack before being attacked, one threat per drone must be spent per scene.",
                    "Reclamation: Drone may attempt a Reason + Medicine task with difficulty 0 on an injured drone within reach. If successful, the injured drone dies and its parts are reclaimed."
                }
            }
        },
        new List<MissionProfile> {
            new MissionProfile(
                "Strategic and Diplomatic Operations", 
                "Vessels equipped for Strategic and Diplomatic Operations are often placed under the command of flag officers and used as the heart of squadrons, battle-groups, and even whole fleets. These ships — and the prestige and standing that accompanies them — are also used for major diplomatic engagements, where they can serve as mobile embassies and represent the best of the Federation.",
                new Systems{
                    
                }, 
                new Disciplines{
                    Command = 3,
                    Security = 2,
                    Science = 2,
                    Conn = 1,
                    Engineering = 2,
                    Medicine = 2
                },
                new List<string> {
                    "Command Ship",
                    "Diplomatic Suites",
                    "Electronic Warfare Systems",
                    "Extensive Shuttlebays"
                }
            ),
            new MissionProfile(
                "Pathfinder and Reconnaissance Operations", 
                "Long-range missions often employ the most advanced stellar cartography and astrometric facilities, allowing them to chart and navigate unknown regions of space effectively. These vessels are relied upon for extended exploratory missions, intelligence-gathering military operations, and risky “pathfinder” operations into the unknown.",
                new Systems{

                }, 
                new Disciplines{
                    Command = 2,
                    Security = 2,
                    Science = 2,
                    Conn = 3,
                    Engineering = 2,
                    Medicine = 1
                },
                new List<string> {
                    "Improved Reaction Control System",
                    "Improved Warp Drive",
                    "Rugged Design"
                }
            ),
            new MissionProfile(
                "Technical Test-Bed", 
                "The ship is equipped with an abundance of state-of-the- art or even prototype technologies, allowing them to be tested and studied in practical conditions, so that the flaws can be discovered and overcome, and the systems can be refined and improved upon. These ships are often deployed on a broad range of missions, to provide the most diverse conditions for equipment testing.",
                new Systems{

                }, 
                new Disciplines{
                    Command = 1,
                    Security = 2,
                    Science = 2,
                    Conn = 2,
                    Engineering = 3,
                    Medicine = 1
                },
                new List<string> {
                    "Advanced Shields",
                    "Backup EPS Conduits",
                    "High Resolution Sensors",
                    "Improved Power Systems",
                    "Improved Warp Drive"
                }
            ),
            new MissionProfile(
                "Tactical Operations", 
                "While Starfleet is not a military, the defense of the Federation is one of Starfleet’s responsibilities, and Starfleet has been required to prepare for war on numerous occasions. Thus, many ships are equipped for police and military actions, though the number of vessels outfitted in this manner varies depending on the politics of the day.",
                new Systems{

                }, 
                new Disciplines{
                    Command = 2,
                    Security = 3,
                    Science = 1,
                    Conn = 2,
                    Engineering = 2,
                    Medicine = 2
                },
                new List<string> {
                    "Ablative Armor",
                    "Fast Targetting Systems",
                    "Improved Damage Control",
                    "Quantum Torpedoes",
                    "Improved Impulse Drive"
                }
            ),
            new MissionProfile(
                "Scientific and Survey Operations", 
                "Starfleet’s mission of exploration and discovery means that they employ many vessels for purely scientific missions, studying unknown phenomena or supporting ongoing research. While most Federation starships are expected to have at least some capacity for scientific endeavor, some vessels are equipped specifically for such missions.",
                new Systems{

                }, 
                new Disciplines{
                    Command = 2,
                    Security = 1,
                    Science = 3,
                    Conn = 2,
                    Engineering = 2,
                    Medicine = 2
                },
                new List<string> {
                    "Advanced Research Facilities",
                    "Advanced Sensor Suites",
                    "High Resolution Sensors",
                    "Modular Laboratories"
                }
            ),
            new MissionProfile(
                "Crisis and Emergency Response", 
                "These vessels are equipped to respond quickly to a crisis, whatever it may be. Normally capable of supporting expansive shuttlebays, they can deploy large quantities of personnel or cargo to, or evacuate large populations from, disaster areas. Such vessels also serve as hospital ships and troop transports during times of war.",
                new Systems{

                }, 
                new Disciplines{
                    Command = 2,
                    Security = 2,
                    Science = 2,
                    Conn = 2,
                    Engineering = 1,
                    Medicine = 3
                },
                new List<string> {
                    "Advanced Sickbay",
                    "Emergency Medical Hologram",
                    "Extensive Shuttlebays",
                    "Modular Laboratories"
                }
            ),
            new MissionProfile(
                "Multirole Explorer", 
                "Some of Starfleet’s most renowned and revered vessels have been jacks-of-all-trades, rather than specialized for a single type of mission. This versatility allowed the likes of Jonathan Archer and James Kirk to explore strange new worlds, seek out new life and new civilizations, and to boldly go where no one has gone before.",
                new Systems{

                }, 
                new Disciplines{
                    Command = 2,
                    Security = 2,
                    Science = 2,
                    Conn = 2,
                    Engineering = 2,
                    Medicine = 2
                },
                new List<string> {
                    "Improved Hull Integrity",
                    "Improved Power Systems",
                    "Rugged Design",
                    "Redundant Systems",
                    "Secondary Reactors"
                }
            ),
        },
        new List<ShipTalent> {
            new DateLimitedTalent(
                new System.DateTime(2371, 1, 1),
                "Ablative Armor",
                "The vessel’s hull plating has an additional ablative layer that disintegrates slowly under extreme temperatures, such as those caused by energy weapons and torpedo blasts, dissipating the energy, and protecting the ship. This plating is replaced periodically. The ship’s Resistance is increased by 2."
            ),
            new DepartmentLimitedTalent(
                new Disciplines{
                    Science = 3
                },
                "Advanced Research Facilities",
                "The vessel is equipped with additional laboratories and long-term research facilities, which allow the crew to study phenomena over a protracted period, and thus generate a wealth of useful information. Whenever a character on board the ship attempts a Task to perform research, and they are assisted by the ship’s Computers + Science, the character gains one bonus Momentum, which must be used for the Obtain Information Momentum Spend."
            ),
            new ShipTalent(
                "Advanced Sensor Suites",
                "The vessel’s sensors are amongst the most sophisticated and advanced available in the fleet. Unless the ship’s Sensors have suffered one or more Breaches, whenever a character performs a Task assisted by the ship’s Sensors, they may reduce the Difficulty of the Task by one, to a minimum of 0."
            ) ,
            new ShipTalent(
                "Advanced Shields",
                "The vessel’s shields are state of the art, using developments that other cultures have not yet learned to overcome, or which simply provide greater protection for the same power expenditure. The ship’s maximum Shields are increased by 5."
            ) { ShieldModifier = 5 },
            new ShipTalent(
                "Advanced Sickbay",
                "The ship’s sickbay is extremely well-equipped, and larger than is normal for a ship of this size. The ship gains the Advanced Sickbay Advantage, which applies to all Tasks related to medicine and biology performed within the sickbay itself. This Advantage is lost if the ship’s Computers System is Disabled."
            ),
            new ShipTalent(
                "Backup EPS Conduits",
                "The ship’s power conduits have additional redundancies, which can be activated to reroute power more easily in case of an emergency, keeping it from being lost when the ship is damaged. Whenever the ship would lose one or more Power because of suffering damage, roll for each Power lost. Each Effect rolled prevents the loss of that point of Power."
            ),
            new DepartmentLimitedTalent(
                new Disciplines {
                    Command = 3
                },
                "Command Ship",
                "The ship has command and control systems allowing it to coordinate easily with allies during a crisis. When a character on the ship succeeds at a Command Task to create an Advantage, they may always be assisted by the ship’s Communications + Command, and they may confer the Advantage to allied ships or away teams with whom the ship maintains a communications link."
            ),
            new ShipTalent(
                "Diplomatic Suites",
                "The ship has numerous high-quality staterooms for hosting VIPs, as well as briefing rooms and other facilities that allow the ship to serve as a neutral ground for diplomatic summits, trade negotiations, and similar functions. When hosting negotiations, members of the crew may be assisted by the ship’s Computers + Command or Structure + Command."
            ),
            new ShipTalent(
                "Electronic Warfare Systems",
                "The ship’s communications systems have been specially- designed to intercept and disrupt enemy communications in battle. Whenever a character on the ship succeeds at the Intercept or Signals Jamming Tasks, they may spend 2 Momentum to select one additional ship to target."
            ),
            new DateLimitedTalent(
                new System.DateTime(2371, 1, 1),
                "Emergency Medical Hologram",
                "The ship’s sickbay is equipped with holoemitters and a state-of-the-art holographic doctor, able to assist medical personnel during emergencies. The ship has one additional Supporting Character, an Emergency Medical Hologram, using the Attributes, Disciplines, and so forth as shown in the sidebar, which does not cost any Crew Support to introduce, and which does not automatically improve when introduced. This character cannot go into any location not equipped with holoemitters."
            ),
            new ShipTalent(
                "Extensive Shuttlebays",
                "The vessel’s shuttlebays are large, well-supplied, and able to support a larger number of active shuttle missions simultaneously. The ship may have twice as many small craft active at any one time as it would normally allow, and it may carry up to two Scale 2 small craft."
            ),
            new DepartmentLimitedTalent(
                new Disciplines{
                    Security = 3
                },
                "Fast Targetting Systems",
                "The ship’s targeting systems can lock weapons on target much faster and more accurately than other ships of its class, giving it an edge in battle. The ship does not suffer the normal Difficulty increase for targeting a specific System on the enemy ship."
            ),
            new ShipTalent(
                "High Resolution Sensors",
                "The vessel’s sensors can gain large amounts of accurate data, though they are extremely sensitive. While the vessel is not in combat, any successful Task that is assisted by the ship’s Sensors gains one bonus Momentum."
            ),
            new ShipTalent(
                "Improved Damage Control",
                "The ship has more efficient damage reporting systems, and better-trained teams of technicians, allowing the crew to respond more quickly to damage during a crisis. When a character takes the Damage Control Task aboard this ship, they may re-roll a single d20. If the repairs require an Extended Task, then the characters also gain Progression 1, adding +1 to Work done for each Effect rolled."
            ),
            new ShipTalent(
                "Improved Hull Integrity",
                "The ship’s hull has been reinforced to hold together better under stress and damage. The ship’s Resistance is increased by 1."
            ) {ResistanceModifier = 1},
            new ShipTalent(
                "Improved Impulse Drive",
                "The ship’s Impulse drives are more powerful than on most ships, allowing the ship to accelerate much more quickly. When the flight controller succeeds at the Impulse, Attack Pattern, Evasive Action, or Ramming Speed Tasks, they may spend 2 Momentum to increase the Difficulty of attacks against the ship by 1 until the start of the flight controller’s next Turn, due to the ship’s rapid acceleration."
            ),
            new ShipTalent(
                "Improved Power Systems",
                "The ship’s power systems are extremely efficient, allowing power to be redirected and rerouted from different systems very quickly. Whenever a character succeeds at a Power Management Task, the ship gains 2 Power per Momentum spent (Repeatable) instead of 1."
            ),
            new DepartmentLimitedTalent(
                new Disciplines {
                    Conn = 3
                },
                "Improved Reaction Control System",
                "The ship’s maneuvering thrusters operate with greater precision, allowing the ship to adjust its course more carefully. Whenever a Task to move or maneuver the ship would increase in Difficulty because of obstacles or hazards, reduce the Difficulty by 1 (to a minimum of the Task’s normal Difficulty)."
            ),
            new DepartmentLimitedTalent(
                new Disciplines{
                    Security = 3
                },
                "Improved Shield Recharge",
                "The ship’s deflector shields have redundant capacitors and emitter arrays that allow the shields to be recharged and replenished much more efficiently. Whenever the Regenerate Shields Task is successful, the ship regains 3 points of Shields, plus 3 more for each Momentum spent (Repeatable), instead of the normal amount."
            ),
            new ShipTalent(
                "Improved Warp Drive",
                "The ship’s warp drive is more efficient, capitalizing on improved field dynamics, better control of antimatter flow rates, or some other advancement that allows the ship to expend less energy when travelling at warp. Whenever the ship spends power to go to warp, roll 1 for each Power spent; for each Effect rolled, that point of Power is not spent."
            ),
            new DepartmentLimitedTalent(
                new Disciplines{
                    Science=2
                },
                "Modular Laboratories",
                "The ship has considerable numbers of empty, multi-purpose compartments that can be converted to laboratories as and when required. At the start of an adventure, the crew may decide how the modular laboratories are configured; this configuration counts as an Advantage which applies to work performed within the laboratories."
            ),
            new DateLimitedTalent(
                new System.DateTime(2371, 1, 1),
                "Quantum Torpedoes",
                "The vessel has been equipped with the latest in ship-to-ship munitions: the quantum torpedoes. The ship has quantum torpedoes in addition to any other form of torpedo it carries."
            ),
            new ShipTalent(
                "Rapid-Fire Torpedo Launcher",
                "The vessel’s torpedo launchers have been redesigned to allow the ship to fire multiple torpedoes much more quickly and accurately. Whenever the crew add 3 to Threat to fire a torpedo salvo, they may re-roll a single d20 on the attack, and any number of on the damage roll."
            ),
            new ShipTalent(
                "Redundant Systems",
                "The ship has multiple additional redundancies that allow it to withstand severe damage more easily. Nominate a single System. When that system becomes Damaged or Disabled, the crew may choose to activate the backups as a Minor Action; if the System was Damaged, it is no longer Damaged."
            ),
            new ShipTalent(
                "Rugged Design",
                "The ship is designed with the frontier in mind, with a durable construction and easy access to critical systems that allow repairs to be made easily. Reduce the Difficulty of all Tasks to repair the ship by 1, to a minimum of 1."
            ),
            new SpaceframeLimitedTalent(
                "Galaxy Class",
                "Saucer Separation",
                "The ship is designed so that the saucer section can be separated from the engineering section, to operate as two distinct ships. Each section has the same Systems, Departments, Talents, and weapons, but their Scale is one lower than the whole ship (recalculate anything derived from Scale), and each section only has half the Power (round down) that the ship had before separation. Further, if the ship has suffered any damage, ongoing effects of that damage apply equally to both sections. The saucer section, which contains the crew quarters and recreational areas, does not have the capacity to go to warp."
            ),
            new ShipTalent(
                "Secondary Reactors",
                "The ship has additional impulse and fusion reactors, that allow the ship to generate far greater quantities of energy. Increase the ship’s normal Power capacity by 5."
            ) {PowerModifier = 5}
        },
        new List<Item> {
            new Item { Name = "Uniform" },
            new Item { Name = "Communicator" },
            new Item { Name = "Tricorder" },
            new Item { Name = "Phaser Type 1", UsageDice = 2, Qualities = new List<string>{ "Charge", "Hidden 1" } },
            new Item { Name = "Unarmed Strike", UsageDice = 1, Qualities = new List<string>{ "Knockdown", "Non-lethal" } },
        }
    );
}

}