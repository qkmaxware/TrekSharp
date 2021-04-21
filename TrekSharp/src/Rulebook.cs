using System.Collections.Generic;

namespace TrekSharp {

/// <summary>
/// Generic interface for all data that a source rulebook must provide
/// </summary>
public interface IRulebook {
    IEnumerable<CharacterTalent> Talents {get;}
    IEnumerable<Environment> Environments {get;}
    IEnumerable<Species> Species {get;}
    IEnumerable<Upbringing> Upbringings {get;}
    IEnumerable<CareerEvent> CareerEvents {get;}
    IEnumerable<Spaceframe> Spaceframes {get;}
    IEnumerable<Spaceframe> NpcSpaceframes {get;}
    IEnumerable<MissionProfile> MissionProfiles {get;}
    IEnumerable<ShipTalent> ShipTalents {get;}
    IEnumerable<Item> Items {get;}
}

/// <summary>
/// Base class for rulebook instances
/// </summary>
public class BaseRulebook : IRulebook {
    public static IRulebook Core => TrekSharp.Rulebooks.CoreRulebook.Instance;
    public IEnumerable<CharacterTalent> Talents {get; protected set;}
    public IEnumerable<Environment> Environments {get; protected set;}
    public IEnumerable<Species> Species {get; protected set;}
    public IEnumerable<Upbringing> Upbringings {get; protected set;}
    public IEnumerable<CareerEvent> CareerEvents {get; protected set;}
    public IEnumerable<Spaceframe> Spaceframes {get; protected set;}
    public IEnumerable<Spaceframe> NpcSpaceframes {get; protected set;}
    public IEnumerable<MissionProfile> MissionProfiles {get; protected set;}
    public IEnumerable<ShipTalent> ShipTalents {get; protected set;}
    public IEnumerable<Item> Items {get; protected set;}

    public BaseRulebook() : this(
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

    public BaseRulebook (
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
}

/// <summary>
/// Base class for user created source rulebooks
/// </summary>
public class UnofficialRulebook : BaseRulebook {
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