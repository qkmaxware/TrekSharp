using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools {

public class UserCreatedSpeciesRulebook : IRulebook {
    private AppData data;
    public UserCreatedSpeciesRulebook(AppData data) {
        this.data = data;
    }
    public IEnumerable<CharacterTalent> Talents => data?.Custom?.Species?.Talents?.Cast<CharacterTalent>() ?? Enumerable.Empty<CharacterTalent>();

    public IEnumerable<Environment> Environments => Enumerable.Empty<Environment>();

    public IEnumerable<Species> Species => data?.Custom?.Species?.Definitions?.Cast<Species>() ?? Enumerable.Empty<Species>();

    public IEnumerable<Upbringing> Upbringings => Enumerable.Empty<Upbringing>();

    public IEnumerable<CareerEvent> CareerEvents => Enumerable.Empty<CareerEvent>();

    public IEnumerable<Spaceframe> Spaceframes => Enumerable.Empty<Spaceframe>();

    public IEnumerable<Spaceframe> NpcSpaceframes => Enumerable.Empty<Spaceframe>();
    
    public IEnumerable<NpcCharacter> NpcCharacters => data?.Custom?.NpcCharacterTypes ?? Enumerable.Empty<NpcCharacter>();

    public IEnumerable<MissionProfile> MissionProfiles => Enumerable.Empty<MissionProfile>();

    public IEnumerable<ShipTalent> ShipTalents => Enumerable.Empty<ShipTalent>();

    public IEnumerable<Item> Items => data?.Custom?.Items ?? Enumerable.Empty<Item>();
}

}