using System.Collections.Generic;

namespace TrekSharp{
    
public class Item {
    public string Name {get; set;}
    public int? UsageDice {get; set;} = null;
    public List<string> Qualities {get; set;} = null;
}

}