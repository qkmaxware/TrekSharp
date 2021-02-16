using System.Collections.Generic;

namespace TrekSharp.Rulebooks {

public class MoreRaces : UnofficialRulebook {

    private MoreRaces() : base(){}

    public static readonly Rulebook Instance = new MoreRaces(){
        Species = new List<Species> () {
            new Species(
                "Aenar",
                new Attributes{
                    Control = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Android",
                new Attributes{
                    Control = 1,
                    Fitness = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Aquan",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Benzite",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Bolian",
                new Attributes{
                    Insight = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Bynar",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Reason = 1
                }
            ),
            new Species (
                "Caitian",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Fitness = 1
                }
            ),
            new Species(
                "Cardassian",
                new Attributes {
                    Control = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Changeling",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Insight = 1
                }
            ),
            new Species(
                "Deltan",
                new Attributes {
                    Control = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Edosian",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Efrosian",
                new Attributes {
                    Daring = 1,
                    Insight = 1,
                    Reason = 1
                }
            ),
            new Species(
                "El-Aurian",
                new Attributes {
                    Insight = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Ferengi",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1
                }
            ),
            new Species(
                "Gorn",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Fitness = 1
                }
            ),
            new Species(
                "Horta",
                new Attributes {
                    Control = 1,
                    Insight = 1,
                    Presence = 1
                }
            ),
            new Species(
                "Kelpien",
                new Attributes {
                    Insight = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Klingon",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Presence = 1
                }
            ),
            new Species(
                "Nausicaan",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Presence = 1
                }
            ),
            new Species(
                "Orion",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Presence = 1
                }
            ),
            new Species(
                "Pakled",
                new Attributes {
                    Control = 1,
                    Daring = 1,
                    Insight = 1
                }
            ),
            new Species(
                "Romulan",
                new Attributes {
                    Control = 1,
                    Fitness = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Saurian",
                new Attributes {
                    Fitness = 1,
                    Presence = 1,
                    Reason = 1
                }
            ),
            new Species(
                "Skorr",
                new Attributes {
                    Daring = 1,
                    Fitness = 1,
                    Reason = 1
                }
            )
        },
        Talents = new List<CharacterTalent> {
            new SpeciesRestrictedTalent("Aenar", "Empath", "You can sense the emotions of most living beings nearby, and can communicate telepathically with other empaths and telepaths, as well as with whom you are extremely familiar. YOu cannot choose not to sense the emotions of those nearby except for those who are resistant to telepathy. It may require effort and a Task to pick out the emotions of a specific individual in a crowd, or to block out the emotions of those nearby. Increase the difficulty of the Task if the situation is stressful, there are lats of people present, if the target has resistance to telepathy, or other relevant factors."),
            new SpeciesRestrictedTalent("Aenar", "Telepath", "You can sense the surface thoughts and emotions of most living beings nearby, and can communicate telepathically with other empaths and telepaths, as well as those with whom you are extremely familiar. Surface thoughts are whatever a creature is thinking about at that precise moment. The character cannot choose not to sense the emotions or read the surface thoughts of those nearby, except for those that are resistant to telepathy. If will require effort and a Task to pick out the emotions or thoughts od a specific individual in a crowd, to search a creature;s mind for specific thoughts or memories, or to block out the minds of those nearby."),
            new SpeciesRestrictedTalent("Aenar", "Telepathic Interference", "Your skills at telepathy can interfere with the ability of others to read minds, sense thoughts and emotions, or send telepathic signals. Asa Minor Action, you can shield the minds of others, preventing the detection of surface thoughts and emotions, as well as blocking telepathic communication. Attempts to push past your block is an Opposed Task. Additionally, you can assist other creatures in resisting having their mind read."),
        
            new SpeciesRestrictedTalent("Android", "Internal Database", "Your internal memory contains a wealth of knowledge of a variety of subjects, When you succeed at a Task using Insight or Reason, you gain one bonus Momentum, which may only be used for the Obtain Information Momentum Spend."),
            new SpeciesRestrictedTalent("Android", "Limited Emotions", "You either lack emotions, or your emotions are an imperfect copy of humanities'. You reduce the Difficulty of all Tasks to resist coercion, mental intrusion, pain, and other mental attacks by two."),
            new SpeciesRestrictedTalent("Android", "Reroute Systems", "You have automated repair protocols that can reactivate your systems after you have received damage. Once per mission, while Injured you can attempt a Control+ Engineering Task, with a Difficulty of 2. On a success, you recover, removing that Injury, but must still undergo repairs to fully remove the damage. You can perform this Task despite being Injured."),
            
            new SpeciesRestrictedTalent("Aquan", "3-Dimensional Thinking", "You are adept at maneuvering and shifting in multiple dimensions. When you succeed on the Evasive Action Task, you can spend 1 Momentum to increase the Difficulty of attacks against you by 1."),
            new SpeciesRestrictedTalent("Aquan", "Pacifistic", "You have received specialized training in Aquan forms of combat, allowing you to effectively use weapons designed for killing in a non-lethal manner. When you attack with a Deadly weapon, the Difficulty does not increase when using it to make non-let heal attacks."),

            new SpeciesRestrictedTalent("Benzite", "Competitive Drive", "You do your best work alone and without assistance. When you succeed on a Reason, or Control Task without another character assisting you, you gain an additional Momentum that must be spent on that Task."),
            new SpeciesRestrictedTalent("Benzite", "Thorough", "You work slowly but methodically, careful to avoid making mistakes. Whenever you roll one or more complications on a Science, or Engineering Task, roll1 challenge die. If an Effect is rolled, you cancel out one complication."),

            new SpeciesRestrictedTalent("Bolian", "Gregarious", "You selflessly support the actions of your fellow crew members. Whenever you assist another character with a Task outside of combat, the character you assisted gains one bonus Momentum if they succeed."),
            new SpeciesRestrictedTalent("Bolian", "Offer Advice", "You are happy to make suggestions for how to best execute a course of action and quick to work as part of the team. Whenever you spend the last Momentum in the group's Momentum pool, roll 1 challenge die when you transfer initiative. If you roll an Effect, add 1 Momentum back into the group's Momentum pool."),
            new SpeciesRestrictedTalent("Bolian", "Market Savvy", "You have learned the basics of economics and trade, possibly with a connection to the Bank of Bolias. Increase the Difficulty of all rolls in a Social Conflict made to persuade you by 2. This Difficulty increase is removed as soon as a fair and equitable deal is offered."),

            new SpeciesRestrictedTalent("Bynar", "Networked", "You are connected to either the Bynar master system or your ship's mainframe. Provided the computer is in communication range and there is no interference, that computer can assist you on Tasks where its Communication, Computer, or Sensor Systems would apply to the Task."),
            new SpeciesRestrictedTalent("Bynar", "Paired", "You are genetically paired to another Bynar on the crew. This Bynar is a support character but does not count against your Crew Support for the mission. Once per scene, you can use their Disciplines on a Reason or Insight roll in place of your own."),
            new SpeciesRestrictedTalent("Bynar", "Un-Paired", "Your genetic pair is dead or is otherwise unavailable, and can't be replaced during your current mission or deployment. Mentally alone, you are compulsively driven to aid others. When you assist another character with a Task, one d20 related to that Task can be re-rolled."),
        
            new SpeciesRestrictedTalent("Caitian", "Cat-Like Reflexes", "During the first round of any combat, if you have not acted, you can take a Minor Action on another character's turn by spending one Momentum (immediate)."),
            new SpeciesRestrictedTalent("Caitian", "Coordinated Hunt", "You have skill at felling large prey with a pack. Whenever you assist another character making a Melee Attack, the character you assisted gains 2 challenge die if that attack hits."),
            new SpeciesRestrictedTalent("Caitian", "Keen Hearing", "Whenever you attempt to detect faint sounds, listen in on conversations, distinguish tones, recognize voices, notice patterns or background noises in recordings, or other tasks that involve your sense of hearing you gain a bonus d20."),
        
            new SpeciesRestrictedTalent("Cardassian", "Cultured", "You enjoy a good argument, be it for five minutes or an entire half-hour. When engaged in Social Conflict, and given an opportunity to speak at length on a subject, you may re-roll your dice pool if you purchases any bonus d20s."),
            new SpeciesRestrictedTalent("Cardassian", "Loyal And Disciplined", "You are quick to obey orders and follow their commands. Whenever you receive assistance from a superior on a Task, you may re-roll a single d20."),
            new SpeciesRestrictedTalent("Cardassian", "Ruthless", "You are merciless and have few compunctions about shooting an enemy in the back. You may re-roll any number of d20s in your dice pool when making an attack against an enemy that is defenseless, is not aware of your presence, or is unprepared for an attack."),    
        
            new SpeciesRestrictedTalent("Changeling", "Form Weapon", "You can transform a digit or an entire limb into a simple weapon, such as a whip or dagger. The chosen body part becomes a melee weapon with the following profile: with 1 challenge die, Vicious 1, Size 1 H. You can choose to add either the Deadly or non-lethal quality."),
            new SpeciesRestrictedTalent("Changeling", "Shapeshifting", "You can transform into other objects and creatures at will. When you change into another form you gain an additional Trait related to your new form, such as its Species Trait. During combat and other periods of stress, rapidly transforming necessitates skill and focus, requiring a Control + Medicine Task with a Difficulty of 0. On a success, you transform into a simple inanimate object. You can choose to spend 1 Momentum to instead become a complex object with many moving parts or an animal, or spend 2 Momentum to become a generic humanoid. With the Gamemaster's permission, you can choose to spend 3 Momentum to copy the form of a particular individual."),

            new SpeciesRestrictedTalent("Deltan", "Analgesic Touch", "You can carefully release your pheromones to induce a surge of endorphins, relieving physical pain. After a successful First Aid Task, you can permit the character to ignore the injury for the remainder of the scene, allowing them to act normally. A character can benefit from this only once per mission."),
            new SpeciesRestrictedTalent("Deltan", "Induce Agony", "You have learned to use your pheromones offensively, triggering random pain impulses. Your touch counts as a melee weapon with 1 challenge die , Vicious 1, Size 1 H, and the Nonlethal quality. You may use Command or Medicine instead of Security when attempting an induce agony Attack, and may increase damage by your Command or Medicine Discipline instead of Security."),
            new SpeciesRestrictedTalent("Deltan", "Potent Pheromones", "Whenever attempting a Task to negotiate, persuade, or seduce a humanoid creature that could be physically attracted to you in and is Close range, you add a bonus d20 to the roll."),
            
            new SpeciesRestrictedTalent("Edosian", "Ancillary Appendages", "Your balance is exceptional, owing to your extra leg, making you much more stable. You reduce the cost to resist being knocked prone by the Knockdown damage effect by two, to a minimum of O. If the cost would be reduced below 0, you instead gain one Momentum."),
            new SpeciesRestrictedTalent("Edosian", "Multitasking", "You are skilled at using all three of your hands simultaneously. On your turn, you can take an additional Minor Action, which can only be used for the Draw Item, Interact, or Aim Minor Actions."),
            new SpeciesRestrictedTalent("Edosian", "Swift Movement", "Your extra leg allow you to dash with surprising speed. When you succeed on a Sprint Task, you move two zone (to any point in Long range) rather than one."),

            new SpeciesRestrictedTalent("Efrosian", "Intuit Direction", "You have an innate ability to orientate yourself, owing to your people's need to navigate across the glaciers and tundra deserts of your homeworld. When you attempt a Task to plot a course, find your position, navigate overland, or determine which direction you're facing, you may re-roll one d20."),
            new SpeciesRestrictedTalent("Efrosian", "Recall Information", "You've learned to apply the techniques needed to memorize the oral history of your people to other types of facts. When you succeed at a Task using Insight or Reason, you gain one bonus Momentum, which may only be used for the Obtain Information Momentum Spend."),
            new SpeciesRestrictedTalent("Efrosian", "Team Oriented", "You are focused on the success of the group and work well with colleagues. When you assist another character, you may buy 1 additional d20 with either Momentum or Threat."),
        
            new SpeciesRestrictedTalent("El-Aurian", "Listener", "You know how to subtly use your empathic skills to discern not only what is being said but also what is being unsaid. This allows you to tell someone exactly what they needs to hear. When you attempt a Task to advise or convince someone into taking or refraining from a specific course of action, you may add a bonus d20."),
            new SpeciesRestrictedTalent("El-Aurian", "Wisdom of Years", "You have many decades if not several centuries of experiences to draw upon. You may have one additional Value and Focus, reflecting the insights you received from your long life."),

            new SpeciesRestrictedTalent("Ferengi", "Flexible Morality", "Your values shift depending on the expectations of profits and needs of business deals. Once per mission, you can change a Value for that mission. The replaced Value is restored at the end of the mission, and you can't spend Determination using Value in the same scene where you change it."),
            new SpeciesRestrictedTalent("Ferengi", "Hoarding Impulse", "You have a strong impulse to collect information and objects of value, if only valuable to you. When you save Momentum, you can save it to a personal Momentum pool, that function's like the group's Momentum pool, except only you can use its Momentum. This pool can't contain more than 2 points of Momentum. However, you can't save Momentum to the group's Momentum pool until you add at least one Momentum to your pool from that Task unless your personal pool is already full."),
            new SpeciesRestrictedTalent("Ferengi", "Seek Advantage", "You are continually looking for ways to advance your agenda and personal goals. When you spend a point of Determination for a bonus d20, you can also re-roll a d20."),

            new SpeciesRestrictedTalent("Gorn", "Brute Force", "You are strong and can hit with surprising force. You add the Vicious 1 effect to your Unarmed Strike."),
            new SpeciesRestrictedTalent("Gorn", "Deliberate Strike", "Gorn are patient and deliberate in there actions. Whenever you use the Ready Task to ready an attack, you may re-roll one d20."),
            new SpeciesRestrictedTalent("Gorn", "Thick Hide", "Your thick hide defend you against lesser wounds. Your Resistance is increased by+ 1 against all non-lethal attacks. Furthermore, when you succeed at the Recover Task, you regain 3 Stress per Momentum spent rather than 2."),

            new SpeciesRestrictedTalent("Horta", "Acidic Touch", "You can use your natural acidic offensively. Your touch counts as a melee weapon with 3 challenge die, Intense, Size 1 H. When you use your acid touch, add 2 to the Threat pool."),
            new SpeciesRestrictedTalent("Horta", "Hardened Biology", "Your cilia act independently and can continue to move even if youhave been severely hurt. When you have only 1 injury, you can continue to take the Movement Minor Action."),
            new SpeciesRestrictedTalent("Horta", "Rocky Exterior", "Your hard stony carapace makes you impervious to minor damage. Your Resistance is increased by +2 against energy attacks."),
        
            new SpeciesRestrictedTalent("Kelpien", "Advantageous Reversal", "Adversity has taught you how to not only work around hazards, but how to turn them to your advantage. On your turn, you can spend 1 Determination to reduce the Threat pool by 1 and add 1 to the group's Momentum pool."),
            new SpeciesRestrictedTalent("Kelpien", "Swift Movement", "You have the speed of a hunted prey animal. When you succeed on a Sprint Task, you moves two zone (to any point in Long range) rather than one."),
            new SpeciesRestrictedTalent("Kelpien", "Threat Management", "You are skilled at avoiding danger and and minimizing problems. When you buying one or more d20s by adding to Threat, the cost is reduced by 1 (to a minimum of 1 )."),

            new SpeciesRestrictedTalent("Klingon", "Brak'Lul ", "You possess a number of secondary organs allowing you to survive grievous wounds. When you suffer a non-lethal injury, on you turn you have a chance to recover without assistance. This is Difficulty 2 Fitness+ Command Task, which you can attempt even when you are Injured, removing the Injury on a success. Furthermore, when another character tries to heal you of an Injury or a related Complication, you can add a bonus d20 to their dice pool."),
            new SpeciesRestrictedTalent("Klingon", "Honour Bound", "Your personal honour and that of your house is more important to you than your life. Whenever you attempt a Task to resist being coerced into breaking an oath, betraying a superior, or otherwise acting dishonorably, you reduce the Difficulty by 1."),
            new SpeciesRestrictedTalent("Klingon", "Warrior Spirit", "You have been trained in combat since a young age. When you attempt a Melee attack and purchase one or more additional dice with Momentum or Threat, you may re-roll any number of d20s."),
        
            new SpeciesRestrictedTalent("Nausicaan", "Natural Bully", "When you attempt a Task to intimidate or frighten a creature you consider weaker than you and buy one or more d20s by adding to Threat, you ignore any complication."),
           
            new SpeciesRestrictedTalent("Orion", "Assess Odds", "You know when and where to apply your efforts for maximum payoff, and how to best utilize your skills. Pick either Insight or Presence; when you attempt at a Task using that Attribute, if you don't have an applicable Focus, each die that rolls a 2 scores two successes."),
            new SpeciesRestrictedTalent("Orion", "Potent Pheromones", "Whenever attempting a Task to negotiate, persuade, or seduce a humanoid creature that could be physically attracted to you and is in Close range, you add a bonus d20to the roll."),
            new SpeciesRestrictedTalent("Orion", "Subservient", "Used to supplicating yourself to a higher authority (typically a female Orion slave master) you will not willingly act against your superiors. Whenever you attempt a Task to resist being coerced into disobeying an order, betraying your allies, or otherwise acting against a directive you reduce the Difficulty by 1."),

            new SpeciesRestrictedTalent("Pakled", "Cobble Together", "You can build things out of parts others would call trash. When you would fail at a Task to perform repairs or build a device, you can choose to gain 2 additional successes by creating a Complication that cannot be removed until the Task is repeated."),
            new SpeciesRestrictedTalent("Pakled", "Devious", "When you attempt an opposed Task to deceive a creature of hide your intentions, you always have at least 1 success, and win ties even if you are not the active character."),

            new SpeciesRestrictedTalent("Romulan", "Guile And Cunning", "When attempting to remain hidden, go unnoticed, or pass as a Vulcan you may spend one Momentum to increase the Difficulty of enemy Tasks to detect you by one."),
            new SpeciesRestrictedTalent("Romulan", "Swift Response", "Years of paranoia have encouraged you to always have a back-up plan and also heightened your responses, enabling you to swiftly enact contingencies. Your Momentum cost for taking an additional Minor Action is always 1."),
            new SpeciesRestrictedTalent("Romulan", "Wary", "You are conditioned to espionage and treachery, expecting betrayal at all times. Whenever you attempt a Task to notice or detect an enemy or hazard, you may re-roll one d20."),
        
            new SpeciesRestrictedTalent("Saurian", "Rapid Recovery", "You heal quickly from lesser wounds and are quick to catch your breath. When you attempt the Recover Task, add a bonus d20 to the task."),
            new SpeciesRestrictedTalent("Saurian", "Resilient Frame", "Your scaly skin makes you particularly durable and hardy. Whenever you successfully Avoid an Injury, roll 1 challenge die. If an Effect is rolled, you immediately regain the ability to Avoid Injury."), 
            new SpeciesRestrictedTalent("Saurian", "Tenacious Will", "When driven by what you believe most, you stubbornly refuse to yield and strive to succeed at all costs. When you spend a point of Determination to attempt a second Task, you make re-roll a d20 if you have an applicable Focus or re-roll up to two d20s if you have no applicable Focus."),

            new SpeciesRestrictedTalent("Skorr", "Nimble Flying", "With a sudden flap of your wings you can bound quickly from place to place. When you take the Movement Minor Action, you can move through or out of an enemy's Reach, provided there is room to move over and around them."),
            new SpeciesRestrictedTalent("Skorr", "Swift Flight", "Your wings allow you to fly with speed and surprising grace. When you succeed on a Sprint Task, you generate 1 bonus Momentum."),    
        }
    };

}

}