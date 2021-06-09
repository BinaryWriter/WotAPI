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
           WotApi api = new WotApi("Application ID", WotApiRegion.EU);
           // Getting a player with name Dev
           PlayersList.Player player = GetPlayer("Dev");
           // Output of its id
           Console.WriteLine("Dev player ID:" + player.AccountID);
           Console.ReadKey();
        }
       
        // This method returns a player with the same name
        static PlayersList.Player GetPlayer(string nickname, WotApi api)
        {
            RequestParameters parameters = new RequestParameters(
                // Method for getting a list of players with a similar nickname
                WotApiMethods.AccountsList,
                api,
                // Player nickname
                nickname
            );
            PlayersList list = api.SendRequest<PlayersList>(parameters);
            foreach(PlayersList.Player player in list.Data)
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
           WotApi api = new WotApi("Application ID", WotApiRegion.EU);
           // Getting information about a tank with ID 1537
           TankInfo.Info tankInfo = GetTankInfo(1537, api).Data.Info;
           // Output of the tank name
           Console.WriteLine(tankInfo.ShortName);
           Console.ReadKey();
        }
       
        // This method returns information about the tank with the default configuration
        static TankInfo GetTankInfo(int tank_id, WotApi api)
        {
            RequestParameters parameters = new RequestParameters(
                // Method for getting information about a tank
                WotApiMethods.TankopediaTankInfo,
                api,
                // Tank ID in string format
                tank_id.ToString()
            );
            return api.SendRequest<TankInfo>(parameters);
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
           WotApi api = new WotApi("Application ID", WotApiRegion.EU);
           // Getting a clan with the name - Clan Name
           Clan clan = GetClan("Clan Name", api);
           // Output of count of clan members
           Console.WriteLine("Clan Name members count: " + clan.MembersCount);
           Console.ReadKey();
        }
       
        // This method returns a clan with the same tag or name
        static Clan GetClan(string clan_name_or_tag, WotApi api)
        {
            RequestParameters parameters = new RequestParameters(
                // Method for getting a list of clans
                WotApiMethods.ClansList,
                api,
                // The name of the clan or its tag. If you do not specify this parameter, we will get a list of all the clans
                clan_name_or_tag
            );
            Clan[] clans = api.SendRequest<ClansList>(parameters).Data;
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
            WotApi api = new WotApi("Application ID", WotApiRegion.EU);
            // Getting information about the T-28
            TankInfo.Info tankInfo = GetTankInfo(1537, api).Data.Info;
            // Get another gun available on the T-28
            int next_gun_id = tankInfo.Guns[1];
            // Creating additional parameters
            Dictionary<string, string> dopParams = new Dictionary<string, string>();
            // Changing the default gun to another gun
            dopParams.Add("gun_id", next_gun_id.ToString());
            // We get a custom configuration with the gun that we replaced the old gun with
            TankCharacteristic tankCharactersitic = GetTankCharacteristic(1537, dopParams, api);
            // Output of changes in the tank configuration
            Console.WriteLine($"The {tankInfo.DefaultProfile.Gun.Name} gun was changed to the {tankCharactersitic.Data.Characteristic.Gun.Name}");
            Console.ReadKey();
        }

        // This method returns information about the tank with the default configuration
        static TankInfo GetTankInfo(int tank_id, WotApi api)
        {
            RequestParameters parameters = new RequestParameters(
                // Method for getting information about a tank
                WotApiMethods.TankopediaTankInfo,
                api,
                // Tank ID in string format
                tank_id.ToString()
            );
            return api.SendRequest<TankInfo>(parameters);
        }

        // This method returns information about the custom configuration of the tank. 
        // If you do not specify additional parameters, it will return the default configuration of this tank
        static TankCharacteristic GetTankCharacteristic(int tank_id, Dictionary<string, string> customModules, WotApi api)
        {
            RequestParameters parameters = new RequestParameters(
                // Method for getting tank characteristic
                WotApiMethods.TankopediaTankCharacteristic,
                api,
                // Tank ID in string format
                tank_id.ToString(),
                // First page
                1,
                // Additional parameters
                customModules
            );
            return api.SendRequest<TankCharacteristic>(parameters);
        }
    }
}
```