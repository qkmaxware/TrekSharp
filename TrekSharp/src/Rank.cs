using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {

public class Rank {
    public string Title {get; set;}
    public int Order {get; set;}
    public Faction Faction {get; set;}

    public Rank() {}
    public Rank(Faction faction, int rankOrder, string title) {
        this.Faction = faction;
        this.Title = title;
        this.Order = rankOrder;
    }

    public static bool operator > (Rank a, Rank b) {
        return a.Faction == b.Faction && a.Order > b.Order;
    }

    public static bool operator < (Rank a, Rank b) {
        return a.Faction == b.Faction && a.Order < b.Order;
    }

    public override string ToString(){
        return this.Title;
    }

    public static readonly Rank Ensign = new Rank(Faction.Starfleet, 0, "Ensign");
    public static readonly Rank LieutenantJuniorGrade = new Rank(Faction.Starfleet, 1, "Lieutenant Junior Grade");
    public static readonly Rank Lieutenant = new Rank(Faction.Starfleet, 2, "Lieutenant");
    public static readonly Rank LieutenantCommander = new Rank(Faction.Starfleet, 3, "Lieutenant Commander");
    public static readonly Rank Commander = new Rank(Faction.Starfleet, 4, "Commander");
    public static readonly Rank Captain = new Rank(Faction.Starfleet, 5, "Captain");
    public static readonly Rank Commodore = new Rank(Faction.Starfleet, 6, "Commodore");
    public static readonly Rank RearAdmiral = new Rank(Faction.Starfleet, 7, "Rear Admiral");
    public static readonly Rank ViceAdmiral = new Rank(Faction.Starfleet, 8, "Vice Admiral");
    public static readonly Rank Admiral = new Rank(Faction.Starfleet, 9, "Admiral");
    public static readonly Rank FleetAdmiral = new Rank(Faction.Starfleet, 10, "Fleet Admiral");

}

}