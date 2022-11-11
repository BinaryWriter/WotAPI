using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia.Vehicle;

[Response("https://{region_site}/wot/encyclopedia/vehicles/?tank_id={search}", true)]
public class Info : ResponseClass<Info.Data>
{
	public class Data
	{
		[JsonProperty("search")] public Details? Info;
	}

	public class Details
	{
		/// <summary>
		///     RU: Экипаж
		///     <para> EN: Crew </para>
		/// </summary>
		[JsonProperty("crew")] public CrewMember[]? Crew;

		/// <summary>
		///     RU: Характеристики базовой комплектации
		///     <para> EN: Standard configuration characteristics  </para>
		/// </summary>
		[JsonProperty("default_profile")] public TankProfile? DefaultProfile;

		/// <summary>
		///     RU: Описание техники
		///     <para> EN: Vehicle description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Список идентификаторов совместимых двигателей
		///     <para> EN: List of compatible engine IDs  </para>
		/// </summary>
		[JsonProperty("engines")] public int[]? Engines;

		/// <summary>
		///     RU: Список идентификаторов совместимых орудий
		///     <para> EN: List of compatible gun IDs  </para>
		/// </summary>
		[JsonProperty("guns")] public int[]? Guns;

		/// <summary>
		///     RU: Изображения техники
		///     <para> EN: Image links </para>
		/// </summary>
		[JsonProperty("images")] public Images? Images;

		/// <summary>
		///     RU: Показывает, является ли техника подарочной
		///     <para> EN: Indicates if the vehicle is a gift vehicle</para>
		/// </summary>
		[JsonProperty("is_gift")] public bool? IsGift;

		/// <summary>
		///     RU: Показывает, является ли техника премиум техникой
		///     <para> EN: Indicates if the vehicle is Premium vehicle  </para>
		/// </summary>
		[JsonProperty("is_premium")] public bool? IsPremium;

		/// <summary>
		///     RU: Указывает технику IGR. Действительно только для корейского региона
		///     <para> EN: Indicates the IGR vehicle. Active only for Korea realm </para>
		/// </summary>
		[JsonProperty("is_premium_igr")] public bool? IsPremiumIgr;

		/// <summary>
		///     RU: Показывает, является ли техника колёсной
		///     <para> EN: Indicates if the vehicle is a wheeled vehicle </para>
		/// </summary>
		[JsonProperty("is_wheeled")] public bool? IsWheeled;

		/// <summary>
		///     RU: Информация об исследовании модулей
		///     <para> EN: Module research information</para>
		/// </summary>
		[JsonProperty("modules_tree")] public Dictionary<string, Module>? ModulesTree = new();

		/// <summary>
		///     RU: Информация об мультинации
		///     <para> EN: Information about multication </para>
		/// </summary>
		[JsonProperty("multination")] public Dictionary<string, Nation>? Multination = new();

		/// <summary>
		///     RU: Нация
		///     <para> EN: Nation </para>
		/// </summary>
		[JsonProperty("nation")] public string? Nation;

		/// <summary>
		///     RU: Список доступной для исследования техники в виде пар:
		///     <para>  - идентификатор исследуемой техники</para>
		///     <para>  - стоимость исследования в опыте</para>
		///     <para>
		///         EN: List of vehicles available for research in form of pairs:
		///         <para>  - researched vehicle ID</para>
		///         <para>  - cost of research in XP</para>
		///     </para>
		/// </summary>
		[JsonProperty("next_tanks")] public Dictionary<string, int>? NextTanks = new();

		/// <summary>
		///     RU: Стоимость в кредитах
		///     <para> EN: Cost in credits  </para>
		/// </summary>
		[JsonProperty("price_credit")] public int? PriceCredit;

		/// <summary>
		///     RU: Стоимость в золоте
		///     <para> EN: Cost in gold </para>
		/// </summary>
		[JsonProperty("price_gold")] public int? PriceGold;

		/// <summary>
		///     RU: Список значений стоимости исследования в виде пар:
		///     <para>  - идентификатор родительской техники</para>
		///     <para>  - стоимость исследованния в опыте</para>
		///     <para>
		///         EN: List of research costs in form of pairs:
		///         <para>  - parent vehicle ID</para>
		///         <para>  - cost of research in XP</para>
		///     </para>
		/// </summary>
		[JsonProperty("prices_xp")] public Dictionary<string, int>? PricesXp = new();

