# blazor.notes

## detailed.errors

Add the following to get better error messages in the console:



```csharp
    services.AddServerSideBlazor().AddCircuitOptions(options => {
        options.DetailedErrors = true;
    });

```