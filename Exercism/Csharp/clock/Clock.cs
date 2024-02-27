using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

public class Clock : IEquatable<Clock>
{
    private TimeOnly time;

    public Clock(int hours, int minutes)
    {
        var timeSpan = new TimeSpan(hours, minutes, 0);
        time = timeSpan.Ticks < 0 ? TimeOnly.MaxValue : new TimeOnly();
        time = time.Add(timeSpan).Add(TimeSpan.FromTicks(1));
    }

    public Clock(TimeOnly time)
    {
        this.time = time;
    }

    public Clock Add(int minutesToAdd)
    {
        var addTime = time.Add(TimeSpan.FromMinutes(minutesToAdd));
        return new Clock(addTime);
    }

    public bool Equals(Clock other)
    {
        return other.ToString().Equals(ToString());
    }

    public Clock Subtract(int minutesToSubtract)
    {
        var subtractTime = time.Add(TimeSpan.FromMinutes(minutesToSubtract * -1));
        return new Clock(subtractTime);
    }
    public override string ToString() =>
        time.Add(TimeSpan.FromTicks(1))
        .ToString(@"HH:mm");
}
