using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TrekSharp.AdventureTools {

public static class ColourExtentions {
    public static List<Color> SkinColours = new List<Color> {
        // Human
        Color.FromArgb(0, red:255, green:219, blue:172),
        Color.FromArgb(0, red:241, green:194, blue:125),
        Color.FromArgb(0, red:224, green:172, blue:105),
        Color.FromArgb(0, red:198, green:134, blue:66),
        Color.FromArgb(0, red:141, green:85, blue:36),
    };
    public static List<Color> BlueSkinColours = new List<Color> {
        Color.FromArgb(0, 167, 196, 242),
        Color.FromArgb(0, 93, 150, 240),
        Color.FromArgb(0, 44, 70, 112),
    };
    public static List<Color> GreenSkinColours = new List<Color> {
        Color.FromArgb(0, 98, 240, 124),
        Color.FromArgb(0, 46, 112, 58),
        Color.FromArgb(0, 80, 112, 86),
    };

    public static List<Color> EyeColours = new List<Color> {
        Color.FromArgb(0, red:99, green:78, blue:52),
        Color.FromArgb(0, red:46, green:83, blue:111),
        Color.FromArgb(0, red:61, green:103, blue:29),
    };

    public static List<Color> HairColours = new List<Color> {
        Color.FromArgb(0, red:170, green:136, blue:102),
        Color.FromArgb(0, red:222, green:190, blue:153),
        Color.FromArgb(0, red:36, green:28, blue:17),
        Color.FromArgb(0, red:79, green:26, blue:0),
        Color.FromArgb(0, red:154, green:51, blue:0),
    };

    public static string ToHex(this Color Colour) {
        return Colour.R.ToString("X2") + Colour.G.ToString("X2") + Colour.B.ToString("X2");
    }
    public static string ToHex(this Colour Colour) {
        return Colour.Red.ToString("X2") + Colour.Green.ToString("X2") + Colour.Blue.ToString("X2");
    }
}

}