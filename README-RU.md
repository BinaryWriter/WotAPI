## WotAPI - Библиотека на языке C# для получения данных о World of Tanks
[![Release](https://img.shields.io/github/v/release/BinaryWriter/WotAPI)](https://github.com/BinaryWriter/WotAPI/releases) [![Repo Size](https://img.shields.io/github/repo-size/BinaryWriter/WotAPI)](https://github.com/BinaryWriter/WotAPI) [![Issues](https://img.shields.io/github/issues/BinaryWriter/WotAPI)](https://github.com/BinaryWriter/WotAPI/issues) [![Pull Requests](https://img.shields.io/github/issues-pr/BinaryWriter/WotAPI)](https://github.com/BinaryWriter/WotAPI/pulls)

- **README in other languages** - [RU](https://github.com/BinaryWriter/WotAPI/blob/master/README-RU.md), [EN](https://github.com/BinaryWriter/WotAPI/blob/master/README.md)
- [**Примеры работы с библиотекой**](https://github.com/BinaryWriter/WotAPI/blob/master/EXAMPLES-RU.md)
---
**Создание экземпляра класса WotApi для выполнение запросов**
- **Параметры**
  - Token - Токен для Wargaming Api. Получить его можно тут - [Wargaming Application](https://developers.wargaming.net/applications/).
  - Region - Регион Wargaming Api. Доступные - RU, EU, NA, ASIA.
```CSHARP
WotApi Api = new WotApi(Token, Region);
```

**Выполнение запроса**
- **Обобщения**
  - T - Класс ответа. Класс должен быть унаследован от [ResponseClass](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/ResponseClass.cs) и иметь аттрибут [ResponseAttribute](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/ResponseAttribute.cs). Такие классы указаны ниже, в таблице классов.
- **Параметры**
  - Search - Обьект для поиска. Например ID игрока. Указывать не обязательно.
  - Page - Номер страницы. По умолчанию первая. Указывать не обязательно.
  - Parameters - Словарь с дополнительными параметрами. Указывать не обязательно.
```CSHARP
T Response = Api.Get<T>(Search, Page, Parameters);
```
---
#### Таблица классов
| Страница на developers.wargaming.net | Класс в WotAPI |
| - | - |
| https://developers.wargaming.net/reference/all/wot/account/achievements/ | [WotAPI.Api.Accounts.Player.Achievements](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Accounts/Player/Achievements.cs) |
| https://developers.wargaming.net/reference/all/wot/account/info/ | [WotAPI.Api.Accounts.Player.Info](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Accounts/Player/Info.cs) |
| https://developers.wargaming.net/reference/all/wot/account/list/ | [WotAPI.Api.Accounts.Players](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Accounts/Players.cs) |
| https://developers.wargaming.net/reference/all/wot/account/tanks/ | [WotAPI.Api.Accounts.Player.Vehicles](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Accounts/Player/Vehicles.cs) |
| https://developers.wargaming.net/reference/all/wot/clans/accountinfo/ | [WotAPI.Api.Clans.Player.Info](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Clans/Player/Info.cs) |
| https://developers.wargaming.net/reference/all/wot/clans/glossary/ | [WotAPI.Api.Clans.Clan.Glossary](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Clans/Clan/Glossary.cs) |
| https://developers.wargaming.net/reference/all/wot/clans/info/ | [WotAPI.Api.Clans.Clan.Info](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Clans/Clan/Info.cs) |
| https://developers.wargaming.net/reference/all/wot/clans/list/ | [WotAPI.Api.Clans.Clans](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Clans/Clans.cs) |
| https://developers.wargaming.net/reference/all/wot/clans/memberhistory/ | [WotAPI.Api.Clans.Player.History](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Clans/Player/History.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/achievements/ | [WotAPI.Api.Tankopedia.Achievements](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Achievements.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/arenas/ | [WotAPI.Api.Tankopedia.Maps](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Maps.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/badges/ | [WotAPI.Api.Tankopedia.Badges](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Badges.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/boosters/ | [WotAPI.Api.Tankopedia.PersonalReserves](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/PersonalReserves.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/crewroles/ | [WotAPI.Api.Tankopedia.Crew.Roles](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Crew/Roles.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/crewskills/ | [WotAPI.Api.Tankopedia.Crew.Skills](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Crew/Skills.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/info/ | [WotAPI.Api.Tankopedia.Info](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Info.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/personalmissions/ | [WotAPI.Api.Tankopedia.PersonalMissions](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/PersonalMissions.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/provisions/ | [WotAPI.Api.Tankopedia.Equipment](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Equipment.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/tankinfo/ | [WotAPI.Api.Tankopedia.Vehicle.Info](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Vehicle/Info.cs) |
| https://developers.wargaming.net/reference/all/wot/encyclopedia/vehicleprofile/ | [WotAPI.Api.Tankopedia.Vehicle.Profile](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Tankopedia/Vehicle/Profile.cs) |
| https://developers.wargaming.net/reference/all/wot/globalmap/claninfo/ | [WotAPI.Api.GlobalMap.Clan.Info](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/GlobalMap/Clan/Info.cs) |
| https://developers.wargaming.net/reference/all/wot/globalmap/fronts/ | [WotAPI.Api.GlobalMap.Fronts](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/GlobalMap/Fronts.cs) |
| https://developers.wargaming.net/reference/all/wot/globalmap/info/ | [WotAPI.Api.GlobalMap.Status](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/GlobalMap/Status.cs) |
| https://developers.wargaming.net/reference/all/wot/stronghold/claninfo/ | [WotAPI.Api.Strongholds.Clan.Info](https://github.com/BinaryWriter/WotAPI/blob/master/WotAPI/Api/Strongholds/Clan/Info.cs) |

