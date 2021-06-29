<strong>Примеры использования WotAPI</strong>

<li> Поиск игрока по имени и после этого получение его ID </li>
<li> Вывод: "Айди игрока Dev: 9704" </li>

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
           var api = new WotApi("Application ID", WotApiRegion.RU);
           // Получаем игрока с именем Dev
           var player = GetPlayer("Dev", api);
           // Выводим его айди в консоль
           Console.WriteLine("Айди игрока Dev:" + player.AccountID);
           Console.ReadKey();
        }
       
        // Этот метод возвращает игрока с таким же именем
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

<li> Получение названия техники по его айди </li>
<li> Вывод: "Т-28" </li>

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
           var api = new WotApi("Application ID", WotApiRegion.RU);
           // Получаем информацию о танке с айди 1537
           var tankInfo = GetTankInfo(1537, api).Data.Info;
           // Выводим название танка
           Console.WriteLine(tankInfo.ShortName);
           Console.ReadKey();
        }
       
         // Этот метод возвращает информацию о технике с конфигурацией по умолчанию
        static TankInfo GetTankInfo(int tank_id, WotApi api)
        {
            var parameters = new RequestParameters<TankInfo>(api, tank_id);
            return parameters.Send();
        }
    }
}
```

<li> Получение количиства участников клана </li>
<li> Вывод: "Количество участников клана Clan Name: 5" </li>

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
           var api = new WotApi("Application ID", WotApiRegion.RU);
           // Получаем клан с названием Clan Name
           var clan = GetClan("Clan Name", api);
           // Выводим количество участников этого клана
           Console.WriteLine("Количество участников клана Clan Name: " + clan.MembersCount);
           Console.ReadKey();
        }
       
        // Этот метод возвращает клан с таким-же тегом или именем
        static Clan GetClan(string clan_name_or_tag, WotApi api)
        {
            var parameters = new RequestParameters<ClansList>(api, clan_name_or_tag);
            var clans = parameters.Send().Data;
            return clans[0];
        }
    }
}
```

<li> Получение характеристик кастомной конфигурации техники </li>
<li> Вывод: "Орудие 76 мм КТ-28 поменялось на 57 мм ЗиС-4" </li>

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
            var api = new WotApi("Application ID", WotApiRegion.RU);
            // Получаем информацию о T-28
            var tankInfo = GetTankInfo(1537, api).Data.Info;
            // Получаем другое орудие доступное на T-28
            int next_gun_id = tankInfo.Guns[1];
            // Создаем дополнительные параметры
            var dopParams = new Dictionary<string, object>();
            // Меняем орудие по умолчанию на другое орудие
            dopParams.Add("gun_id", next_gun_id.ToString());
            // Получаем кастомную конфигурацию с орудием на которое мы сменили старое
            var tankCharactersitic = GetTankCharacteristic(1537, dopParams, api);
            // Выводим наши изменения
            Console.WriteLine($"Орудие {tankInfo.DefaultProfile.Gun.Name} поменялось на {tankCharactersitic.Data.Characteristic.Gun.Name}");
            Console.ReadKey();
        }

        // Этот метод возвращает информацию о технике с конфигурацией по умолчанию
        static TankInfo GetTankInfo(int tank_id, WotApi api)
        {
            var parameters = new RequestParameters<TankInfo>(api, tank_id);
            return parameters.Send();
        }

        // Этот метод возвращает информацию о кастомной конфигурации техники. 
        // Если не указывать дополнительные параметры, то он вернет обычную конфигурацию этого танка
        static TankCharacteristic GetTankCharacteristic(int tank_id, Dictionary<string, object> customModules, WotApi api)
        {
            var parameters = new RequestParameters<TankCharacteristic>(api, tank_id, 1, customModules);
            return parameters.Send();
        }
    }
}
```