		/// <summary>
		///     RU: Список идентификаторов совместимого оборудования и снаряжения
		///     <para> EN: List of IDs of compatible equipment and consumables  </para>
		/// </summary>
		[JsonProperty("provisions")] public int[]? Provisions;

		/// <summary>
		///     RU: Список идентификаторов устанавливаемых радиостанций
		///     <para> EN: List of compatible radio IDs  </para>
		/// </summary>
		[JsonProperty("radios")] public int[]? Radios;

		/// <summary>
		///     RU: Сокращённое название техники
		///     <para> EN: Vehicle short name </para>
		/// </summary>
		[JsonProperty("short_name")] public string? ShortName;

		/// <summary>
		///     RU: Список идентификаторов совместимых ходовых
		///     <para> EN: List of compatible suspension IDs</para>
		/// </summary>
		[JsonProperty("suspensions")] public int[]? Suspensions;

		/// <summary>
		///     RU: Тег техники
		///     <para> EN: Vehicle tag  </para>
		/// </summary>
		[JsonProperty("tag")] public string? Tag;

		/// <summary>
		///     RU: Идентификатор техники
		///     <para> EN: Vehicle ID </para>
		/// </summary>
		[JsonProperty("tank_id")] public int? TankId;

		/// <summary>
		///     RU: Уровень
		///     <para> EN: Tier </para>
		/// </summary>
		[JsonProperty("tier")] public string? Tier;

		/// <summary>
		///     RU: Список идентификаторов совместимых башен
		///     <para> EN: List of compatible turret IDs </para>
		/// </summary>
		[JsonProperty("turrets")] public int[]? Turrets;

		/// <summary>
		///     RU: Тип техники
		///     <para> EN: Vehicle type </para>
		/// </summary>
		[JsonProperty("type")] public string? Type;
	}

	public class TankProfile
	{
		/// <summary>
		///     RU: Харатеристики снарядов орудия
		///     <para> EN: Gun shells characteristics </para>
		/// </summary>
		[JsonProperty("ammo")] public Ammo[]? Ammo;

		/// <summary>
		///     RU: Бронирование
		///     <para> EN: Armor </para>
		/// </summary>
		[JsonProperty("armor")] public Armor? Armor;

		/// <summary>
		///     RU: Характеристики двигателя
		///     <para> EN: Engine characteristics </para>
		/// </summary>
		[JsonProperty("engine")] public EngineModule? Engine;

		/// <summary>
		///     RU: Характеристики орудия
		///     <para> EN: Gun characteristics </para>
		/// </summary>
		[JsonProperty("gun")] public GunModule? Gun;

		/// <summary>
		///     RU: Прочность
		///     <para> EN: Hit points </para>
		/// </summary>
		[JsonProperty("hp")] public int? Hp;

		/// <summary>
		///     RU: Прочность корпуса
		///     <para> EN: Hull HP </para>
		/// </summary>
		[JsonProperty("hull_hp")] public int? HullHp;

		/// <summary>
		///     RU: Масса корпуса (кг)
		///     <para> EN: Hull weight (kg) </para>
		/// </summary>
		[JsonProperty("hull_weight")] public int? HullWeight;

		/// <summary>
		///     RU: Базовая комплектация
		///     <para> EN: Standard configuration </para>
		/// </summary>
		[JsonProperty("is_default")] public bool IsDefault;

		/// <summary>
		///     RU: Боекомплект
		///     <para> EN: Ammunition </para>
		/// </summary>
		[JsonProperty("max_ammo")] public int? MaxAmmo;

		/// <summary>
		///     RU: Предельная масса(кг)
		///     <para> EN: Load limit(kg) </para>
		/// </summary>
		[JsonProperty("max_weight")] public int? MaxWeight;

		/// <summary>
		///     RU: Айди установленных модулей
		///     <para> EN: Mounted modules ID's </para>
		/// </summary>
		[JsonProperty("modules")] public Modules? Modules;

		/// <summary>
		///     RU: Идентификатор комплектации техники
		///     <para> EN: Vehicle Configuration ID </para>
		/// </summary>
		[JsonProperty("profile_id")] public string? ProfileId;

