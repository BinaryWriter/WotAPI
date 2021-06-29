<strong>Examples of using WotAPI</strong>

<li> Search for a player by name and then get their ID </li>
<li> Output: "Dev player ID: 9704" </li>

```C#
using System;
using System.Collections.Generic;
using WotApi.Api.WotApi;
using WotApi.Api.Response;
using WotApi.Accounts;

namespace Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
           var api = new WotApi("Application ID", WotApiRegion.EU);
           // Getting a player with name Dev
           var player = GetPlayer("Dev", api);
           // Output of its id
           Console.WriteLine("Dev player ID:" + player.AccountID);
           Console.ReadKey();
        }
       
        // This method returns a player with the same name
        static PlayersList.Player GetPlayer(string nickname, WotApi api)
        {
            var parameters = new RequestParameters<PlayersList>(api, nickname);
            var list = parameters.Send();
            foreach(var player in list.Data)
            {
                if (player.Nickname == nickname)
                {
                    return player;
                }
            }
            return null;
        }
    }
}
```

<li> Getting the name of the technique by its id </li>
<li> Output: "T-28" </li>

```C#
using System;
using System.Collections.Generic;
using WotApi.Api.WotApi;
using WotApi.Api.Response;
using WotApi.Tankopedia;
using WotApi.Tankopedia.Tanks;

namespace Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
           var api = new WotApi("Application ID", WotApiRegion.EU);
           // Getting information about a tank with ID 1537
           var tankInfo = GetTankInfo(1537, api).Data.Info;
           // Output of the tank name
           Console.WriteLine(tankInfo.ShortName);
           Console.ReadKey();
        }
       
        // This method returns information about the tank with the default configuration
        static TankInfo GetTankInfo(int tank_id, WotApi api)
        {
            var parameters = new RequestParameters<TankInfo>(api, tank_id);
            return parameters.Send();
        }
    }
}
```

<li> Getting clan members count </li>
<li> Output: "Clan Name members count: 5" </li>

```C#
using System;
using System.Collections.Generic;
using WotApi.Api.WotApi;
using WotApi.Api.Response;
using WotApi.Clans;
using WotApi.Clans.General;

namespace Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
           var api = new WotApi("Application ID", WotApiRegion.EU);
           // Getting a clan with the name - Clan Name
           var clan = GetClan("Clan Name", api);
           // Output of count of clan members
           Console.WriteLine("Clan Name members count: " + clan.MembersCount);
           Console.ReadKey();
        }
       
        // This method returns a clan with the same tag or name
        static Clan GetClan(string clan_name_or_tag, WotApi api)
        {
            var parameters = new RequestParameters<ClansList>(api, clan_name_or_tag);
            var clans = parameters.Send().Data;
            return clans[0];
        }
    }
}
```

<li> Getting the characteristics of a custom configuration of equipment </li>
<li> Conclusion: "The 76 mm KT-28 gun was changed to the 57 mm ZiS-4" </li>

```C#
using System;
using System.Collections.Generic;
using WotApi.Api.WotApi;
using WotApi.Api.Response;
using WotApi.Tankopedia.Tanks;
using WotApi.Tankopedia;

namespace Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
            var api = new WotApi("Application ID", WotApiRegion.EU);
            // Getting information about the T-28
            var tankInfo = GetTankInfo(1537, api).Data.Info;
            // Get another gun available on the T-28
            int next_gun_id = tankInfo.Guns[1];
            // Creating additional parameters
            var dopParams = new Dictionary<string, object>();
            // Changing the default gun to another gun
            dopParams.Add("gun_id", next_gun_id);
            // We get a custom configuration with the gun that we replaced the old gun with
            var tankCharactersitic = GetTankCharacteristic(1537, dopParams, api);
            // Output of changes in the tank configuration
            Console.WriteLine($"The {tankInfo.DefaultProfile.Gun.Name} gun was changed to the {tankCharactersitic.Data.Characteristic.Gun.Name}");
            Console.ReadKey();
        }

        // This method returns information about the tank with the default configuration
        static TankInfo GetTankInfo(int tank_id, WotApi api)
        {
            var parameters = new RequestParameters<TankInfo>(api, tank_id);
            return parameters.Send();
        }

        // This method returns information about the custom configuration of the tank. 
        // If you do not specify additional parameters, it will return the default configuration of this tank
        static TankCharacteristic GetTankCharacteristic(int tank_id, Dictionary<string, object> customModules, WotApi api)
        {
            var parameters = new RequestParameters<TankCharacteristic>(api, tank_id, 1, customModules);
            return parameters.Send();
        }
    }
}
```