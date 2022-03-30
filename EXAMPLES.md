## Examples of working with the WotAPI library
---
**Getting a player's ID by nickname**
```CSHARP
using WotAPI;

namespace Examples.PlayerID
{
    public class Program
    {
        private static void Main()
        {
            WotApi.Create("TOKEN", WotApi.WotApiRegion.EU);
            
            var player = WotAPI.Api.Accounts.Players.Get("Test")[0];
            
            Console.WriteLine(player.AccountID);
            
            // Output: '58586902'
        }
    }
}
```

**Getting the clan ID by name**
```CSHARP
using WotAPI;

namespace Examples.ClanID
{
    public class Program
    {
        private static void Main()
        {
            WotApi.Create("TOKEN", WotApi.WotApiRegion.EU);
            
            var clan = WotAPI.Api.Clans.Clans.Get("Test")[0];
            
            Console.WriteLine(clan.ClanID);
            
            // Output: '36755'
        }
    }
}
```

**Getting the name of the tank by ID**
```CSHARP
using WotAPI;

namespace Examples.TankName
{
    public class Program
    {
        private static void Main()
        {
            WotApi.Create("TOKEN", WotApi.WotApiRegion.EU);
            
            var tank = WotAPI.Api.Tankopedia.Vehicle.Info.Get(1537);
            
            Console.WriteLine(tank.Info.ShortName);
            
            // Output: 'T-28'
        }
    }
}
```