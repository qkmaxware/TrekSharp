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

    public static readonly Rank Cadet = new Rank(Faction.Starfleet, -12, "Cadet");
    public static readonly Rank Crewman = new Rank(Faction.Starfleet, -11, "Crewman");
    public static readonly Rank Yeoman = new Rank(Faction.Starfleet, -10, "Yeoman");
    public static readonly Rank Specialist3rdClass = new Rank(Faction.Starfleet, -9, "Specialist 3rd Class");
    public static readonly Rank Specialist2ndClass = new Rank(Faction.Starfleet, -8, "Specialist 2nd Class");
    public static readonly Rank Specialist1stClass = new Rank(Faction.Starfleet, -7, "Specialist 1st Class");
    public static readonly Rank PettyOfficer3rd = new Rank(Faction.Starfleet, -6, "Petty Officer 3rd Class");
    public static readonly Rank PettyOfficer2nd = new Rank(Faction.Starfleet, -5, "Petty Officer 2nd Class");
    public static readonly Rank PettyOfficer1st = new Rank(Faction.Starfleet, -4, "Petty Officer 1st Class");
    public static readonly Rank ChiefPettyOfficer = new Rank(Faction.Starfleet, -3, "Chief Petty Officer");
    public static readonly Rank SeniorChiefPettyOfficer = new Rank(Faction.Starfleet, -2, "Senior Chief Petty Officer");
    public static readonly Rank MasterChief = new Rank(Faction.Starfleet, -1, "Master Chief Petty Officer");

    public static IEnumerable<Rank> EnlistedRanks {
        get {
            yield return Crewman;
            yield return Yeoman;
            yield return Specialist3rdClass;
            yield return Specialist2ndClass;
            yield return Specialist1stClass;
            yield return PettyOfficer3rd;
            yield return PettyOfficer2nd;
            yield return PettyOfficer1st;
            yield return ChiefPettyOfficer;
            yield return SeniorChiefPettyOfficer;
            yield return MasterChief;

        }
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

    public static IEnumerable<Rank> CommissionedRanks {
        get {
            yield return Cadet;
            yield return Ensign;
            yield return LieutenantJuniorGrade;
            yield return Lieutenant;
            yield return LieutenantCommander;
            yield return Commander;
            yield return Captain;
            yield return Commodore;
            yield return RearAdmiral;
            yield return ViceAdmiral;
            yield return Admiral;
            yield return FleetAdmiral;
        }
    }

    public static IEnumerable<Rank> AllStarfleetRanks => EnlistedRanks.Concat(CommissionedRanks);

    public static readonly Rank Gil = new Rank(Faction.CardassianOrder, 0, "Gil");
    public static readonly Rank Glinn = new Rank(Faction.CardassianOrder, 2, "Glinn");
    public static readonly Rank Dalin = new Rank(Faction.CardassianOrder, 3, "Dalin");
    public static readonly Rank Dal = new Rank(Faction.CardassianOrder, 4, "Dal");
    public static readonly Rank Gul = new Rank(Faction.CardassianOrder, 5, "Gul");
    public static readonly Rank Legate = new Rank(Faction.CardassianOrder, 9, "Legate");
}

}