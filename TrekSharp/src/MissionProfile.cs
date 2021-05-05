using System.Collections.Generic;

namespace TrekSharp {

public class MissionProfile {

    public string Name {get; set;}
    public string Description {get; set;}
    public Systems Systems {get; set;}
    public Disciplines Departments {get; set;}
    public List<string> MissionProfileTalents {get; set;}

    public MissionProfile() {}

    public MissionProfile(string name, string desc, Systems systems, Disciplines depts, List<string> profileTalents) {
        this.Name = name;
        this.Description = desc;
        this.Systems = systems;
        this.Departments = depts;
        this.MissionProfileTalents = profileTalents;
    }

    public override string ToString() => Name;

}

}