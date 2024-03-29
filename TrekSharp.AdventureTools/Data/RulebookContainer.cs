using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools.Data {

public class RulebookContainer {
    private Dictionary<string, IRulebook> rulebooks = new Dictionary<string, IRulebook> {
        // Default rulebooks, always here
        {"Core", Rulebooks.CoreRulebook.Instance},
        {"Command Division", Rulebooks.CommandDivision.Instance }, 
        {"Operations Division", Rulebooks.OperationsDivision.Instance },   
        {"Science Division", Rulebooks.ScienceDivision.Instance },   
        {"Alpha Quadrant", Rulebooks.QuadrantSupplementAlpha.Instance },
        {"Beta Quadrant", Rulebooks.QuadrantSupplementBeta.Instance }, 
        {"Delta Quadrant", Rulebooks.QuadrantSupplementDelta.Instance }, 
        {"Gamma Quadrant", Rulebooks.QuadrantSupplementGamma.Instance },    
        {"α Cannon Races", Rulebooks.MoreAlphaCannonRaces.Instance }   ,
        {"α Cannon Ships", Rulebooks.MoreAlphaCannonShips.Instance }   ,
    };
    private List<string> _protected = new List<string>() {
        "Core"
    };
    private List<string> _enabled = new List<string>();
    
    public IEnumerable<KeyValuePair<string,IRulebook>> AllRulebooks => rulebooks;
    public IEnumerable<IRulebook> EnabledRulebooks => AllRulebooks.Where(kv => IsRulebookEnabled(kv.Key)).Select(kv => kv.Value);

    public void AddRulebook(string name, IRulebook book) {
        this.rulebooks[name] = book;
    }

    public bool IsRulebookEnabled(string name) {
        return _protected.Contains(name) || _enabled.Contains(name);
    }
    public void UseRulebook(string name) {
        _enabled.Add(name);
    }
    public void DoNotUseRulebook(string name) {
        _enabled.Remove(name);
    }
    public void ToggleRulebook(string name) {
        if (IsRulebookEnabled(name)) {
            DoNotUseRulebook(name);
        } else {
            UseRulebook(name);
        }
    }
}

}