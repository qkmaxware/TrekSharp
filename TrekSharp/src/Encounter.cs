using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {

public class Encounter {
    public string Title {get; set;}
    public string GUID {get; set;} = System.Guid.NewGuid().ToString();
    public List<Vessel> AlliedShips  {get; set;} = new List<Vessel>();
    public List<Vessel> EnemyShips  {get; set;} = new List<Vessel>();

    public IEnumerable<Vessel> AllShips => AlliedShips.Concat(EnemyShips);

    public List<NpcCharacter> AlliedInfrantry  {get; set;} = new List<NpcCharacter>();
    public List<NpcCharacter> EnemyInfantry  {get; set;} = new List<NpcCharacter>();

    public IEnumerable<NpcCharacter> AllCharacters => AlliedInfrantry.Concat(EnemyInfantry);

    public float AlliedSpaceStrength => AlliedShips.Select(ship => ship.Scale).Sum();
    public float EnemySpaceStrength => EnemyShips.Select(ship => ship.Scale).Sum();
    public float AlliedInfantryStrength => AlliedInfrantry.Select(ship => ship.PlayerDifficulty).Sum();
    public float EnemyInfantryStrength => EnemyInfantry.Select(ship => ship.PlayerDifficulty).Sum();

    public override string ToString() {
        return Title;
    }
    
}

}