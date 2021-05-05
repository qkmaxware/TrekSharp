namespace TrekSharp {

public class CareerEvent {
    public string Name {get; private set;}
    public Attributes AttributeSelectionMask {get; private set;}
    public Disciplines DisciplineSelectionMask {get; private set;}

    public CareerEvent (string name, Attributes amask, Disciplines dmask) {
        this.Name = name;
        this.AttributeSelectionMask = amask;
        this.DisciplineSelectionMask = dmask;
    }

    public override string ToString() {
        return this.Name;
    }
}

}