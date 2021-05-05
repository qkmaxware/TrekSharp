using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.Generators {

public class FocusGenerator {
    private Dictionary<Disciplines, List<string>> focuses = new Dictionary<Disciplines, List<string>> {
        {new Disciplines { Command = 1 }, new List<string>{
            "Negotiation",
            "Athletics",
            "Endurance",
            "Music",
            "Observation",
            "Persuasion",
            "Composure",
            "Debate",
            "Diplomacy",
            "Starfleet Protocol",
            "Composure",
            "Inspiration",
            "Team Dynamics",
        }},
        {new Disciplines { Security = 1 }, new List<string>{
            "Athletics",
            "Endurance",
            "Music",
            "Observation",
            "Composure",
            "Espionage",
            "Interrogation",
            "Law",
            "Starfleet Protocol",
            "Composure",
            "Inspiration",
            "Team Dynamics",
            "Tactical Systems",
        }},
        {new Disciplines { Science = 1 }, new List<string>{
            "Geology",
            "Linguistics",
            "Finances",
            "Survey",
            "Athletics",
            "Endurance",
            "Astrophysics",
            "Astronavigation",
            "Botany",
            "Cultural Studies",
            "Music",
            "Observation",
            "Psychology",
            "Philosophy",
            "Starfleet Protocol",
            "Composure",
            "Inspiration",
            "Team Dynamics",
            "Warp Dynamics",
            "Quantum Mechanics",
        }},
        {new Disciplines { Conn = 1 }, new List<string>{
            "Athletics",
            "Ground Vehicles",
            "Endurance",
            "Navigation",
            "Music",
            "Observation",
            "Starfleet Protocol",
            "Composure",
            "Extra-Vehicular Activity",
            "Evasive Action",
            "Helm Operations",
            "Small Craft",
            "Starship Recognition",
            "Inspiration",
            "Team Dynamics",
        }},
        {new Disciplines { Engineering = 1 }, new List<string>{
            "Manufacturing",
            "Metallurgy",
            "Athletics",
            "Endurance",
            "Computers",
            "Cybernetics",
            "Holoprogramming",
            "Music",
            "Observation",
            "Starfleet Protocol",
            "Composure",
            "Inspiration",
            "Team Dynamics",
            "Power Systems",
            "Transporters",
            "Replicators",
        }},
        {new Disciplines { Medicine = 1 }, new List<string>{
            "Animal Handing",
            "Athletics",
            "Emergency Medicine",
            "Endurance",
            "Infectious Diseases",
            "Toxicology",
            "Music",
            "Observation",
            "Psychology",
            "Debate",
            "Starfleet Protocol",
            "Composure",
            "Inspiration",
            "Team Dynamics",
            "Trauma Surgery",
            "Virology",
            "Xenobiology",
            "Genetics",
        }}
    };

    public string GenerateFocusForDiscipline(Disciplines mask) {
        var lists = this.focuses.Where(kv => kv.Key.SharesDisciplinesWith(mask)).Select(kv => kv.Value).ToList();
        var list = lists.Random();
        var element = list.Random();
        return element;
    }
}

}