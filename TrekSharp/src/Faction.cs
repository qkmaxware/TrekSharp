namespace TrekSharp {
    
public class Faction : IResearchableEntity {
    public string Name {get; set;}

    public Faction() {}
    public Faction (string name) {
        this.Name = name;
    }

    public static readonly Faction Starfleet = new Faction("Starfleet");
}

}