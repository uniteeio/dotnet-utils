## Datetime Extensions

- Start or end of the week methods
```cs
var myDate = new DateTime();

// Return the previous selected day (here the pevious monday)
DateTime previousMondayDateTime = myDate.GetPreviousDay(DayOfWeek.Monday);

// Return the next selected day (here the next friday)
DateTime nextMondayDateTime = myDate.GetNextDay(DayOfWeek.Friday);
```

- 
```cs
public static DateTime ToFrenchDateTime(this DateTime utcDateTime)
{
    TimeZoneInfo frenchZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris");
    return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, frenchZone);
}
```
