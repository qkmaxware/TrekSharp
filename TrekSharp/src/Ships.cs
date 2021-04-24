using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {

public class SystemReference {
    public string Name => Index switch {
        0 => "Comms",
        1 => "Engines",
        2 => "Structure",
        3 => "Computers",
        4 => "Sensors",
        5 => "Weapons",
        _ => null
    };
    public int Index {get; private set;}
    public int Value {
        get => source[Index];
        set => source[Index] = value;
    }
    private Systems source;
    public SystemReference(Systems source, int index) {
        this.source = source;
        this.Index = index;
    }
}

public class SystemsEnumerator : IEnumerable<SystemReference> {
    private Systems Value;
    public SystemsEnumerator(Systems attr) {
        this.Value = attr;
    }

    public IEnumerator<SystemReference> GetEnumerator() {
        yield return new SystemReference(Value, 0);
        yield return new SystemReference(Value, 1);
        yield return new SystemReference(Value, 2);
        yield return new SystemReference(Value, 3);
        yield return new SystemReference(Value, 4);
        yield return new SystemReference(Value, 5);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
}

public class Systems {
    public int Comms {get; set;}
    public SystemReference CommsReference => new SystemReference(this, 0);
    public int Engines {get; set;}
    public SystemReference EnginesReference => new SystemReference(this, 1);
    public int Structure {get; set;}
    public SystemReference StructureReference => new SystemReference(this, 2);
    public int Computers {get; set;}
    public SystemReference ComputersReference => new SystemReference(this, 3);
    public int Sensors {get; set;}
    public SystemReference SensorsReference => new SystemReference(this, 4);
    public int Weapons {get; set;}
    public SystemReference WeaponsReference => new SystemReference(this, 5);

    public int this[int index] {
        get {
            return index switch {
                0 => this.Comms,
                1 => this.Engines,
                2 => this.Structure,
                3 => this.Computers,
                4 => this.Sensors,
                5 => this.Weapons,
                _ => 0
            };
        }
        set {
            switch(index) {
                case 0: this.Comms = value; break;
                case 1: this.Engines = value; break;
                case 2: this.Structure = value; break;
                case 3: this.Computers = value; break;
                case 4: this.Sensors = value; break;
                case 5: this.Weapons = value; break;
            };
        }
    }

    public void Add(Systems other) {
        this[0] += other[0];
        this[1] += other[1];
        this[2] += other[2];
        this[3] += other[3];
        this[4] += other[4];
        this[5] += other[5];
    }

    public SystemsEnumerator Enumerate() {
        return new SystemsEnumerator(this);
    }

    public Systems() {}
    public Systems(int value) {
        this[0] = value;
        this[1] = value;
        this[2] = value;
        this[3] = value;
        this[4] = value;
        this[5] = value;
    }
}

public class StarshipWeapon : IResearchableEntity {
    public string Name {get; set;}
}

public class Spaceframe : IResearchableEntity {
    public string Name {get; set;}
    public int Scale {get; set;}
    public List<string> Weapons {get; set;}
    public List<string> StartingTalents {get; set;}
    public System.DateTime DesignDate {get; set;}
    public Systems Systems {get; set;}
    public Disciplines Departments {get; set;}
}

public class Vessel {
    public string Name {get; set;}
    public Spaceframe Frame {get; set;}

    public Systems Systems {get; set;}
    public Disciplines Departments {get; set;}
    public List<ShipTalent> Talents {get; set;}
    public int Scale => Frame.Scale;
    public int Resistance => Frame.Scale + (Talents == null ? 0 : Talents.Select(talent => talent.ResistanceModifier).Sum());
    public int UsedShields;
    public int ShieldsRemaining {
        get => Math.Max(0, Shields - UsedShields);
        set {
            value = Math.Max(0, Math.Min(value, Shields));
            this.UsedShields = Shields - value;
        }
    }
    public int Shields => Systems.Structure + (Talents == null ? 0 : Talents.Select(talent => talent.ShieldModifier).Sum());
    public int UsedPower;
    public int PowerRemaining {
        get => Math.Max(0, Power - UsedPower);
        set {
            value = Math.Max(0, Math.Min(value, Power));
            this.UsedPower = Power - value;
        }
    }
    public int Power => Systems.Engines + (Talents == null ? 0 : Talents.Select(talent => talent.PowerModifier).Sum());
    public int CrewSupport => Frame.Scale;
    public IEnumerable<string> Weapons => Frame.Weapons;

    public Vessel() {}

    public Vessel (string name, Spaceframe frame) {
        this.Name = name;
        this.Frame = frame;
    }
}

public class PlayerVessel : Vessel {
    public string Registry {get; set;}
    public MissionProfile MissionProfile {get; set;}
    public PlayerVessel() {}
    public PlayerVessel (string name, string registry, Spaceframe frame) : base(name, frame) {
        this.Registry = registry;
    }
}

}