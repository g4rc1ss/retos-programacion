using System;

public static class Gigasecond
{
    private static DateTime dateTime = new DateTime().AddSeconds(1_000_000_000);
    public static DateTime Add(DateTime moment)
    {
        return new DateTime(dateTime.Ticks).AddTicks(moment.Ticks);
    }
}