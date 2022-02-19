## Примеры работы с библиотекой WotAPI
---
**Получение айди игрока по никнейму**
```CSHARP
using WotAPI;

namespace Examples.PlayerID
{
    public class Program
    {
        private static void Main()
        {
            var Api = new WotApi("TOKEN", WotApi.WotApiRegion.RU);
            var Player = Api.Get<WotAPI.Api.Accounts.Players>("Test");
            
            Console.WriteLine(Player.Result[0].AccountID);
                        
            // Output: 58586902
        }
    }
}
```

**Получение айди клана по называнию**
```CSHARP
using WotAPI;

namespace Examples.ClanID
{
    public class Program
    {
        private static void Main()
        {
            var Api = new WotApi("TOKEN", WotApi.WotApiRegion.RU);
            var Clan = Api.Get<WotAPI.Api.Clans.Clans>("Test");
            
            Console.WriteLine(Clan.Result[0].ClanID);
                        
            // Output: 36755
        }
    }
}
```

**Получение названия танка по айди**
```CSHARP
using WotAPI;

namespace Examples.TankName
{
    public class Program
    {
        private static void Main()
        {
            var Api = new WotApi("TOKEN", WotApi.WotApiRegion.RU);
            var Tank = Api.Get<WotAPI.Api.Tankopedia.Vehicle.Info>(1537);
            
            Console.WriteLine(Tank.Result.Info.ShortName);
                        
            // Output: Т-28
        }
    }
}
```