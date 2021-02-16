using System.Collections.Generic;

namespace TrekSharp {

public class Rulebook {
    public List<CharacterTalent> Talents;
    public List<Environment> Environments;
    public List<Species> Species;
    public List<Upbringing> Upbringings;
    public List<CareerEvent> CareerEvents;
    public List<Spaceframe> Spaceframes;
    public List<Spaceframe> NpcSpaceframes;
    public List<MissionProfile> MissionProfiles;
    public List<ShipTalent> ShipTalents;
    public List<Item> Items;

    public Rulebook() : this(
        new List<Species> (), 
        new List<CharacterTalent> (), 
        new List<Environment> (), 
        new List<Upbringing> (), 
        new List<CareerEvent> (),
        new List<Spaceframe> (),
        new List<Spaceframe> (),
        new List<MissionProfile> (),
        new List<ShipTalent> (),
        new List<Item> ()
    ) {}

    public Rulebook (
        List<Species> species, 
        List<CharacterTalent> talents, 
        List<Environment> environments, 
        List<Upbringing> upbringing, 
        List<CareerEvent> events,
        List<Spaceframe> spaceframes,
        List<Spaceframe> npsSpaceframes,
        List<MissionProfile> profiles,
        List<ShipTalent> shipTalents,
        List<Item> items
    ) {
        this.Talents = talents;
        this.Species = species;
        this.Environments = environments;
        this.Upbringings = upbringing;
        this.CareerEvents = events;
        this.Spaceframes = spaceframes;
        this.NpcSpaceframes = npsSpaceframes;
        this.MissionProfiles = profiles;
        this.ShipTalents = shipTalents;
        this.Items = items;
    }

    public static Rulebook Core => TrekSharp.Rulebooks.CoreRulebook.Instance;
}

public class UnofficialRulebook : Rulebook {
    public UnofficialRulebook() : base() {}
    public UnofficialRulebook(
        List<Species> species, 
        List<CharacterTalent> talents, 
        List<Environment> environments, 
        List<Upbringing> upbringing, 
        List<CareerEvent> events,
        List<Spaceframe> spaceframes,
        List<Spaceframe> npcSpaceframes,
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
        npcSpaceframes,
        profiles,
        shipTalents,
        items
    ){}
}

}