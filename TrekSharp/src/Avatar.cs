using System.Drawing;

namespace TrekSharp {

public class Colour {
    public int Red {get; set;}
    public int Green {get; set;}
    public int Blue {get; set;}

    public static implicit operator Color (Colour c) {
        return Color.FromArgb(0, c.Red, c.Green, c.Blue);
    }
    public static implicit operator Colour (Color c) {
        return new Colour {
            Red = c.R,
            Green = c.G,
            Blue = c.B
        };
    }
}

public class Avatar {
    public string CustomNetworkImage {get; set;}

    public Colour SkinColour {get; set;} = Color.FromArgb(0, red: 255, green:219, blue:172);
    public string Body {get; set;}
    public Colour EyeColour {get; set;}
    public string Eyes {get; set;}
    public Colour HairColour {get; set;}
    public string Hair {get; set;}
    public Colour BeardColour {get; set;}
    public string Beard {get; set;}
    public string Uniform {get; set;}
}

}