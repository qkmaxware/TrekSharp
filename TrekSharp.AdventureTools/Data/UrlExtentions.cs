using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.AdventureTools {

public static class UrlExtentions {
    public static string GetShipImageUrl(this Vessel Ship) {
        var name = Ship.Frame.Name.Replace(" ", string.Empty);
        return $"assets/artwork/ships/{name}.png";
    }

    public static string GetSpeciesImageUrl(this Species Species) {
        var name = Species.Name.Replace(" ", string.Empty);
        return $"assets/artwork/species/{name}.png";
    }
}

}