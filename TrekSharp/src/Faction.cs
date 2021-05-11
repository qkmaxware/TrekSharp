namespace TrekSharp {
    
public class Faction : IResearchableEntity {
    public string Name {get; set;}

    public Faction() {}
    public Faction (string name) {
        this.Name = name;
    }

    public static readonly Faction Starfleet = new Faction("Starfleet");
    public static readonly Faction CardassianOrder = new Faction("Cardassian Order");
    public static readonly Faction RomulanEmpire = new Faction("Romulan Empire");
}

}