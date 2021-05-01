using System;

namespace TrekSharp {

public abstract class Dice {
    private static Random rng = new Random();

    public int NumericValue {get; protected set;}

    protected int RollNumeric (int max) {
        this.NumericValue = rng.Next(max) + 1;
        return NumericValue;
    }

    public abstract void Roll();

}

public class D20 : Dice {

    public override void Roll() {
        this.RollNumeric(20);
    } 
}

public class D6 : Dice {

    public override void Roll() {
        this.RollNumeric(6);
    } 
}

public enum ChallengeDiceResult {
    One,
    Two,
    None,
    Effect,
}

public class ChallengeDice : Dice {
    public int D6Value {get; private set;}
    public ChallengeDiceResult ChallengeValue {get; private set;}
    public override void Roll() {
        var roll = this.RollNumeric(6);
        D6Value = roll;
        ChallengeValue = roll switch {
            1 => ChallengeDiceResult.One,
            2 => ChallengeDiceResult.Two,
            3 => ChallengeDiceResult.None,
            4 => ChallengeDiceResult.None,
            5 => ChallengeDiceResult.Effect,
            6 => ChallengeDiceResult.Effect,
            _ => throw new Exception("Invalid Challenge dice result")
        };
        this.NumericValue = ChallengeValue switch {
            ChallengeDiceResult.One => 1,
            ChallengeDiceResult.Two => 2,
            ChallengeDiceResult.Effect => 1,
            _ => 0
        };
    }
}

}