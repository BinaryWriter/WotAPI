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
            var Api = new WotApi("TOKEN", WotApi.WotApiRegion.EU);
            var Player = Api.Get<WotAPI.Api.Accounts.Players>("Test");
            
            Console.WriteLine(Player.Result[0].AccountID);
            
            // Output: 58586902
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
            var Api = new WotApi("TOKEN", WotApi.WotApiRegion.EU);
            var Clan = Api.Get<WotAPI.Api.Clans.Clans>("Test");
            
            Console.WriteLine(Clan.Result[0].ClanID);
            
            // Output: 36755
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
            var Api = new WotApi("TOKEN", WotApi.WotApiRegion.EU);
            var Tank = Api.Get<WotAPI.Api.Tankopedia.Vehicle.Info>(1537);
            
            Console.WriteLine(Tank.Result.Info.ShortName);
            
            // Output: Т-28
        }
    }
}
```