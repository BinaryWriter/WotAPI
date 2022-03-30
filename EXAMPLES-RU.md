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
            WotApi.Create("TOKEN", WotApi.WotApiRegion.EU);
            
            var player = WotAPI.Api.Accounts.Players.Get("Test")[0];
            
            Console.WriteLine(player.AccountID);
            
            // Вывод в консоль: '58586902'
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
            WotApi.Create("TOKEN", WotApi.WotApiRegion.EU);
            
            var clan = WotAPI.Api.Clans.Clans.Get("Test")[0];
            
            Console.WriteLine(clan.ClanID);
            
            // Вывод в консоль: '36755'
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
            WotApi.Create("TOKEN", WotApi.WotApiRegion.EU);
            
            var tank = WotAPI.Api.Tankopedia.Vehicle.Info.Get(1537);
            
            Console.WriteLine(tank.Info.ShortName);
            
            // Вывод в консоль: 'T-28'
        }
    }
}
```