		/// <summary>
		///     RU: Характеристики радиостанции
		///     <para> EN: Radio characteristics </para>
		/// </summary>
		[JsonProperty("radio")] public RadioModule? Radio;

		/// <summary>
		///     RU: Характеристики машин в скоростном режиме (для колёсной техники)
		///     <para> EN: Vehicle characteristics in Rapid mode (for wheeled vehicles) </para>
		/// </summary>
		[JsonProperty("rapid")] public Rapid? Rapid;

		/// <summary>
		///     RU: Характеристики машин в осадном режиме
		///     <para> EN: Vehicle characteristics in Siege mode </para>
		/// </summary>
		[JsonProperty("siege")] public Siege? Siege;

		/// <summary>
		///     RU: Макс. скорость заднего хода (км/ч)
		///     <para> EN: Top reverse speed (km/h) </para>
		/// </summary>
		[JsonProperty("speed_backward")] public int? SpeedBackward;

		/// <summary>
		///     RU: Максимальная скорость
		///     <para> EN: Top speed (km/h) </para>
		/// </summary>
		[JsonProperty("speed_forward")] public int? SpeedForward;

		/// <summary>
		///     RU: Характеристики ходовой
		///     <para> EN: Suspension characteristics</para>
		/// </summary>
		[JsonProperty("suspensio")] public SuspensionModule? Suspension;

		/// <summary>
		///     RU: Идентификатор техники
		///     <para> EN: Vehicle ID </para>
		/// </summary>
		[JsonProperty("tank_id")] public int? TankId;

		/// <summary>
		///     RU: Бронирование башни
		///     <para> EN: Turret armor </para>
		/// </summary>
		[JsonProperty("turret")] public TurretModule? Turret;

		/// <summary>
		///     RU: Масса (кг)
		///     <para> EN: Weight(kg) </para>
		/// </summary>
		[JsonProperty("weight")] public int? Weight;
	}

	public class Siege
	{
		/// <summary>
		///     RU: Время сведения (с)
		///     <para> EN: Aiming time (s) </para>
		/// </summary>
		[JsonProperty("aim_time")] public double? AimTime;

		/// <summary>
		///     RU: Разброс на 100 м
		///     <para> EN: Dispersion at 100 m </para>
		/// </summary>
		[JsonProperty("dispersion")] public double? Dispersion;

		/// <summary>
		///     RU: Угол ВН вниз (град)
		///     <para> EN: Depression angle (deg) </para>
		/// </summary>
		[JsonProperty("move_down_arc")] public int? MoveDownArc;

		/// <summary>
		///     RU: Угол ВН вверх (град)
		///     <para> EN: Elevation angle (deg) </para>
		/// </summary>
		[JsonProperty("move_up_arc")] public int? MoveUpArc;

		/// <summary>
		///     RU: Время перезарядки (с)
		///     <para> EN: Reload time (s) </para>
		/// </summary>
		[JsonProperty("reload_time")] public double? ReloadTime;

		/// <summary>
		///     RU: Макс. скорость заднего хода (км/ч)
		///     <para> EN: Top reverse speed (km/h) </para>
		/// </summary>
		[JsonProperty("speed_backward")] public int? SpeedBackward;

		/// <summary>
		///     RU: Скорость поворота базового шасси
		///     <para> EN: Standard suspension traverse speed </para>
		/// </summary>
		[JsonProperty("suspension_traverse_speed")] public int? SuspensionTraverseSpeed;

		/// <summary>
		///     RU: Время выхода из осадного режима
		///     <para> EN: Time required to switch to Siege mode </para>
		/// </summary>
		[JsonProperty("switch_off_time")] public double? SwitchOffTime;

		/// <summary>
		///     RU: Время перехода в осадный режим
		///     <para> EN: Time required to switch to Siege mode </para>
		/// </summary>
		[JsonProperty("switch_on_time")] public int? SwitchOnTime;
	}

	public class Modules
	{
		/// <summary>
		///     RU: Идентификатор двигателя
		///     <para> EN: Engine ID </para>
		/// </summary>
		[JsonProperty("engine_id")] public int? EngineId;

		/// <summary>
		///     RU: Идентификатор орудия
		///     <para> EN: Gun ID </para>
		/// </summary>
		[JsonProperty("gun_id")] public int? GunId;

