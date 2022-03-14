## Build application

First you have to build project. Project is inside ./BuddyAPI

```bash
dotnet build
```

*Note that you will need to have [dotnet core](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50) installed.*

```bash
dotnet ef migrations add Init --project DataLayer -s Buddy --context BuddyDbContext
dotnet ef database update --project DataLayer -s Buddy --context BuddyDbContext
```

```bash
dotnet ef migrations add Init --project DataLayer.Events -s Buddy --context EventDbContext
dotnet ef database update --project DataLayer.Events -s Buddy --context EventDbContext 
```

## Starting application


```bash
dotnet run --project Buddy
```

...then start [Rollup](https://localhost:5001/swagger/index.html):

