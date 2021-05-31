# Improve your dotnet style

You can find here some nice tools/methods to improve your code. 

## Extensions Methods

##### DateTime extensions

- Start or end of the week methods
```cs
var myDate = new DateTime();

// Return the previous selected day (here the pevious monday)
DateTime previousMondayDateTime = myDate.StartOfWeek(DayOfWeek.Monday);

// Return the next selected day (here the next friday)
DateTime nextMondayDateTime = myDate.EndOfWeek(DayOfWeek.Friday);
```

##### Enum extensions

- Display name method 
```cs
public enum Celebrity
{
    [Display(Name = "Jim Carrey")] JimCarrey,
    [Display(Name = "Mariah Carey")] MariahCarey
}

// Return the display name "Jim Carrey"
string jimCarreyDisplayName = Celebrity.JimCarrey.GetDisplayName();
```

##### String extensions

- Generate a deterministic GUID with a string
```cs
var bar = "My string to convert in Guid";
Guid foo = bar.ToGuid();
```
