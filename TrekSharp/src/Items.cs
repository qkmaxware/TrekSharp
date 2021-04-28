using System.Collections.Generic;

namespace TrekSharp{
    
public enum ItemSize {
    OneHanded, TwoHanded, Worn
}

public class Item {
    public string Name {get; set;}
    public ItemSize Size {get; set;}
    public int? DamageDice {get; set;} = null;
    public List<string> Qualities {get; set;} = new List<string>();

    public override string ToString() {
        return Name;
    }
    
}

}