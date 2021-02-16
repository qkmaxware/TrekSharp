namespace TrekSharp {
    
public class Environment {
    public string Name {get; private set;}
    public string Description {get; private set;}
    public Attributes AttributeSelectionMask {get; private set;}
    public Disciplines DisciplineSelectionMask {get; private set;}

    public Environment (string name, string description, Attributes amask, Disciplines dmask) {
        this.Name = name;
        this.AttributeSelectionMask = amask;
        this.DisciplineSelectionMask = dmask;
        this.Description = description;
    }

    public override string ToString() {
        return this.Name;
    }
}

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