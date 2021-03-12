using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrekSharp {

public class DisciplineReference {
    public string Name => Index switch {
        0 => "Command",
        1 => "Security",
        2 => "Science",
        3 => "Conn",
        4 => "Engineering",
        5 => "Medicine",
        _ => null
    };
    public int Index {get; private set;}
    public int Value {
        get => source[Index];
        set => source[Index] = value;
    }
    private Disciplines source;
    public DisciplineReference(Disciplines source, int index) {
        this.source = source;
        this.Index = index;
    }
}

public class DisciplineEnumerator : IEnumerable<DisciplineReference> {
    private Disciplines Value;
    public DisciplineEnumerator(Disciplines attr) {
        this.Value = attr;
    }

    public IEnumerator<DisciplineReference> GetEnumerator() {
        yield return new DisciplineReference(Value, 0);
        yield return new DisciplineReference(Value, 1);
        yield return new DisciplineReference(Value, 2);
        yield return new DisciplineReference(Value, 3);
        yield return new DisciplineReference(Value, 4);
        yield return new DisciplineReference(Value, 5);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
}

public class Disciplines {
    public int Command {get; set;}
    public int Security {get; set;}
    public int Science {get; set;}
    public int Conn {get; set;}
    public int Engineering {get; set;}
    public int Medicine {get; set;}

    public int this[int index] {
        get {
            return index switch {
                0 => this.Command,
                1 => this.Security,
                2 => this.Science,
                3 => this.Conn,
                4 => this.Engineering,
                5 => this.Medicine,
                _ => 0
            };
        }
        set {
            switch(index) {
                case 0: this.Command = value; break;
                case 1: this.Security = value; break;
                case 2: this.Science = value; break;
                case 3: this.Conn = value; break;
                case 4: this.Engineering = value; break;
                case 5: this.Medicine = value; break;
            };
        }
    }

    public void Add (Disciplines attributes) {
        if (attributes == null)
            return;

        this.Command += attributes.Command;
        this.Security += attributes.Security;
        this.Science += attributes.Science;
        this.Conn += attributes.Conn;
        this.Engineering += attributes.Engineering;
        this.Medicine += attributes.Medicine;
    }

    public void RandomlyIncrement (Disciplines mask) {
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

    public DisciplineEnumerator Enumerate() {
        return new DisciplineEnumerator(this);
    }

    public Disciplines() : this(0) {}

    public Disciplines (int values) {
        this[0] = values;
        this[1] = values;
        this[2] = values;
        this[3] = values;
        this[4] = values;
        this[5] = values;
    }

    public bool SharesDisciplinesWith(Disciplines other) {
        foreach (var discipline in this.Enumerate()) {
            var disciplineInOther = other[discipline.Index];
            if (discipline.Value > 0 && disciplineInOther > 0) {
                return true;
            }
        }
        return false;
    }
}

}