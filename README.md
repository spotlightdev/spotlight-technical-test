# spotlight-technical-test

## Tools
You will need
- ASP .NET Core 2.2, you can download the sdk from https://dotnet.microsoft.com/download
- Visual Studio 2017 (Community is fine)
- Or Visual Studio Code

## To Do

1. Complete the method ```PrimeService.GetPrimes```
2. Complete the SimpleInMemoryCache and;
    1. Add the cache to the ASP.NET Services Collection
    2. Cache the result of the call to ```GetPrimes```
    3. When the api call to `/getprimes` is called with the same argument, get the value from the cache instead of calculating
3. Add a response header to the json to indicate it was from the cache
    1. Display to the user, that the value was from the cache, and not calculated
4. Bonus credit, update the "hacky" jQuery, to something nicer