		/// <summary>
		///     RU: Идентификатор радиостанции
		///     <para> EN: Radio ID </para>
		/// </summary>
		[JsonProperty("radio_id")] public int? RadioId;

		/// <summary>
		///     RU: Идентификатор ходовой
		///     <para> EN: Suspension ID </para>
		/// </summary>
		[JsonProperty("suspension_id")] public int? SuspensionId;

		/// <summary>
		///     RU: Идентификатор башни
		///     <para> EN: Turret ID </para>
		/// </summary>
		[JsonProperty("turret_id")] public int? TurretId;
	}

	public class Nation
	{
		/// <summary>
		///     RU: Признак нации по-умолчанию
		///     <para> EN: Default nation attribute </para>
		/// </summary>
		[JsonProperty("is_default")] public bool? IsDefault;

		/// <summary>
		///     RU: Идентификатор техники
		///     <para> EN: Vehicle ID </para>
		/// </summary>
		[JsonProperty("tank_id")] public int? TankId;
	}

	public class ModuleInfo
	{
		/// <summary>
		///     RU: Показывает, является ли модуль базовым
		///     <para> EN: Indicates if the module is basic </para>
		/// </summary>
		[JsonProperty("is_default")] public bool? IsDefault;

		/// <summary>
		///     RU: Идентификатор модуля
		///     <para> EN: Module ID </para>
		/// </summary>
		[JsonProperty("module_id")] public int? ModuleId;

		/// <summary>
		///     RU: Название модуля
		///     <para> EN: Module name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Список идентификаторов модулей, доступных после исследования модуля
		///     <para> EN: List of module IDs available after research of the module </para>
		/// </summary>
		[JsonProperty("next_modules")] public int[]? NextModules;

		/// <summary>
		///     RU: Список идентификаторов техники доступной после исследования модуля
		///     <para> EN: List of vehicle IDs available after research of the module </para>
		/// </summary>
		[JsonProperty("next_tanks")] public int[]? NextTanks;

		/// <summary>
		///     RU: Стоимость в кредитах
		///     <para> EN: Cost in credits </para>
		/// </summary>
		[JsonProperty("price_credit")] public int? PriceCredit;

		/// <summary>
		///     RU: Стоимость исследования
		///     <para> EN: Research cost </para>
		/// </summary>
		[JsonProperty("price_xp")] public int? PriceXp;

		/// <summary>
		///     RU: Тип модуля
		///     <para> EN: Module type </para>
		/// </summary>
		[JsonProperty("type")] public string? Type;
	}

	public class CrewMember
	{
		/// <summary>
		///     RU: Идентификатор члена экипажа
		///     <para> EN: Crew member ID </para>
		/// </summary>
		[JsonProperty("member_id")] public string? MemberId;

		/// <summary>
		///     RU: Список должностей члена экипажа
		///     <para> EN: List of crew member roles </para>
		/// </summary>
		[JsonProperty("roles")] public Dictionary<string, string>? Roles = new();
	}

	public class Images
	{
		/// <summary>
		///     RU: URL к изображению техники в размере 160 x 100 пкс
		///     <para> EN: URL to 160 x 100 px image of vehicle </para>
		/// </summary>
		[JsonProperty("big_icon")] public string? BigIcon;

		/// <summary>
		///     RU: URL к изображению-контуру техники
		///     <para> EN: URL to outline image of vehicle </para>
		/// </summary>
		[JsonProperty("contour_icon")] public string? ContourIcon;

		/// <summary>
		///     RU: URL к изображению техники в размере 124 x 31 пкс
		///     <para> EN: URL to 124 x 31 px image of vehicle</para>
		/// </summary>
		[JsonProperty("small_icon")] public string? SmallIcon;
	}

	public class Rapid
	{
		/// <summary>
		///     RU: Макс. скорость заднего хода (км/ч)
		///     <para> EN: Top reverse speed (km/h) </para>
		/// </summary>
		[JsonProperty("speed_backward")] public int? SpeedBackward;

		/// <summary>
		///     RU: Максимальная скорость (км/ч)
		///     <para> EN: Top speed (km/h) </para>
		/// </summary>
		[JsonProperty("speed_forward")] public int? SpeedForward;

