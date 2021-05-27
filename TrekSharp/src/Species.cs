using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {

public class CustomSpecies : Species {
    public string Homeworld {get; set;}
    public string Description {get; set;}

    public CustomSpecies() : base(null, new Attributes(0)) {}
}

public class Species : IResearchableEntity {

    public string Name {get; set;}
    public Attributes AttributeModifiers {get; set;}

    public List<Species> OtherHeritage {get; set;}

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

    public string ToFullString() {
        return this.Name + (OtherHeritage == null || OtherHeritage.Count < 1 ? string.Empty : ("/" + string.Join('/',this.OtherHeritage)));
    }

    /// <summary>
    /// Create a mixed species whose primary appearance and atttributes are derived from this species, but can have talents from other other constituent species.
    /// </summary>
    /// <param name="others">other species to mix with</param>
    /// <returns>new mixed species</returns>
    public Species DeriveMixedSpecies(IEnumerable<Species> others) {
        return new Species {
            Name = new string(this.Name),
            AttributeModifiers = this.AttributeModifiers == null ? null : new Attributes(this.AttributeModifiers),
            OtherHeritage = others?.ToList()
        };
    }
}

}