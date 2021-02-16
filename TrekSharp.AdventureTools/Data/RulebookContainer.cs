using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools.Data {

public class RulebookContainer {
    private Dictionary<string, Rulebook> rulebooks = new Dictionary<string, Rulebook> {
        {"Core", Rulebook.Core},
        {"Command Division", Rulebooks.CommandDivision.Instance }, 
        {"Operations Division", Rulebooks.OperationsDivision.Instance },   
        {"Science Division", Rulebooks.ScienceDivision.Instance },   
        {"More Races", Rulebooks.MoreRaces.Instance }   ,
    };
    private List<string> _protected = new List<string>() {
        "Core"
    };
    private List<string> _enabled = new List<string>();
    
    public IEnumerable<KeyValuePair<string,Rulebook>> AllRulebooks => rulebooks;
    public IEnumerable<Rulebook> EnabledRulebooks => AllRulebooks.Where(kv => IsRulebookEnabled(kv.Key)).Select(kv => kv.Value);

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