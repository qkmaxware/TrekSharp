using System.Collections.Generic;

namespace TrekSharp.AdventureTools {

public class TokenCollection {
    public int Momentum {get; set;}
    public int Threat {get; set;}
}

public class UserCustomSpecies {
    public List<CustomSpecies> Definitions {get; set;}
    public List<SpeciesRestrictedTalent> Talents {get; set;}

    public UserCustomSpecies() {
        Definitions = new List<CustomSpecies>();
        Talents = new List<SpeciesRestrictedTalent>();
    }
}

public class UserCustomData {
    public UserCustomSpecies Species {get; set;}
    public List<NpcCharacter> NpcCharacterTypes {get; set;}
    public List<Item> Items {get; set;}
    public List<Spaceframe> Spaceframes {get; set;}

    public UserCustomData() {
        Species = new UserCustomSpecies();
        NpcCharacterTypes = new List<NpcCharacter>();
        Items = new List<Item>();
        Spaceframes = new List<Spaceframe>();
    }
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
    public List<string> LinkedEncounters {get; set;} = new List<string>();
}

public static class View {
    public static readonly bool GM = true;
    public static readonly bool Player = false;
}

public class AppData {
    public bool IsGm = View.Player;

    public Mission Mission {get; set;} = new Mission();
    public TokenCollection Tokens {get; set;} = new TokenCollection();
    public List<PlayerVessel> Ships {get; set;} = new List<PlayerVessel>();
    public List<PlayerCharacter> Party {get; set;} = new List<PlayerCharacter>();
    public List<SupportCharacter> Supports {get; set;} = new List<SupportCharacter>();
    public List<Encounter> Encounters {get; set;} = new List<Encounter>();
    public List<ExtendedTask> Tasks {get; set;} = new List<ExtendedTask>();

    public UserCustomData Custom {get; set;} = new UserCustomData();

    public Logbook Logs {get; set;} = new Logbook();

    public void Overwrite(AppData @new) {
        this.IsGm = @new.IsGm;
        this.Mission = @new.Mission ?? new Mission();
        this.Tokens = @new.Tokens ?? new TokenCollection();
        this.Ships = @new.Ships ?? new List<PlayerVessel>();
        this.Party = @new.Party ?? new List<PlayerCharacter>();
        this.Supports = @new.Supports ?? new List<SupportCharacter>();
        this.Encounters = @new.Encounters ?? new List<Encounter>();
        this.Tasks = @new.Tasks ?? new List<ExtendedTask>();
        this.Custom = @new.Custom ?? new UserCustomData();
        this.Logs = @new.Logs ?? new Logbook();
        if (this.Logs.Entries == null) {
            this.Logs = new Logbook();
        }
    }
}

}