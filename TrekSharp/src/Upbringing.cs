namespace TrekSharp {
    
public class Upbringing {
    public string Name {get; private set;}
    public string Description {get; private set;}
    public Attributes AcceptAttributeModifier {get; private set;}
    public Attributes RejectAttributeModifier  {get; private set;}
    public Disciplines DisciplineMask {get; private set;}

    public Upbringing (string name, string desc, Attributes acceptMask, Attributes rejectMask, Disciplines dmask) {
        this.Name = name;
        this.Description = desc;
        this.AcceptAttributeModifier = acceptMask;
        this.RejectAttributeModifier = rejectMask;
        this.DisciplineMask = dmask;
    }

    public override string ToString() {
        return this.Name;
    }
}

}