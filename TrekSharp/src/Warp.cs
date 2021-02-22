using System;

namespace TrekSharp {

public class WarpFactor {
    public double Factor {get; private set;}
    public WarpFactor(double factor) {
        this.Factor = factor;
    }

    private static double C = 299_792_458 /*m/s*/;

    private double fw() {
        if (Factor > 9 && Factor <= 10) {
            return -0.5 * Math.Log10(10 - Factor);
        } else {    
            return 0;
        }
    }

    /// <summary>
    /// Travel speed in metres/second
    /// </summary>
    /// <returns>metres per second</returns>
    public double MetresPerSecond() {
        return C * LightSpeedFactor();
    }

    /// <summary>
    /// Travel time in multiples of the speed of light
    /// </summary>
    /// <returns>multiples of the speed of light</returns>
    public double LightSpeedFactor() {
        return Math.Pow(Factor, 10d/3d + fw());
    }

    /// <summary>
    /// Amount of time required to travel the given distance
    /// </summary>
    /// <param name="metres">distance in metres</param>
    /// <returns>time of flight</returns>
    public TimeSpan TimeOfFlight(double metres) {
        var mpf = this.MetresPerSecond();
        // D = S * T  -->  T = D / S
        return TimeSpan.FromSeconds(metres / mpf);
    }
}

}