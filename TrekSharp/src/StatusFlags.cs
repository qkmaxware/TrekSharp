using System.Collections.Generic;

namespace TrekSharp {

public class CustomFlag {
    public string Name {get; set;}
    public string Description {get; set;}
    public bool Toggled {get; set;}
}

public class StatusFlags {
    /// <summary>
    /// Character has suffered a lethal injury
    /// </summary>
    public bool Dying {get; set;}
    /// <summary>
    /// Character has suffered an injury
    /// </summary>
    public bool Incapacitated {get; set;}
    /// <summary>
    /// Character has been grappled
    /// </summary>
    public bool Grappled {get; set;}
    /// <summary>
    /// Knocked prone
    /// </summary>
    public bool Prone {get; set;}
    /// <summary>
    /// Fitness Tasks +1 Difficulty
    /// </summary>
    public bool Exhausted {get; set;}
    /// <summary>
    /// Reason Tasks +1 Difficulty
    /// </summary>
    public bool Dazed {get; set;}
    /// <summary>
    /// Control Tasks +1 Difficulty
    /// </summary>
    public bool Shaky {get; set;}
    /// <summary>
    /// Daring Tasks +1 Difficulty
    /// </summary>
    public bool Confused {get; set;}
    /// <summary>
    /// Daring Tasks +1 Difficulty
    /// </summary>
    public bool Frightened {get; set;}
    /// <summary>
    /// Insight Tasks +1 Difficulty
    /// </summary>
    public bool Blinded {get; set;}
    /// <summary>
    /// Insight Tasks +1 Difficulty
    /// </summary>
    public bool Deafened {get; set;}
    /// <summary>
    /// Increase difficulty to observe, locate or target
    /// </summary>
    public bool Invisible {get; set;}

    /// <summary>
    /// Custom flags that are defined by the Player or by the GM
    /// </summary>
    public List<CustomFlag> CustomFlags {get; set;} = new List<CustomFlag>();
}

}