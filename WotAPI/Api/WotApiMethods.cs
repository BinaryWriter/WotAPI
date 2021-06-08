/*
 * @author: BinaryWriter
 */

namespace WotAPI.Api
{

    public enum WotApiMethods
    {
        /// <summary>
        /// RU: Метод возвращает часть списка игроков, отфильтрованную по первым символам имени и отсортированную по алфавиту
        /// <para> EN: Method returns partial list of players. The list is filtered by initial characters of user name and sorted alphabetically </para>
        /// </summary>
        AccountsList,
        /// <summary>
        /// RU: Метод возвращает информацию о технике игрока
        /// <para> EN: Method returns details on player's vehicles </para>
        /// </summary>
        AccountTanks,
        /// <summary>
        /// RU: Метод возвращает информацию о достижениях игроков
        /// <para> EN: Method returns player's achievement details </para>
        /// </summary>
        AccountAchievements,
        /// <summary>
        /// RU: Метод возвращает детальную информацию об игроке
        /// <para> EN: Method returns player details </para>
        /// </summary>
        AccountDetails,
        /// <summary>
        /// RU: Метод проводит поиск по кланам
        /// <para> EN: Method searches through clans </para>
        /// </summary>
        ClansList,
        /// <summary>
        /// RU: Метод возвращает детальную информацию о клане
        /// <para> EN: Method returns detailed clan information </para>
        /// </summary>
        ClanDetails,
        /// <summary>
        /// RU: Метод возвращает информацию о клановых сущностях
        /// <para> EN: Method returns information on clan entities </para>
        /// </summary>
        ClanGlossary,
        /// <summary>
        /// RU: Метод возвращает информацию о клановой истории игрока. В ответе присутсвует информация о 10 последних пребываниях в кланах
        /// <para> EN: Method returns information about player's clan history. Data on 10 last clan memberships are presented in the response </para>
        /// </summary>
        ClanHistory,
        /// <summary>
        /// RU: Метод возвращает информацию об игроке клана и краткую информацию о клане
        /// <para> EN: Method returns detailed clan member information and brief clan details </para>
        /// </summary>
        ClanMemberDetails,
        /// <summary>
        /// RU: Метод возвращает информацию о технике
        /// <para> EN: Method returns information about the vehicle </para>
        /// </summary>
        TankopediaTankInfo,
        /// <summary>
        /// RU: Метод возвращает характеристики конфигурации техники на основе указанных идентификаторов модулей
        /// <para> EN: Method returns vehicle configuration characteristics based on the specified module IDs </para>
        /// </summary>
        TankopediaTankCharacteristic,
        /// <summary>
        /// RU: Метод возвращает информацию о достижениях
        /// <para> EN: Method returns information about achievements </para>
        /// </summary>
        TankopediaAchievements,
        /// <summary>
        /// RU: Метод возвращает информацию о Танкопедии
        /// <para> EN: Method returns information about Tankopedia </para>
        /// </summary>
        TankopediaInfo,
        /// <summary>
        /// RU: Метод возвращает информацию об игровых картах
        /// <para> EN: Method returns information about maps </para>
        /// </summary>
        TankopediaArenas,
        /// <summary>
        /// RU: Метод возвращает список доступного оборудования и снаряжения
        /// <para> EN: Method returns a list of available equipment and consumables </para>
        /// </summary>
        TankopediaProvision,
        /// <summary>
        /// RU: Метод возвращает информацию о Личных боевых задачах на основе указанных идентификаторов кампании, операции, ветки боевых задач и тегов
        /// <para> EN: Method returns details on Personal Missions on the basis of specified campaign IDs, operation IDs, mission branch and tag IDs </para>
        /// </summary>
        TankopediaMissions,
        /// <summary>
        /// RU: Метод возвращает информацию о личных резервах
        /// <para> EN: Method returns information about Personal Reserves </para>
        /// </summary>
        TankopediaBoosters,
        /// <summary>
        /// RU: Метод возвращает список доступных нашивок, которые игрок может заработать в Ранговых боях
        /// <para> EN: Method returns list of available badges a player can gain in Ranked Battles </para>
        /// </summary>
        TankopediaBadges,
        /// <summary>
        /// RU: Метод возвращает характеристики комплектации техники
        /// <para> EN: Method returns vehicle configuration characteristics </para>
        /// </summary>
        TankopediaTankProfiles,
        /// <summary>
        /// RU: Метод возвращает полное описание всех специальностей экипажа
        /// <para> EN: Method returns full description of all crew qualifications </para>
        /// </summary>
        TankopediaCrewRoles,
        /// <summary>
        /// RU: Метод возвращает полное описание всех умений экипажа
        /// <para> EN: Method returns full description of all crew skills </para>
        /// </summary>
        TankopediaCrewSkills,
        /// <summary>
        /// RU: Метод возвращает общую информацию и боевую статистику кланов в режиме «Укрепрайон». Обратите внимание, что информация о количестве проведённых боёв, а также количестве побед и поражений клана обновляется один раз в сутки
        /// <para> EN: Method returns general information and the battle statistics of clans in the Stronghold mode. Please note that information about the number of battles fought as well as the number of defeats and victories is updated once every 24 hours </para>
        /// </summary>
        StrongholdsClanInfo
    }
}
