namespace TrekSharp {
    
public interface IResearchableEntity {
    string Name {get;}
}

public static class ResearchableEntityExtentionMethods {
    public static string GetMemoryAlphaSearchLink(this IResearchableEntity entity) {
        return $"https://memory-alpha.fandom.com/wiki/Special:Search?scope=internal&query={System.Net.WebUtility.UrlEncode(entity.Name)}";
    }

    public static string GetGoogleSearchLink (this IResearchableEntity entity) {
        return $"http://www.google.com/search?q={System.Net.WebUtility.UrlEncode(entity.Name)}";
    }
}

}