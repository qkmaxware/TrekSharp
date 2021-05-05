namespace TrekSharp {

public class ShipTalent {
    public string Name {get; set;}
    public string Description {get; set;}

    public int ResistanceModifier {get; set;} = 0;
    public int ShieldModifier {get; set;} = 0;
    public int PowerModifier {get; set;} = 0;

    public ShipTalent() {}

    public ShipTalent(string name, string desc) {
        this.Name = name;
        this.Description = desc;
        
    }

    public virtual bool CanBeUsedBy(PlayerVessel ship) {
        return true;
    }

    public override string ToString() => Name;
}

public class DateLimitedTalent : ShipTalent {
    public System.DateTime date {get; set;}

    public DateLimitedTalent() {}
    public DateLimitedTalent(System.DateTime date, string name, string desc) : base(name, desc) {
        this.date = date;
    }
    public override bool CanBeUsedBy(PlayerVessel ship) {
        return date <= ship.Frame.DesignDate;
    }
}

public class DepartmentLimitedTalent : ShipTalent {
    public Disciplines minDepartments {get; set;}
    public DepartmentLimitedTalent() {}
    public DepartmentLimitedTalent(Disciplines mins, string name, string desc) : base (name, desc) {
        this.minDepartments = mins;
    }
    public override bool CanBeUsedBy(PlayerVessel ship) {
        for (var i = 0; i < 6; i++) {
            if (ship.Departments[i] < minDepartments[i])
                return false;
        }
        return true;
    }
}

public class SpaceframeLimitedTalent : ShipTalent {
    public string frame {get; set;}
    public SpaceframeLimitedTalent() {}
    public SpaceframeLimitedTalent(Spaceframe frame, string name, string desc) : base (name, desc) {
        this.frame = frame.Name;
    }
    public SpaceframeLimitedTalent(string frame, string name, string desc) : base (name, desc) {
        this.frame = frame;
    }
    public override bool CanBeUsedBy(PlayerVessel ship) {
        return ship.Frame.Name == frame;
    }
}

}