using System;
using System.Collections.Generic;

namespace TrekSharp.Rulebooks {
    
public class ScienceDivision : BaseRulebook {
    private ScienceDivision() {}

    public static ScienceDivision Instance = new ScienceDivision() {
        Talents = new List<CharacterTalent> {
            // Science
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Presence = 9
                },
                new Disciplines {
                    Science = 3
                },
                "Baffling Briefing",
                "When the character engages in a Social Conflict using deception, the character may use Science in place of Command so long as their technical knowledge is used to mislead their opponent."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Science = 4
                },
                "Dedicated Focus",
                "When this Talent is taken, choose a Focus your character has. When attempting a Task where that Focus applies, each d20 that generates 2 successes also generates 1 bonus Momentum. This Talent only applies to d20s in the character’s dice pool, and does not apply to d20s added due to equipment, starship assistance, or character assistance."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Fitness = 9
                },
                new Disciplines {
                    Science = 3
                },
                "Expedition Expert",
                "Prior to participating in an away team mission, the character may prepare by conducting a research Task. If they succeed, Momentum may be spent to allow the character to substitute their Science Discipline in place of any other, during any Task to navigate or transverse difficult terrain during the mission. Each point of Momentum spent from the research Task in this way allows for one such substitution."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Science = 3,
                    Engineering = 3
                },
                "Lab Rat",
                "The character prefers to spend most of their free time engaged in various side projects and experiments. Because of this, they are extremely familiar with the equipment and capabilities of the labs on board their ship. When attempting an Extended Task while using a laboratory, the character gains the Progression 1 Effect."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Reason = 10
                },
                new Disciplines {
                    Science = 3
                },
                "Mental Repository",
                "Using extensive mental conditioning, the character has access to memories with unprecedented clarity and accuracy. So long as the character takes time to focus their mind prior to attempting a Task – which takes 2 Intervals during a Timed Challenge – they reduce the Difficulty of the Task by 1 to a minimum of 1. In addition, if they succeed they gain a bonus Momentum which may only be spent on the Obtain Information Momentum spend."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Reason = 9
                },
                new Disciplines {
                    Science = 3
                },
                "Rapid Analysis",
                "Tasks attempted as part of a Timed Challenge using the Science Discipline takes the character 1 Time Interval instead of 2. The amount of time taken for any Task may not be reduced to less than 1 Interval."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Science = 4,
                    Security = 3
                },
                "Student Of War",
                "The character has conducted extensive research into numerous kinds of conflict and has devoted their academic career to the study of war. While this knowledge may be purely theoretical, such information, when placed into the hands of more capable combatants, can be truly devastating. When the character provides assistance to a Combat Task, they may reroll their die."
            ),
            new DisciplineAndFocusTalent (
                new Disciplines {
                    Science = 3,
                },
                "Temporal Mechanics",
                "Temporal Mechanic",
                "Long study into the facets of temporal mechanics has given the character an intuitive understanding of the space-time continuum and the various phenomena that can distort it. Once per scene, when confronted with an anomaly that affects the flow of time and space, the character rolls one Challenge Dice when attempting a Task relating to the phenomenon. The character generates bonus Momentum equal to the dice result, in addition to any Momentum generated from the Task result. If an Effect is rolled, the Gamemaster gains 1 Threat instead."
            ),
            new DisciplineAndTalentTalent (
                new Disciplines {
                    Science = 3 
                },
                "Testing A Theory",
                "Theory Into Practice",
                "When you attempt a Task using Engineering or Science where you gain the additional d20 from the Testing a Theory Talent, reduce the Difficulty of the Task by 1, to a minimum of 0."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Insight = 9
                },
                new Disciplines {
                    Science = 3
                },
                "Unconventional Thinking",
                "During any Challenge or Extended Task that uses the Scientific Method to adapt technology in which the character is participating, if the hypothesis being pursued is considered “Outside the Box” – the Difficulty of the Tasks are reduced by 1. It should be noted that Players are not aware of the fact they are pursuing an “Outside the Box” hypothesis under normal circumstances – it is up to the Gamemaster to ensure they receive the proper Difficulty reduction."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Reason = 9
                },
                new Disciplines {
                    Science = 2
                },
                "Walking Encyclopedia",
                "Once per session, when you attempt a Task, you may spend 2 Momentum (Immediate) in order to gain an additional Focus for the remainder of the session, due to your breadth of knowledge. However, any Task using that Focus increases in Complication range by 1, as you are not a true expert on that subject."
            ),

            // Medical
            new DisciplineLimitedTalent (
                new Disciplines {
                    Command = 3,
                    Medicine = 3
                },
                "Bedside Manner",
                "When the character succeeds at a Medicine Task to heal another’s Injury, the character may immediately remove a personal Complication from the patient, even if that Complication was unrelated to the treated Injury. In addition, whenever this character attempts a Reputation Check, they are considered to have one additional positive influence."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Command = 3,
                    Medicine = 3
                },
                "Chief Of Staff",
                "When using the Medicine Discipline to provide assistance to another character attempting a Medicine Task, all characters providing assistance may reroll one d20 in their dice pool."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Engineering = 3,
                    Medicine = 3
                },
                "Cyberneticist",
                "Whenever the character attempts a Task to work on, install, or remove a cybernetic device from a patient, they add a d20 to their dice pool."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 4
                },
                "Fellowship Specialty",
                "Select a Focus. When you succeed at a Medicine Task where that Focus applies, the cost of the Create Advantage Momentum spend is reduced by 1, to a minimum of 1."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Security = 2
                },
                "Field Medic",
                "Through experience and training, the stress of battle fades when there’s a patient in need. When attempting a Medicine Task while in the midst of combat, you may ignore the first Complication that would increase the Difficulty of this Task."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Control = 9
                },
                new Disciplines {
                    Medicine = 3
                },
                "Healing Hands",
                "When attempting the Control + Medicine Task to heal Injury-related Complications, reduce the Difficulty by 1, to a minimum of 1."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Command = 2
                },
                "Heart, Body, and Mind",
                "Whenever you Assist a character with the Recover Combat Task, you gain 1 bonus Momentum that can only be spent on the active character to recover Stress."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Command = 1,
                },
                "I'm A Doctor, Not A... (Command)",
                "Once per scene, before attempting a Task using the Command Discipline, a point of Determination may be spent to substitute the character’s Medicine Score in place of that Discipline. This does not have to be linked to a Value."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Security = 1,
                },
                "I'm A Doctor, Not A... (Security)",
                "Once per scene, before attempting a Task using the Security Discipline, a point of Determination may be spent to substitute the character’s Medicine Score in place of that Discipline. This does not have to be linked to a Value."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Science = 1,
                },
                "I'm A Doctor, Not A... (Science)",
                "Once per scene, before attempting a Task using the Science Discipline, a point of Determination may be spent to substitute the character’s Medicine Score in place of that Discipline. This does not have to be linked to a Value."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Conn = 1,
                },
                "I'm A Doctor, Not A... (Conn)",
                "Once per scene, before attempting a Task using the Conn Discipline, a point of Determination may be spent to substitute the character’s Medicine Score in place of that Discipline. This does not have to be linked to a Value."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Engineering = 1,
                },
                "I'm A Doctor, Not A... (Engineering)",
                "Once per scene, before attempting a Task using the Engineering Discipline, a point of Determination may be spent to substitute the character’s Medicine Score in place of that Discipline. This does not have to be linked to a Value."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3,
                    Command = 2,
                },
                "Insightful Guidance",
                "Whenever you Assist a character, who is in a Social Conflict, using your knowledge of psychology or emotional states, that character is considered to have an Advantage in addition to the normal benefits provided by your Assist."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Presence = 9
                },
                new Disciplines {
                    Medicine = 3
                },
                "Positive Reinforcement",
                "You have a special skill for filling others with confidence and self-assuredness. Once per mission, you may attempt a Presence + Medicine Task with a Difficulty of 3, while providing emotional or mental treatment for another character. Success creates a personal Advantage for your patient that lasts until the end of the mission. In addition to the normal effects of the Trait, that character can reroll their dice pool, as if they’d spent a point of Determination, once until the end of the mission. If the Task that the character used their reroll on fails, they lose the Advantage created by this Talent."
            ),
            new AttributeAndDisciplineLimitedTalent (
                new Attributes {
                    Reason = 8
                },
                new Disciplines {
                    Medicine = 3
                },
                "Practice Makes Perfect",
                "Once per scene, after the character has succeeded on a Medicine Task relating to the treatment of a patient, reduce the Difficulty of the next Medicine Task relating to that patient by 1."
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 3
                },
                "Psychoanalyst",
                "When you use the Medicine Discipline during a Social Conflict you may increase the Complication range of your Task by a number of steps. For each step you may ask a single question as if you’d spent Momentum on Obtain Information. Any Complications generated from this Task results in the individual you are interacting with becoming offended or upset with being “analyzed.”"
            ),
            new DisciplineLimitedTalent (
                new Disciplines {
                    Medicine = 4
                },
                "Surgery Savant",
                "When attempting a Medicine Task during an Extended Task relating to surgery, the character gains the Triumphant Effect."
            )
        },
        Items = new List<Item> {
            new Item { Name = "Medical Tricorder", Size = ItemSize.OneHanded },
            new Item { Name = "Blood Gas Infuser", Size = ItemSize.TwoHanded  },
            new Item { Name = "Bone Regenerator", Size = ItemSize.TwoHanded  },
            new Item { Name = "Blood Gas Infuser", Size = ItemSize.OneHanded  },
            new Item { Name = "Cardiostimulator", Size = ItemSize.OneHanded  },
            new Item { Name = "Cortical Scanner", Size = ItemSize.OneHanded  },
            new Item { Name = "Blood Gas Infuser", Size = ItemSize.OneHanded  },
            new Item { Name = "Cortical Stimulator", Size = ItemSize.OneHanded  },
            new Item { Name = "Neural Caliper", Size = ItemSize.OneHanded  },
            new Item { Name = "Neural Pad", Size = ItemSize.OneHanded  },
            new Item { Name = "Pressor Field", Size = ItemSize.OneHanded  },
            new Item { Name = "Stasis Unit", Size = ItemSize.TwoHanded  },
            new Item { Name = "Steri-Field", Size = ItemSize.OneHanded  },
            new Item { Name = "Subdermal Bioprobes", Size = ItemSize.OneHanded  },
            new Item { Name = "Alkysine Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Anetrizine Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Arithrazine Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Axonol Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Cervaline Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Cordrazine Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Corophizine Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Cortolin Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Dermaline Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Dylovene Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Hydrocortiline Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Hydronalin Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Lectrazine Vial", Size = ItemSize.OneHanded  },
            new Item { Name = "Tri-ox Compound Vial", Size = ItemSize.OneHanded  },
        }
    };
}

}