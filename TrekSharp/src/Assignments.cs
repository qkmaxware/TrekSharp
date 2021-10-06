using System;
using System.Linq;
using System.Collections.Generic;

namespace TrekSharp {

public class Assignment {
    public string Name {get; set;}
    public string Description {get; set;}
    public Assignment(string name, string desc = null) {
        this.Name = name;
        this.Description = desc;
    }
}

public static class Assignments {
    private static Dictionary<string, List<Assignment>> byDepartment = new Dictionary<string, List<Assignment>> {
        {"Command", new List<Assignment> {
            new Assignment("Commanding Officer", "The captain. Even if the commanding officer does not hold the rank of captain, they will be referred to as captain by their subordinates. Every ship must have a commanding officer."),
            new Assignment("Executive Officer", "Second-in-Command. The executive officer is the captain’s chief advisor, and takes command in situations where the captain is unable to. If a ship does not have a dedicated executive officer, an officer in another role should be noted as second-in-command, but they will not gain the benefits of this role."),
            new Assignment("Second Officer", "At times the XO must assume command of a Starship or base, when this happens the XO needs the help of another officer to assume his/her role as XO. The second officer is not a stand alone position, but a role given to the highest ranked and trusted officer aboard. When required the Second Officer will assume the role of XO, or if needed CO, and performs their duties as listed, for as long as required."),
            new Assignment("Intelligence Officer", "On all starships and starbases, a single individual amongst the command staff is designated the Intelligence Officer for that ship/base. Responsible for liaising with Starfleet Intelligence on a daily basis, the Intelligence Officer reads numerous classified reports as forwarded to them by SFI, and makes the decision on which reports are relevant to the crew to designate the command staff as having the need-to-know in order to view them. They are responsible for mission briefings involving information provided by Starfleet Intelligence, and act as a conduit from the command staff to SFI. The role of Intelligence Officer is considered an additional duty, in addition to a standard duty assignment."),
            new Assignment("Diplomatic Officer", "The Diplomatic Officer of each vessel/base must be familiar with a variety of areas: history, religion, politics, economics, and military, and understand how they affect potential threats. A wide range of operations can occur in response to these areas and threats. These operations occur within three general states of being: peacetime competition, conflict and war. This position is held jointly with another aboard the ship, and is considered a secondary duty."),
            new Assignment("Yeoman", "The Captain's Yeoman is for Petty Officers who wish to continue as administrators. It is technically a non-Mate position. Use of this position is completely at the discretion of the Commanding Officer. File work, and sensitive message transport are but two examples of the Yeoman's possible duties. The Yeoman assists the CO in day-to-day duties that the CO would otherwise not have the time to do."),
        }},
        {"Conn", new List<Assignment> {
            new Assignment("Flight Control Officer", "Not a typical senior staff role, some captains, particularly those operating in uncharted space, choose the most senior helmsman or flight control officer to serve as senior staff as well."),
            new Assignment("Shuttlebay Manager", "The Shuttlebay Manager is responsible for pre and post flight checks of all support craft involved in away missions."),
            new Assignment("Support Craft Pilot", "All small spacecrafts aboard a starship, starbase or a facility (Shuttles, Runabouts, Transports, Captain's yacht, Patrol Vessels etc.) but excluding fighters are flown by Support Craft Pilots. This is often the proving ground for pilots until they earn a berth on a starship as a Flight Control Officer."),
        }},
        {"Security", new List<Assignment> {
            new Assignment("Chief of Security", "The chief of security oversees the ship’s security department, and is responsible for ensuring the safety of the ship and crew during missions, for the investigation of disciplinary and criminal matters, and for overseeing the protection of important persons aboard the ship. On many ships, the chief of security operates from the Tactical station on the bridge."),
            new Assignment("Security Officer", "There are several Security Officers aboard each vessel. They are assigned to their duties by the Chief of Security and mostly guard sensitive areas, protect people, patrol, and handle other threats to the Federation."),
            new Assignment("Tactical Officer", "The Tactical Officers are the vessels gunmen. Very often Tactical Officers are also trained in ground combat and small unit tactics."),
            new Assignment("Master-at-Arms", "The Master-at-Arms trains and supervises Security crewmen in departmental operations, repairs, and protocols; maintains duty assignments for all Security personnel; supervises weapons locker access and firearm deployment; and is qualified to temporarily act as Chief of Security if so ordered. The Master-at-Arms reports to the Chief of Security."),
        }},
        {"Engineering", new List<Assignment> {
            new Assignment("Operations Manager", "The operations manager manages and oversees all technical operations aboard or involving the ship, normally from the Operations station on the Bridge, or in conjunction with the chief engineer (on smaller ships, one officer may fill both roles). This often entails taking on the duties of a science officer, if there is no dedicated science officer in the senior staff."),
            new Assignment("Chief Engineer", "The chief engineer is responsible for ensuring that the ship remains operational and functional, and commands the engineering department aboard the ship."),
        }},
        {"Science", new List<Assignment> {
            new Assignment("Science Officer", "A science officer is responsible for advising the commanding officer of all matters scientific, providing hypotheses in matters concerning the unknown. Not all ships have a dedicated science officer within the senior staff, often having the operations manager take on these duties."),
            new Assignment("Astrometrics Officer", "Specialized Science Officer in charge of the Astrometrics Section. This role entails the maintaining, correction and production of new stellar maps. Has close ties with the the Physicist and Stellar Cartographers."),
        }},
        {"Medical", new List<Assignment> {
            new Assignment("Ship's Counselor", "On larger ships and starbases, it’s common to have personnel dedicated to the mental soak. Some captains regard them as valuable advisors, as their training covers both culture and psychology, making them exceptionally good at reading the moods and intentions of others."),
            new Assignment("Morale Officer", "Responsible for keeping the morale of the crew high. Delivers regular reports on morale to the Executive Officer. The Morale Officer plans activities that will keep the crew's morale and demeanor up. If any crew member is having problems, the Morale Officer can assist that crew member."),
            new Assignment("Chief Medical Officer", "The chief medical officer, also known as ship’s surgeon, or ship’s doctor, is responsible for the health and wellbeing of the crew and other persons aboard the ship, and leads the ship’s medical department. A chief medical officer can order, and countermand the orders of, senior officers where matters of that officer’s health are concerned."),
            new Assignment("Surgeon", "Doctors of the federation still specialize and mostly, the Chief Medical Officer position is usually held by a general practitioner. While simple surgery is part of their training, some doctors on larger vessels and starbases prefer to have a surgeon on staff."),
            new Assignment("Head Nurse", "The Head Nurse oversees all the Nurses currently aboard, ensuring they are assigned to tasks and working as required in their area. Additionally the Head nurse performs the normal duties of the nurse, assisting the Duty Medical Officer in sickbay."),
            new Assignment("Nurse", "Nurses are trained in basic medical care, and are capable of dealing with less serious medical cases. In more serious matters the nurse assists the medical officer in the examination and administration of medical care, be this injecting required drugs, or simply assuring the injured party that they will be ok."),
        }},
        {"Communications", new List<Assignment> {
            new Assignment("Communications Officer", "More common in the earlier days of Starfleet, dedicated communications officers are typically skilled in linguistics and cryptography, and aided with advanced translation and decryption technologies, and thus valuable during encounters with both new cultures, and with hostile ones."),
        }},
    };

    public static IEnumerable<Assignment> EnumerateAll() {
        return byDepartment.Values.SelectMany(list => list);
    }

    public static IEnumerable<KeyValuePair<string, List<Assignment>>> EnumerateByDepartment() {
        return byDepartment;
    }
}

}