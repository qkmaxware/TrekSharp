namespace TrekSharp {

public class CustomSpecies : Species {
    public string Homeworld {get; set;}
    public string Description {get; set;}

    public CustomSpecies() : base(null, new Attributes(0)) {}
}

public class Species : IResearchableEntity {

    public string Name {get; set;}
    public Attributes AttributeModifiers {get; set;}

    public Species () {}
    public Species (string name, Attributes modifiers) {
        this.Name = name;
        this.AttributeModifiers = modifiers;
    }

    public override bool Equals(object obj) {
        if (obj is Species other) {
            return other.Name == this.Name;
        } else {
            return base.Equals(obj);
        }
    }

    public override int GetHashCode() {
        return this.Name.GetHashCode();
    }

    public override string ToString(){
        return this.Name;
    }
}

}