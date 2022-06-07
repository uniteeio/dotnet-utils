## String extensions

- Generate a deterministic GUID with a string
```cs
var bar = "My string to convert in Guid";
Guid foo = bar.ToGuid();
```