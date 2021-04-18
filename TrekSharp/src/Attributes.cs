using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {
    
public class AttributeReference {
    public string Name => Index switch {
        0 => "Control",
        1 => "Daring",
        2 => "Fitness",
        3 => "Insight",
        4 => "Presence",
        5 => "Reason",
        _ => null
    };
    public int Index {get; private set;}
    public int Value {
        get => source[Index];
        set => source[Index] = value;
    }
    private Attributes source;
    public AttributeReference(Attributes source, int index) {
        this.source = source;
        this.Index = index;
    }
}

public class AttributeEnumerator : IEnumerable<AttributeReference> {
    private Attributes Value;
    public AttributeEnumerator(Attributes attr) {
        this.Value = attr;
    }

    public IEnumerator<AttributeReference> GetEnumerator() {
        yield return Value.ControlReference;
        yield return Value.DaringReference;
        yield return Value.FitnessReference;
        yield return Value.InsightReference;
        yield return Value.PresenceReference;
        yield return Value.ReasonReference;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
}

public class Attributes {
    public int Control {get; set;}
    public AttributeReference ControlReference => new AttributeReference(this, 0);
    public int Daring {get; set;} 
    public AttributeReference DaringReference => new AttributeReference(this, 1);
    public int Fitness  {get; set;}
    public AttributeReference FitnessReference => new AttributeReference(this, 2);
    public int Insight {get; set;}
    public AttributeReference InsightReference => new AttributeReference(this, 3);
    public int Presence {get; set;}
    public AttributeReference PresenceReference => new AttributeReference(this, 4);
    public int Reason {get; set;}
    public AttributeReference ReasonReference => new AttributeReference(this, 5);

    public int this[int index] {
        get {
            return index switch {
                0 => this.Control,
                1 => this.Daring,
                2 => this.Fitness,
                3 => this.Insight,
                4 => this.Presence,
                5 => this.Reason,
                _ => 0
            };
        }
        set {
            switch(index) {
                case 0: this.Control = value; break;
                case 1: this.Daring = value; break;
                case 2: this.Fitness = value; break;
                case 3: this.Insight = value; break;
                case 4: this.Presence = value; break;
                case 5: this.Reason = value; break;
            };
        }
    }

    public void Add (Attributes attributes) {
        if (attributes == null)
            return;

        this.Control += attributes.Control;
        this.Fitness += attributes.Fitness;
        this.Presence += attributes.Presence;
        this.Daring += attributes.Daring;
        this.Insight += attributes.Insight;
        this.Reason += attributes.Reason;
    }

    public void RandomlyIncrement (Attributes mask) {
        var indices = new int[6] {0, 1, 2, 3, 4, 5};
        // Remove unmasked items
        System.Random random = new System.Random();
        indices = indices.Where(index => (mask[index] ^ 1) != 0).OrderBy(x => random.Next()).ToArray();

        if (indices.Length > 0) {
            this[indices[0]] += 1;
        }
    }

    public void RandomlyIncrement(int amount) {
        var indices = new int[6] {0, 1, 2, 3, 4, 5};
        System.Random random = new System.Random();
        indices = indices.OrderBy(x => random.Next()).ToArray();

        foreach (var i in indices.Take(amount)) {
            this[i] += 1;
        }
    }

    public AttributeEnumerator Enumerate() {
        return new AttributeEnumerator(this);
    }

    public Attributes () : this(0) {

    }

    public Attributes (int values) {
        this[0] = values;
        this[1] = values;
        this[2] = values;
        this[3] = values;
        this[4] = values;
        this[5] = values;
    }
}

}