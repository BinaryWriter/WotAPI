using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Accounts
{
    public class PlayerDetails : IResponse<PlayerDetails.PlayerDetailsData>
    {
        public partial class PlayerDetailsData
        {
            [JsonProperty("search")]
            public Details Details;
        }
        public partial class Details
        {
            /// <summary> RU: Язык, выбранный в клиенте игры <para> EN: Language selected in the game client </para> </summary>
            [JsonProperty("client_language")]
            public string ClientLanguage;
            /// <summary> RU: Время последнего боя <para> EN: Last battle time </para> </summary>
            [JsonProperty("last_battle_time")]
            public long LastBattleTime;
            /// <summary> RU: Идентификатор аккаунта игрока <para> EN: Player account ID </para> </summary>
            [JsonProperty("account_id")]
            public long AccountID;
            /// <summary> RU: Дата создания аккаунта игрока <para> EN: Date when player's account was created </para> </summary>
            [JsonProperty("created_at")]
            public long CreatedAt;
            /// <summary> RU: Дата обновления информации об игроке <para> EN: Date when player details were updated </para> </summary>
            [JsonProperty("updated_at")]
            public long UpdatedAt;
            /// <summary> RU: Личный рейтинг <para> EN: Personal rating </para> </summary>
            [JsonProperty("global_rating")]
            public long GlobalRating;
            /// <summary> RU: Идентификатор клана <para> EN: Clan ID </para> </summary>
            [JsonProperty("clan_id")]
            public long ClanID;
            /// <summary> RU: Статистика игрока <para> EN: Player statistics</para> </summary>
            [JsonProperty("statistics")]
            public Statistics Statistics;
            /// <summary> RU: Имя игрока <para> EN: Player name </para> </summary>
            [JsonProperty("nickname")]
            public string Nickname;
            /// <summary> RU: Время окончания последней игровой сессии <para> EN: End time of last game session</para> </summary>
            [JsonProperty("logout_at")]
            public long LogoutAt;
        }
        public partial class Statistics
        {
            /// <summary> RU: Статистика боёв в составе клана <para> EN: Clan battles statistics </para> </summary>
            [JsonProperty("clan")]
            public OnlyAvg Clan;
            /// <summary> RU: Общая статистика для Случайных и клановых боёв без учёта Глобальной карты 2.0 <para> EN: Total statistics in Random and clan battles without the Global Map 2.0 statistics</para> </summary>
            [JsonProperty("all")]
            public OnlyMax All;
            /// <summary> RU: Статистика командных боёв постоянных команд <para> EN: Battle statistics of permanent teams </para> </summary>
            [JsonProperty("regular_team")]
            public MaxAndAvg RegularTeam;
            /// <summary> RU: Количество поваленных деревьев <para> EN: Trees knocked down </para> </summary>
            [JsonProperty("trees_cut")]
            public int TreesCut;
            /// <summary> RU: Статистика по Ранговым боям <para> EN: Ranked Battles statistics </para> </summary>
            [JsonProperty("ranked_battles")]
            public OnlyMax RankedBattles;
            /// <summary> RU: Статистика боёв в составе роты <para> EN: Tank Company battles statistics</para> </summary>
            [JsonProperty("company")]
            public OnlyAvg Company;
            /// <summary> RU: Статистика случайных боёв <para> EN: Random battles statistics. </para> </summary>
            [JsonProperty("random")]
            public OnlyAvg Random;
            /// <summary> RU: Общая по всем кланам статистика боёв игрока в режиме вылазок Укрепрайона <para> EN: General stats for player's battles in Skirmishes </para> </summary>
            [JsonProperty("stronghold_skirmish")]
            public OnlyMax StrongholdSkirmish;
            /// <summary> RU: Общая по всем кланам статистика боёв игрока в режиме обороны Укрепрайона <para> EN: General stats for player's battles in Stronghold defense </para> </summary>
            [JsonProperty("stronghold_defense")]
            public OnlyMax StrongholdDefense;
            /// <summary> RU: Статистика исторических боёв <para> EN: Historical battles statistics</para> </summary>
            [JsonProperty("historical")]
            public MaxAndAvg Historical;
            /// <summary> RU: Статистика командных боёв <para> EN: Team battles statistics </para> </summary>
            [JsonProperty("team")]
            public MaxAndAvg Team;
            /// <summary> RU: Количество и модели уничтоженной игроком техники. Приватные данные игрока <para> EN: Number and models of vehicles destroyed by a player. Player's private data </para> </summary>
            [JsonProperty("frags")]
            public object Frags;
            /// <summary> RU: Статистика боёв на Глобальной карте в Абсолютном дивизионе <para> EN: Battle statistics on the Global Map in Absolute division </para> </summary>
            [JsonProperty("globalmap_absolute")]
            public OnlyAvg GlobalMapAbsolute;
            /// <summary> RU: Статистика боёв на Глобальной карте в Чемпионском дивизионе <para> EN: Battle statistics on the Global Map in Champion division </para> </summary>
            [JsonProperty("globalmap_champion")]
            public OnlyAvg GlobalMapChampion;
            /// <summary> RU: Статистика боёв на Глобальной карте в Среднем дивизионе <para> EN: Battle statistics on the Global Map in Medium division </para> </summary>
            [JsonProperty("globalmap_middle")]
            public OnlyAvg GlobalMapMiddle;
        }
        public partial class Base
        {
            /// <summary> RU: Обнаружено противников <para> EN: Enemies spotted</para> </summary>
            [JsonProperty("spotted")]
            public int Spotted;
            /// <summary> RU: Количество боёв на технике, причиняющей оглушение <para> EN: Number of battles on vehicles that cause the stun effect</para> </summary>
            [JsonProperty("battles_on_stunning_vehicles")]
            public int BattlesOnStunningVehicles;
            /// <summary> RU: Количество полученных прямых попаданий <para> EN: Direct hits received </para> </summary>
            [JsonProperty("direct_hits_received")]
            public int DirectHitsReceived;
            /// <summary> RU: Количество нанесённых осколочно-фугасных попаданий <para> EN: Hits on enemy as a result of splash damage</para> </summary>
            [JsonProperty("explosion_hits")]
            public int ExplosionHits;
            /// <summary> RU: Количество полученных пробитий <para> EN: Penetrations received </para> </summary>
            [JsonProperty("piercings_received")]
            public int PiercingsReceived;
            /// <summary> RU: Количество пробитий <para> EN: Penetrations </para> </summary>
            [JsonProperty("piercings")]
            public int Piercings;
            /// <summary> RU: Суммарный опыт <para> EN: Total experience </para> </summary>
            [JsonProperty("xp")]
            public int Xp;
            /// <summary> RU: Выжил в боях <para> EN: Battles survived </para> </summary>
            [JsonProperty("survived_battles")]
            public int SurvivedBattles;
            /// <summary> RU: Очки защиты базы <para> EN: Base defense points </para> </summary>
            [JsonProperty("dropped_capture_points")]
            public int DroppedCapturePoints;
            /// <summary> RU: Процент попаданий <para> EN: Hit ratio </para> </summary>
            [JsonProperty("hits_percents")]
            public int HitsPercents;
            /// <summary> RU: Ничьи <para> EN: Draws </para> </summary>
            [JsonProperty("draws")]
            public int Draws;
            /// <summary> RU: Проведено боёв <para> EN: Battles fought </para> </summary>
            [JsonProperty("battles")]
            public int Battles;
            /// <summary> RU: Получено урона <para> EN: Damage received </para> </summary>
            [JsonProperty("damage_received")]
            public int DamageReceived;
            /// <summary> RU: Уничтожено техники <para> EN: Vehicles destroyed </para> </summary>
            [JsonProperty("frags")]
            public int Frags;
            /// <summary> RU: Количество оглушений, причинённых экипажу противника <para> EN: Number of times an enemy was stunned by you</para> </summary>
            [JsonProperty("stun_number")]
            public int StunNumber;
            /// <summary> RU: Очки захвата базы <para> EN: Base capture points </para> </summary>
            [JsonProperty("capture_points")]
            public int CapturePoints;
            /// <summary> RU: Урон по оглушённым вами целям <para> EN: Damage to enemy vehicles stunned by you </para> </summary>
            [JsonProperty("stun_assisted_damage")]
            public int StunAssistedDamage;
            /// <summary> RU: Попадания <para> EN: Hits </para> </summary>
            [JsonProperty("hits")]
            public int Hits;
            /// <summary> RU: Средний опыт за бой <para> EN: Average experience per battle </para> </summary>
            [JsonProperty("battle_avg_xp")]
            public int BattleAvgXp;
            /// <summary> RU: Победы <para> EN: Victories </para> </summary>
            [JsonProperty("wins")]
            public int Wins;
            /// <summary> RU: Поражения <para> EN: Defeats </para> </summary>
            [JsonProperty("losses")]
            public int Losses;
            /// <summary> RU: Нанесено повреждений <para> EN: Damage caused </para> </summary>
            [JsonProperty("damage_dealt")]
            public int DamageDealt;
            /// <summary> RU: Количество полученных прямых попаданий, не нанёсших урон <para> EN: Direct hits received that caused no damage </para> </summary>
            [JsonProperty("no_damage_direct_hits_received")]
            public int NoDamageDirectHitsReceived;
            /// <summary> RU: Произведено выстрелов <para> EN: Shots fired </para> </summary>
            [JsonProperty("shots")]
            public int Shots;
            /// <summary> RU: Количество полученных осколочно-фугасных попаданий <para> EN: Hits received as a result of splash damage</para> </summary>
            [JsonProperty("explosion_hits_received")]
            public int ExplosionHitsReceived;
            /// <summary> RU: Отношение заблокированного бронёй урона к полученному игроком урону от бронебойных, кумулятивных, подкалиберных снарядов. Значение считается с версии игры 9.0 <para> EN: Ratio of damage blocked by armor from AP, HEAT, and APCR shells to damage received from these types of shells. Value is calculated starting from version 9.0 </para> </summary>
            [JsonProperty("tanking_factor")]
            public double TankingFactor;
        }
        public partial class OnlyAvg : Base
        {
            /// <summary> RU: Средний заблокированный бронёй урон за бой.Заблокированный бронёй урон — это урон от снарядов (бронебойных, кумулятивных и подкалиберных), которые попали в танк, но не нанесли урона.Значение считается с версии игры 9.0 
            /// <para> EN: Average damage blocked by armor per battle. Damage blocked by armor is damage received from shells(AP, HEAT and APCR) that hit a vehicle but caused no damage. Value is calculated starting from version 9.0 </para> </summary>
            [JsonProperty("avg_damage_blocked")]
            public double AvgDamageBlocked;
            /// <summary> RU: Средний урон, нанесённый с вашей помощью.Значение считается с версии игры 8.8 <para> EN: Average damage caused with your assistance</para> </summary>
            [JsonProperty("avg_damage_assisted")]
            public double AvgDamageAssisted;
            /// <summary> RU: Средний урон после вашего попадания, сбившего гусеницу. Значение считается с версии игры 8.8 <para> EN: Average damage upon your shooting the track </para> </summary>
            [JsonProperty("avg_damage_assisted_track")]
            public double AvgDamageAssistedTrack;
            /// <summary> RU: Средний урон по вашим разведданным. Значение считается с версии игры 8.8 <para> EN: Average damage upon your spotting </para> </summary>
            [JsonProperty("avg_damage_assisted_radio")]
            public double AvgDamageAssistedRadio;
        }
        public partial class OnlyMax : Base
        {
            /// <summary> RU: Максимальный опыт за бой <para> EN: Maximum experience per battle </para> </summary>
            [JsonProperty("max_xp")]
            public int MaxXp;
            /// <summary> RU: Техника, на которой был нанесён максимальный урон за бой <para> EN: Vehicle used to cause maximum damage </para> </summary>
            [JsonProperty("max_damage_tank_id")]
            public int MaxDamageTankID;
            /// <summary> RU: Техника, на которой получен максимальный опыт за бой <para> EN: Vehicle used to gain maximum experience per battle </para> </summary>
            [JsonProperty("max_xp_tank_id")]
            public int MaxXpTankID;
            /// <summary> RU: Техника, на которой уничтожено максимальное количество противников за бой <para> EN: Vehicle, in which maximum number of enemy vehicles was destroyed </para> </summary>
            [JsonProperty("max_frags_tank_id")]
            public int MaxFragsTankID;
            /// <summary> RU: Максимальный урон за бой <para> EN: Maximum damage caused in a battle </para> </summary>
            [JsonProperty("max_damage")]
            public int MaxDamage;
            /// <summary> RU: Максимум уничтожено за бой <para> EN: Maximum destroyed in battle </para> </summary>
            [JsonProperty("max_frags")]
            public int MaxFrags;
        }
        public partial class MaxAndAvg : OnlyAvg
        {
            /// <summary> RU: Максимальный опыт за бой <para> EN: Maximum experience per battle </para> </summary>
            [JsonProperty("max_xp")]
            public int MaxXp;
            /// <summary> RU: Техника, на которой был нанесён максимальный урон за бой <para> EN: Vehicle used to cause maximum damage </para> </summary>
            [JsonProperty("max_damage_tank_id")]
            public int MaxDamageTankID;
            /// <summary> RU: Техника, на которой получен максимальный опыт за бой <para> EN: Vehicle used to gain maximum experience per battle </para> </summary>
            [JsonProperty("max_xp_tank_id")]
            public int MaxXpTankID;
            /// <summary> RU: Техника, на которой уничтожено максимальное количество противников за бой <para> EN: Vehicle, in which maximum number of enemy vehicles was destroyed </para> </summary>
            [JsonProperty("max_frags_tank_id")]
            public int MaxFragsTankID;
            /// <summary> RU: Максимальный урон за бой <para> EN: Maximum damage caused in a battle </para> </summary>
            [JsonProperty("max_damage")]
            public int MaxDamage;
            /// <summary> RU: Максимум уничтожено за бой <para> EN: Maximum destroyed in battle </para> </summary>
            [JsonProperty("max_frags")]
            public int MaxFrags;
        }
    }
}
