## Enum extensions

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