		/// <summary>
		///     RU: Максимальный угол поворота колёс
		///     <para> EN: Maximum wheel turning angle </para>
		/// </summary>
		[JsonProperty("suspension_steering_lock_angle")] public int? SuspensionSteeringLockAngle;

		/// <summary>
		///     RU: Время перехода в манёвренный режим
		///     <para> EN: Time required to switch to Cruise mode </para>
		/// </summary>
		[JsonProperty("switch_off_time")] public int? SwitchOffTime;

		/// <summary>
		///     RU: Время перехода в скоростной режим
		///     <para> EN: Time required to switch to Rapid mode </para>
		/// </summary>
		[JsonProperty("switch_on_time")] public int? SwitchOnTime;
	}

	public class Armor
	{
		/// <summary>
		///     RU: Бронирование корпуса
		///     <para> EN: Hull armor </para>
		/// </summary>
		[JsonProperty("hull")] public PartOfArmor? Hull;

		/// <summary>
		///     RU: Бронирование башни
		///     <para> EN: Turret armor </para>
		/// </summary>
		[JsonProperty("turret")] public PartOfArmor? Turret;
	}

	public class PartOfArmor
	{
		/// <summary>
		///     RU: Лоб (мм)
		///     <para> EN: Front (mm) </para>
		/// </summary>
		[JsonProperty("front")] public int? Front;

		/// <summary>
		///     RU: Корма (мм)
		///     <para> EN: Rear (mm) </para>
		/// </summary>
		[JsonProperty("rear")] public int? Rear;

		/// <summary>
		///     RU: Борт (мм)
		///     <para> EN: Sides (mm) </para>
		/// </summary>
		[JsonProperty("sides")] public int? Sides;
	}

	public class Ammo
	{
		/// <summary>
		///     RU: Урон (hp), в виде списка значений: min, avg, max
		///     <para> EN: Damage (hp), a list of values: min, avg, max </para>
		/// </summary>
		[JsonProperty("damage")] public int[]? Damage;

		/// <summary>
		///     RU: Пробитие (мм), в виде списка значений: min, avg, max
		///     <para> EN: Penetration (mm), a list of values: min, avg, max </para>
		/// </summary>
		[JsonProperty("penetration")] public int[]? Penetration;

		/// <summary>
		///     RU: Характеристики оглушения
		///     <para> EN: Stun characteristics </para>
		/// </summary>
		[JsonProperty("stun")] public AmmoStun? Stun;

		/// <summary>
		///     RU: Тип снаряда
		///     <para> EN: Shell type </para>
		/// </summary>
		[JsonProperty("type")] public string? Type;
	}

	public class AmmoStun
	{
		/// <summary>
		///     RU: Время оглушения (с), причиняемого данным типом снарядов, в виде списка значений: min, max
		///     <para> EN: Stun duration (s) caused by this shell type, a list of values: min, max </para>
		/// </summary>
		[JsonProperty("duration")] public double[]? Duration;
	}

	public class Module
	{
		/// <summary>
		///     RU: Название модуля
		///     <para> EN: Module name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Тег модуля
		///     <para> EN: Module tag </para>
		/// </summary>
		[JsonProperty("tag")] public string? Tag;

		/// <summary>
		///     RU: Уровень
		///     <para> EN: Tier </para>
		/// </summary>
		[JsonProperty("tier")] public int? Tier;
	}

	public class EngineModule : Module
	{
		/// <summary>
		///     RU: Вероятность возгорания
		///     <para> EN: Chance of engine fire </para>
		/// </summary>
		[JsonProperty("fire_chance")] public double? FireChance;

		/// <summary>
		///     RU: Мощность двигателя (л.с.)
		///     <para> EN: Engine Power (hp) </para>
		/// </summary>
		[JsonProperty("power")] public int? Power;

		/// <summary>
		///     RU: Масса (кг)
		///     <para> EN: Weight (kg) </para>
		/// </summary>
		[JsonProperty("weight")] public int? Weight;
	}

	public class TurretModule : Module
	{
		/// <summary>
		///     RU: Прочность
		///     <para> EN: Hit points </para>
		/// </summary>
		[JsonProperty("hp")] public int? Hp;

