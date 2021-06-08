using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia.Tanks
{
    public class TankInfo : IResponse<TankInfo.TankData>
    {
        public partial class TankData
        {
            [JsonProperty("search")]
            public Info Info;
        }
        public partial class Info
        {
            /// <summary> RU: Показывает, является ли техника колёсной <para> EN: Indicates if the vehicle is a wheeled vehicle </para> </summary>
            [JsonProperty("is_wheeled")]
            public bool IsWheeled;
            /// <summary> RU: Список идентификаторов устанавливаемых радиостанций <para> EN: List of compatible radio IDs  </para> </summary>
            [JsonProperty("radios")]
            public int[] Radios;
            /// <summary> RU: Показывает, является ли техника премиум техникой  <para> EN: Indicates if the vehicle is Premium vehicle  </para> </summary>
            [JsonProperty("is_premium")]
            public bool IsPremium;
            /// <summary> RU: Тег техники  <para> EN: Vehicle tag  </para> </summary>
            [JsonProperty("tag")]
            public string Tag;
            /// <summary> RU: Изображения техники <para> EN: Image links </para> </summary>
            [JsonProperty("images")]
            public Images Images;
            /// <summary> RU: Идентификатор техники <para> EN: Vehicle ID </para> </summary>
            [JsonProperty("tank_id")]
            public int TankID;
            /// <summary> RU: Список идентификаторов совместимых ходовых <para> EN: List of compatible suspension IDs</para> </summary>
            [JsonProperty("suspensions")]
            public int[] Suspensions;
            /// <summary> RU: Список идентификаторов совместимого оборудования и снаряжения <para> EN: List of IDs of compatible equipment and consumables  </para> </summary>
            [JsonProperty("provisions")]
            public int[] Provisions;
            /// <summary> RU: Список идентификаторов совместимых двигателей <para> EN: List of compatible engine IDs  </para> </summary>
            [JsonProperty("engines")]
            public int[] Engines;
            /// <summary> RU: Экипаж <para> EN: Crew </para> </summary>
            [JsonProperty("crew")]
            public List<CrewMember> Crew = new List<CrewMember>();
            /// <summary> RU: Тип техники <para> EN: Vehicle type </para> </summary>
            [JsonProperty("type")]
            public string Type;
            /// <summary> RU: Список идентификаторов совместимых орудий  <para> EN: List of compatible gun IDs  </para> </summary>
            [JsonProperty("guns")]
            public int[] Guns;
            /// <summary> RU: Информация об мультинации <para> EN: Information about multication </para> </summary>
            [JsonProperty("multination")]
            public Dictionary<string, Nation> Multination = new Dictionary<string, Nation>();
            /// <summary> RU: Описание техники <para> EN: Vehicle description </para> </summary>
            [JsonProperty("description")]
            public string Description;
            /// <summary> RU: Сокращённое название техники  <para> EN: Vehicle short name </para> </summary>
            [JsonProperty("short_name")]
            public string ShortName;
            /// <summary> RU: Указывает технику IGR. Действительно только для корейского региона <para> EN: Indicates the IGR vehicle. Active only for Korea realm </para> </summary>
            [JsonProperty("is_premium_igr")]
            public bool IsPremiumIgr;
            /// <summary> RU: Список доступной для исследования техники в виде пар: <para>  - идентификатор исследуемой техники</para><para>  - стоимость исследования в опыте</para> <para> EN: List of vehicles available for research in form of pairs: <para>  - researched vehicle ID</para> <para>  - cost of research in XP</para></para> </summary>
            [JsonProperty("next_tanks")]
            public Dictionary<string, int> NextTanks = new Dictionary<string, int>();
            /// <summary> RU: Информация об исследовании модулей  <para> EN: Module research information</para> </summary>
            [JsonProperty("modules_tree")]
            public Dictionary<string, Module> ModulesTree = new Dictionary<string, Module>();
            /// <summary> RU: Нация <para> EN: Nation </para> </summary>
            [JsonProperty("nation")]
            public string Nation;
            /// <summary> RU: Уровень <para> EN: Tier </para> </summary>
            [JsonProperty("tier")]
            public string Tier;
            /// <summary> RU: Список значений стоимости исследования в виде пар: <para>  - идентификатор родительской техники</para><para>  - стоимость исследованния в опыте</para>   <para> EN: List of research costs in form of pairs: <para>  - parent vehicle ID</para> <para>  - cost of research in XP</para></para> </summary>
            [JsonProperty("prices_xp")]
            public Dictionary<string, int> PricesXp = new Dictionary<string, int>();
            /// <summary> RU: Показывает, является ли техника подарочной  <para> EN: Indicates if the vehicle is a gift vehicle</para> </summary>
            [JsonProperty("is_gift")]
            public bool IsGift;
            /// <summary> RU: Стоимость в золоте <para> EN: Cost in gold </para> </summary>
            [JsonProperty("price_gold")]
            public int PriceGold;
            /// <summary> RU: Стоимость в кредитах<para> EN: Cost in credits  </para> </summary>
            [JsonProperty("price_credit")]
            public int PriceCredit;
            /// <summary> RU: Характеристики базовой комплектации<para> EN: Standard configuration characteristics  </para> </summary>
            [JsonProperty("default_profile")]
            public TankProfile DefaultProfile;
            /// <summary> RU: Список идентификаторов совместимых башен  <para> EN: List of compatible turret IDs </para> </summary>
            [JsonProperty("turrets")]
            public int[] Turrets;
        }
        public partial class TankProfile
        {
            /// <summary> RU: Характеристики двигателя <para> EN: Engine characteristics </para> </summary>
            public TankInfo.Engine Engine;
            /// <summary> RU: Характеристики машин в осадном режиме <para> EN: Vehicle characteristics in Siege mode </para> </summary>
            public TankInfo.Siege Siege;
            /// <summary> RU: Характеристики ходовой <para> EN: Suspension characteristics</para> </summary>
            public TankInfo.Suspension Suspension;
            /// <summary> RU: Бронирование <para> EN: Armor </para> </summary>
            public TankInfo.Armor Armor;
            /// <summary> RU: Характеристики орудия <para> EN: Gun characteristics </para> </summary>
            public TankInfo.Gun Gun;
            /// <summary> RU: Характеристики радиостанции <para> EN: Radio characteristics </para> </summary>
            public TankInfo.Radio Radio;
            /// <summary> RU: Бронирование башни <para> EN: Turret armor </para> </summary>
            public TankInfo.Turret Turret;
            /// <summary> RU: Характеристики машин в скоростном режиме (для колёсной техники) <para> EN: Vehicle characteristics in Rapid mode (for wheeled vehicles) </para> </summary>
            public TankInfo.Rapid Rapid;
            /// <summary> RU: Айди установленных модулей <para> EN: Mounted modules ID's </para> </summary>
            public TankInfo.Modules Modules;
            /// <summary> RU: Харатеристики снарядов орудия <para> EN: Gun shells characteristics </para> </summary>
            public TankInfo.Ammo[] Ammo;
            /// <summary> RU: Боекомплект <para> EN: Ammunition </para> </summary>
            public int MaxAmmo;
            /// <summary> RU: Масса (кг) <para> EN: Weight(kg) </para> </summary>
            public int Weight;
            /// <summary> RU: Прочность <para> EN: Hit points </para> </summary>
            public int Hp;
            /// <summary> RU: Идентификатор комплектации техники <para> EN: Vehicle Configuration ID </para> </summary>
            public string ProfileID;
            /// <summary> RU: Базовая комплектация <para> EN: Standard configuration </para></summary>
            public bool IsDefault;
            /// <summary> RU: Масса корпуса (кг) <para> EN: Hull weight (kg) </para> </summary>
            public int HullWeight;
            /// <summary> RU: Максимальная скорость <para> EN: Top speed (km/h) </para> </summary>
            public int SpeedForward;
            /// <summary> RU: Макс. скорость заднего хода (км/ч) <para> EN: Top reverse speed (km/h) </para> </summary>
            public int SpeedBackward;
            /// <summary> RU: Идентификатор техники <para> EN: Vehicle ID </para> </summary>
            public int TankID;
            /// <summary> RU: Прочность корпуса <para> EN: Hull HP </para></summary>
            public int HullHp;
            /// <summary> RU: Предельная масса(кг) <para> EN: Load limit(kg) </para> </summary>
            public int MaxWeight;
        }
        public partial class Siege
        {
            /// <summary> RU: Скорость поворота базового шасси <para> EN: Standard suspension traverse speed </para> </summary>
            [JsonProperty("suspension_traverse_speed")]
            public int SuspensionTraverseSpeed;
            /// <summary> RU: Угол ВН вниз (град) <para> EN: Depression angle (deg) </para> </summary>
            [JsonProperty("move_down_arc")]
            public int MoveDownArc;
            /// <summary> RU: Время перехода в осадный режим <para> EN: Time required to switch to Siege mode </para> </summary>
            [JsonProperty("switch_on_time")]
            public int SwitchOnTime;
            /// <summary> RU: Время перезарядки (с) <para> EN: Reload time (s) </para> </summary>
            [JsonProperty("reload_time")]
            public double ReloadTime;
            /// <summary> RU: Угол ВН вверх (град) <para> EN: Elevation angle (deg) </para> </summary>
            [JsonProperty("move_up_arc")]
            public int MoveUpArc;
            /// <summary> RU: Разброс на 100 м  <para> EN: Dispersion at 100 m </para> </summary>
            [JsonProperty("dispersion")]
            public double Dispersion;
            /// <summary> RU: Время выхода из осадного режима <para> EN: Time required to switch to Siege mode </para> </summary>
            [JsonProperty("switch_off_time")]
            public double SwitchOffTime;
            /// <summary> RU: Макс. скорость заднего хода (км/ч) <para> EN: Top reverse speed (km/h) </para> </summary>
            [JsonProperty("speed_backward")]
            public int SpeedBackward;
            /// <summary> RU: Время сведения (с)  <para> EN: Aiming time (s) </para> </summary>
            [JsonProperty("aim_time")]
            public double AimTime;
        }
        public partial class Modules
        {
            /// <summary> RU: Идентификатор орудия <para> EN: Gun ID </para> </summary>
            [JsonProperty("gun_id")]
            public int GunID;
            /// <summary> RU: Идентификатор ходовой <para> EN: Suspension ID </para> </summary>
            [JsonProperty("suspension_id")]
            public int SuspensionID;
            /// <summary> RU: Идентификатор башни <para> EN: Turret ID </para> </summary>
            [JsonProperty("turret_id")]
            public int TurretID;
            /// <summary> RU: Идентификатор радиостанции <para> EN: Radio ID </para> </summary>
            [JsonProperty("radio_id")]
            public int RadioID;
            /// <summary> RU: Идентификатор двигателя <para> EN: Engine ID </para> </summary>
            [JsonProperty("engine_id")]
            public int EngineID;
        }
        public partial class Nation
        {
            /// <summary> RU: Признак нации по-умолчанию <para> EN: Default nation attribute </para> </summary>
            [JsonProperty("is_default")]
            public bool IsDefault;
            /// <summary> RU: Идентификатор техники <para> EN: Vehicle ID </para> </summary>
            [JsonProperty("tank_id")]
            public int TankID;
        }
        public partial class Module
        {
            /// <summary> RU: Название модуля  <para> EN: Module name </para> </summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Список идентификаторов модулей, доступных после исследования модуля  <para> EN: List of module IDs available after research of the module </para> </summary>
            [JsonProperty("next_modules")]
            public int[] NextModules;
            /// <summary> RU: Список идентификаторов техники доступной после исследования модуля  <para> EN: List of vehicle IDs available after research of the module </para> </summary>
            [JsonProperty("next_tanks")]
            public int[] NextTanks;
            /// <summary> RU: Показывает, является ли модуль базовым <para> EN: Indicates if the module is basic </para> </summary>
            [JsonProperty("is_default")]
            public bool IsDefault;
            /// <summary> RU: Стоимость исследования  <para> EN: Research cost </para> </summary>
            [JsonProperty("price_xp")]
            public int PriceXp;
            /// <summary> RU: Стоимость в кредитах  <para> EN: Cost in credits </para> </summary>
            [JsonProperty("price_credit")]
            public int PriceCredit;
            /// <summary> RU: Идентификатор модуля  <para> EN: Module ID </para> </summary>
            [JsonProperty("module_id")]
            public int ModuleID;
            /// <summary> RU: Тип модуля  <para> EN: Module type </para> </summary>
            [JsonProperty("type")]
            public string Type;
        }
        public partial class CrewMember
        {
            /// <summary> RU: Список должностей члена экипажа <para> EN: List of crew member roles </para> </summary>
            [JsonProperty("roles")]
            public Dictionary<string, string> Roles = new Dictionary<string, string>();
            /// <summary> RU: Идентификатор члена экипажа <para> EN: Crew member ID </para> </summary>
            [JsonProperty("member_id")]
            public string MemberID;
        }
        public partial class Images
        {
            /// <summary> RU: URL к изображению техники в размере 124 x 31 пкс <para> EN: URL to 124 x 31 px image of vehicle</para> </summary>
            [JsonProperty("small_icon")]
            public string SmallIcon;
            /// <summary> RU: URL к изображению-контуру техники <para> EN: URL to outline image of vehicle </para> </summary>
            [JsonProperty("contour_icon")]
            public string ContourIcon;
            /// <summary> RU: URL к изображению техники в размере 160 x 100 пкс <para> EN: URL to 160 x 100 px image of vehicle </para> </summary>
            [JsonProperty("big_icon")]
            public string BigIcon;
        }
        public partial class Rapid
        {
            /// <summary> RU: Макс. скорость заднего хода (км/ч) <para> EN: Top reverse speed (km/h) </para> </summary>
            [JsonProperty("speed_backward")]
            public int SpeedBackward;
            /// <summary> RU: Время перехода в манёвренный режим <para> EN: Time required to switch to Cruise mode </para> </summary>
            [JsonProperty("switch_off_time")]
            public int SwitchOffTime;
            /// <summary> RU: Время перехода в скоростной режим <para> EN: Time required to switch to Rapid mode </para> </summary>
            [JsonProperty("switch_on_time")]
            public int SwitchOnTime;
            /// <summary> RU: Максимальная скорость (км/ч) <para> EN: Top speed (km/h) </para> </summary>
            [JsonProperty("speed_forward")]
            public int SpeedForward;
            /// <summary> RU: Максимальный угол поворота колёс <para> EN: Maximum wheel turning angle </para> </summary>
            [JsonProperty("suspension_steering_lock_angle")]
            public int SuspensionSteeringLockAngle;
        }
        public partial class Armor
        {
            /// <summary> RU: Бронирование башни <para> EN: Turret armor </para> </summary>
            [JsonProperty("turret")]
            public PartOfArmor Turret;
            /// <summary> RU: Бронирование корпуса <para> EN: Hull armor </para> </summary>
            [JsonProperty("hull")]
            public PartOfArmor Hull;
        }
        public partial class PartOfArmor
        {
            /// <summary> RU: Лоб (мм) <para> EN: Front (mm) </para> </summary>
            [JsonProperty("front")]
            public int Front;
            /// <summary> RU: Борт (мм) <para> EN: Sides (mm) </para> </summary>
            [JsonProperty("sides")]
            public int Sides;
            /// <summary> RU: Корма (мм) <para> EN: Rear (mm) </para> </summary>
            [JsonProperty("rear")]
            public int Rear;
        }
        public partial class Ammo
        {
            /// <summary> RU: Пробитие (мм), в виде списка значений: min, avg, max <para> EN: Penetration (mm), a list of values: min, avg, max </para> </summary>
            [JsonProperty("penetration")]
            public int[] Penetration;
            /// <summary> RU: Характеристики оглушения <para> EN: Stun characteristics </para> </summary>
            [JsonProperty("stun")]
            public AmmoStun Stun;
            /// <summary> RU: Тип снаряда <para> EN: Shell type </para> </summary>
            [JsonProperty("type")]
            public string Type;
            /// <summary> RU: Урон (hp), в виде списка значений: min, avg, max <para> EN: Damage (hp), a list of values: min, avg, max </para> </summary>
            [JsonProperty("damage")]
            public int[] Damage;

            public partial class AmmoStun
            {
                /// <summary> RU: Время оглушения (с), причиняемого данным типом снарядов, в виде списка значений: min, max <para> EN: Stun duration (s) caused by this shell type, a list of values: min, max </para> </summary>
                [JsonProperty("duration")]
                public double[] Duration;
            }
        }
        public class IModule
        {
            /// <summary> RU: Название модуля <para> EN: </para> Module name </summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Тег модуля <para> EN: </para> Module tag </summary>
            [JsonProperty("tag")]
            public string Tag;
            /// <summary> RU: Уровень <para> EN: </para> Tier </summary>
            [JsonProperty("tier")]
            public int Tier;
        }
        public class Engine : IModule
        {
            /// <summary> RU: Мощность двигателя (л.с.) <para> EN: Engine Power (hp) </para> </summary>
            [JsonProperty("power")]
            public int Power;
            /// <summary> RU: Масса (кг) <para> EN: Weight (kg) </para> </summary>
            [JsonProperty("weight")]
            public int Weight;
            /// <summary> RU: Вероятность возгорания <para> EN: Chance of engine fire </para> </summary>
            [JsonProperty("fire_chance")]
            public double FireChance;
        }
        public class Turret : IModule
        {
            /// <summary> RU: Масса (кг) <para> EN: Weight(kg) </para> </summary>
            [JsonProperty("weight")]
            public int Weight;
            /// <summary> RU: Обзор (м) <para> EN: View range (m) </para> </summary>
            [JsonProperty("view_range")]
            public int ViewRange;
            /// <summary> RU: Прочность <para> EN: Hit points </para> </summary>
            [JsonProperty("hp")]
            public int Hp;
            /// <summary> RU: Скорость поворота (град/с) <para> EN: Traverse speed (deg/s) </para> </summary>
            [JsonProperty("traverse_speed")]
            public int TraverseSpeed;
            /// <summary> RU: Угол вращения вправо (град) <para> EN: Traverse angle, right (deg) </para> </summary>
            [JsonProperty("traverse_right_arc")]
            public int TraverseRightArc;
            /// <summary> RU: Угол вращения влево (град) <para> EN: Traverse angle, left (deg) </para> </summary>
            [JsonProperty("traverse_left_arc")]
            public int TraverseLeftArc;
        }
        public class Radio : IModule
        {
            /// <summary> RU: Дальность связи <para> EN: Signal range </para> </summary>
            [JsonProperty("signal_range")]
            public int Signal_Range;
            /// <summary> RU: Масса (кг) <para> EN: </para> Weight (kg) </summary>
            [JsonProperty("weight")]
            public int Weight;
        }
        public class Suspension : IModule
        {
            /// <summary> RU: Масса (кг) <para> EN: Weight (kg) </para> </summary>
            [JsonProperty("weight")]
            public int Weight;
            /// <summary> RU: Максимальная нагрузка (кг) <para> EN: Load limit (kg) </para> </summary>
            [JsonProperty("load_limit")]
            public int Load_Limit;
            /// <summary> RU: Скорость поворота (град/с) <para> EN: Traverse speed (deg/s) </para> </summary>
            [JsonProperty("traverse_speed")]
            public int Traverse_Speed;
            /// <summary> RU: Максимальный угол поворота колёс (для колёсной техники) <para> EN: Maximum wheel turning angle (for wheeled vehicles) </para> </summary>
            [JsonProperty("steering_lock_angle")]
            public int Steering_Lock_Angle;
        }
        public class Gun : IModule
        {
            /// <summary> RU: Угол ВН вниз (град) <para> EN: Depression angle (deg) </para> </summary>
            [JsonProperty("move_down_arc")]
            public int MoveDownArc;
            /// <summary> RU: Калибр (мм) <para> EN: Caliber(mm) </para> </summary>
            [JsonProperty("caliber")]
            public int Caliber;
            /// <summary> RU: Масса (кг) <para> EN: Weight(kg) </para> </summary>
            [JsonProperty("weight")]
            public int Weight;
            /// <summary> RU: Угол ВН вверх (град) <para> EN: Elevation angle (deg) </para> </summary>
            [JsonProperty("move_up_arc")]
            public int Move_Up_Arc;
            /// <summary> RU: Скорострельность (выстр/мин) <para> EN: Rate of fire(rounds/min) </para> </summary>
            [JsonProperty("fire_rate")]
            public double Fire_Rate;
            /// <summary> RU: Разброс на 100 м (м) <para> EN: Dispersion at 100 m (m) </para> </summary>
            [JsonProperty("dispersion")]
            public double Dispersion;
            /// <summary> RU: Скорость поворота(град/с) <para> EN: Traverse speed (deg/s) </para> </summary>
            [JsonProperty("traverse_speed")]
            public int Traverse_Speed;
            /// <summary> RU: Время перезарядки (с) <para> EN: Reload time (s) </para> </summary>
            [JsonProperty("reload_time")]
            public double Reload_Time;
            /// <summary> RU: Время сведения (с) <para> EN: Aiming time (s) </para> </summary>
            [JsonProperty("aim_time")]
            public double Aim_Time;
        }
    }
}
