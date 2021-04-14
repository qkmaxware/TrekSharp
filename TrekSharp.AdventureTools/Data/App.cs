using System.Collections.Generic;

namespace TrekSharp.AdventureTools {

public class TokenCollection {
    public int Momentum {get; set;}
    public int Threat {get; set;}
}

public class Mission {
    public string MissionTitle {get; set;}
    public string MissionAuthor {get; set;}
    public string Synopsis {get; set;}
    public string Conclusion {get; set;}

    public List<Act> Acts {get; set;} = new List<Act>();
}

public class Act {
    public string Title {get; set;}
    public string Description {get; set;}
    public List<string> LinkedNPCs {get; set;} = new List<string>();
    public List<string> LinkedSupports {get; set;} = new List<string>();
    public List<string> LinkedShips {get; set;} = new List<string>();
}

public class AppData {

    public Mission Mission {get; set;} = new Mission();
    public TokenCollection Tokens {get; set;} = new TokenCollection();
    public List<PlayerVessel> Ships {get; set;} = new List<PlayerVessel>();
    public List<Vessel> NPCShips {get; set;} = new List<Vessel>();
    public List<PlayerCharacter> Party {get; set;} = new List<PlayerCharacter>();
    public List<SupportCharacter> Supports {get; set;} = new List<SupportCharacter>();
    public List<NpcCharacter> NPCs {get; set;} = new List<NpcCharacter>();

    public List<ExtendedTask> Tasks {get; set;} = new List<ExtendedTask>();

    public void Overwrite(AppData @new) {
        this.Mission = @new.Mission ?? new Mission();
        this.Tokens = @new.Tokens ?? new TokenCollection();
        this.Ships = @new.Ships ?? new List<PlayerVessel>();
        this.Party = @new.Party ?? new List<PlayerCharacter>();
        this.Supports = @new.Supports ?? new List<SupportCharacter>();
        this.NPCs = @new.NPCs ?? new List<NpcCharacter>();
        this.NPCShips = @new.NPCShips ?? new List<Vessel>();
        this.Tasks = @new.Tasks ?? new List<ExtendedTask>();
    }
}

}