		/// <summary>
		///     RU: Угол вращения влево (град)
		///     <para> EN: Traverse angle, left (deg) </para>
		/// </summary>
		[JsonProperty("traverse_left_arc")] public int? TraverseLeftArc;

		/// <summary>
		///     RU: Угол вращения вправо (град)
		///     <para> EN: Traverse angle, right (deg) </para>
		/// </summary>
		[JsonProperty("traverse_right_arc")] public int? TraverseRightArc;

		/// <summary>
		///     RU: Скорость поворота (град/с)
		///     <para> EN: Traverse speed (deg/s) </para>
		/// </summary>
		[JsonProperty("traverse_speed")] public int? TraverseSpeed;

		/// <summary>
		///     RU: Обзор (м)
		///     <para> EN: View range (m) </para>
		/// </summary>
		[JsonProperty("view_range")] public int? ViewRange;

		/// <summary>
		///     RU: Масса (кг)
		///     <para> EN: Weight(kg) </para>
		/// </summary>
		[JsonProperty("weight")] public int? Weight;
	}

	public class RadioModule : Module
	{
		/// <summary>
		///     RU: Дальность связи
		///     <para> EN: Signal range </para>
		/// </summary>
		[JsonProperty("signal_range")] public int? SignalRange;

		/// <summary>
		///     RU: Масса (кг)
		///     <para> EN: Weight (kg) </para>
		/// </summary>
		[JsonProperty("weight")] public int? Weight;
	}

	public class SuspensionModule : Module
	{
		/// <summary>
		///     RU: Максимальная нагрузка (кг)
		///     <para> EN: Load limit (kg) </para>
		/// </summary>
		[JsonProperty("load_limit")] public int? LoadLimit;

		/// <summary>
		///     RU: Максимальный угол поворота колёс (для колёсной техники)
		///     <para> EN: Maximum wheel turning angle (for wheeled vehicles) </para>
		/// </summary>
		[JsonProperty("steering_lock_angle")] public int? SteeringLockAngle;

		/// <summary>
		///     RU: Скорость поворота (град/с)
		///     <para> EN: Traverse speed (deg/s) </para>
		/// </summary>
		[JsonProperty("traverse_speed")] public int? TraverseSpeed;

		/// <summary>
		///     RU: Масса (кг)
		///     <para> EN: Weight (kg) </para>
		/// </summary>
		[JsonProperty("weight")] public int? Weight;
	}

	public class GunModule : Module
	{
		/// <summary>
		///     RU: Время сведения (с)
		///     <para> EN: Aiming time (s) </para>
		/// </summary>
		[JsonProperty("aim_time")] public double? AimTime;

		/// <summary>
		///     RU: Калибр (мм)
		///     <para> EN: Caliber(mm) </para>
		/// </summary>
		[JsonProperty("caliber")] public int? Caliber;

		/// <summary>
		///     RU: Разброс на 100 м (м)
		///     <para> EN: Dispersion at 100 m (m) </para>
		/// </summary>
		[JsonProperty("dispersion")] public double? Dispersion;

		/// <summary>
		///     RU: Скорострельность (выстр/мин)
		///     <para> EN: Rate of fire(rounds/min) </para>
		/// </summary>
		[JsonProperty("fire_rate")] public double? FireRate;

		/// <summary>
		///     RU: Угол ВН вниз (град)
		///     <para> EN: Depression angle (deg) </para>
		/// </summary>
		[JsonProperty("move_down_arc")] public int? MoveDownArc;

		/// <summary>
		///     RU: Угол ВН вверх (град)
		///     <para> EN: Elevation angle (deg) </para>
		/// </summary>
		[JsonProperty("move_up_arc")] public int? MoveUpArc;

		/// <summary>
		///     RU: Время перезарядки (с)
		///     <para> EN: Reload time (s) </para>
		/// </summary>
		[JsonProperty("reload_time")] public double? ReloadTime;

		/// <summary>
		///     RU: Скорость поворота(град/с)
		///     <para> EN: Traverse speed (deg/s) </para>
		/// </summary>
		[JsonProperty("traverse_speed")] public int? TraverseSpeed;

		/// <summary>
		///     RU: Масса (кг)
		///     <para> EN: Weight(kg) </para>
		/// </summary>
		[JsonProperty("weight")] public int? Weight;
	}
}