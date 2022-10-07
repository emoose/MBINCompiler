using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x473F60A83019550D, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x00000 */ public ushort HomeRealityIteration;
        /* 0x00002 */ public ushort RealityIteration;
        // size: 0x11
        public enum DiscoveryWorthEnum {
            Unknown,
            SolarSystem,
            Planet,
            Animal,
            Flora,
            Mineral,
            Sector,
            Building,
            Interactable,
            Sentinel,
            Starship,
            Artifact,
            Mystery,
            Treasure,
            Control,
            HarvestPlant,
            FriendlyDrone
        }
        [NMS(Size = 0x11, EnumType = typeof(DiscoveryWorthEnum))]
        /* 0x00004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        // size: 0x4
        public enum CreatureDiscoverySizeMultiplierEnum {
            Small,
            Medium,
            Large,
            Huge
        }
        [NMS(Size = 0x4, EnumType = typeof(CreatureDiscoverySizeMultiplierEnum))]
        /* 0x001E0 */ public float[] CreatureDiscoverySizeMultiplier;
        /* 0x001F0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x00200 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        /* 0x00400 */ public NMSString0x80 TechnologyTable;
        /* 0x00480 */ public NMSString0x80 SubstanceTable;
        /* 0x00500 */ public NMSString0x80 ProductTable;
        /* 0x00580 */ public NMSString0x80 ProceduralProductTable;
        /* 0x00600 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x00680 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x00700 */ public List<TkRawID> LegacyRepairTable;
        /* 0x00710 */ public NMSString0x80 ConsumableItemTable;
        /* 0x00790 */ public NMSString0x80 RecipeTable;
        /* 0x00810 */ public NMSString0x80 StoriesTable;
        /* 0x00890 */ public NMSString0x80 DialogClearanceTable;
        /* 0x00910 */ public NMSString0x80 AlienWordsTable;
        /* 0x00990 */ public List<NMSString0x80> AlienPuzzleTables;
        // size: 0x83
        public enum LoopInteractionPuzzlesEnum {
            None,
            Shop,
            NPC,
            NPC_Secondary,
            NPC_Anomaly,
            NPC_Anomaly_Secondary,
            Ship,
            Outpost,
            SpaceStation,
            RadioTower,
            Monolith,
            Factory,
            AbandonedShip,
            Harvester,
            Observatory,
            TradingPost,
            DistressBeacon,
            Portal,
            Plaque,
            AtlasStation,
            AbandonedBuildings,
            WeaponTerminal,
            SuitTerminal,
            SignalScanner,
            Teleporter_Base,
            Teleporter_Station,
            ClaimBase,
            NPC_Freighter_Captain,
            NPC_HIRE_Weapons,
            NPC_HIRE_Weapons_Wait,
            NPC_HIRE_Farmer,
            NPC_HIRE_Farmer_Wait,
            NPC_HIRE_Builder,
            NPC_HIRE_Builder_Wait,
            NPC_HIRE_Vehicles,
            NPC_HIRE_Vehicles_Wait,
            MessageBeacon,
            NPC_HIRE_Scientist,
            NPC_HIRE_Scientist_Wait,
            NPC_Recruit,
            NPC_Freighter_Captain_Secondary,
            NPC_Recruit_Secondary,
            Vehicle,
            MessageModule,
            TechShop,
            VehicleRaceStart,
            BuildingShop,
            MissionGiver,
            HoloHub,
            HoloExplorer,
            HoloSceptic,
            HoloNoone,
            PortalRuneEntry,
            PortalActivate,
            CrashedFreighter,
            GraveInCave,
            GlitchyStoryBox,
            NetworkPlayer,
            NetworkMonument,
            AnomalyComputer,
            AtlasPlinth,
            Epilogue,
            GuildEnvoy,
            ManageFleet,
            ManageExpeditions,
            Frigate,
            CustomiseCharacter,
            CustomiseShip,
            CustomiseWeapon,
            CustomiseVehicle,
            ClaimBaseAnywhere,
            FleetNavigator,
            FleetCommandPost,
            StoryUtility,
            MPMissionGiver,
            SpecialsShop,
            WaterRuin,
            LocationScanner,
            ByteBeat,
            NPC_CrashSite,
            NPC_Scavenger,
            BaseGridPart,
            NPC_Freighter_Crew,
            NPC_Freighter_Crew_Owned,
            AbandonedShip_With_NPC,
            ShipPilot,
            NexusMilestones,
            NexusDailyMission,
            CreatureFeeder,
            ExoticExtra1,
            ExoticExtra2,
            ExoticExtra3,
            ExoticExtra4,
            ExoticExtra5,
            ExoticExtra6,
            MapShop,
            NPC_Closure,
            StorageContainer,
            Teleporter_Nexus,
            ShipSalvage,
            ByteBeatSwitch,
            AbandonedFreighterIntro,
            AbandonedFreighterEnd,
            AbandonedFreighterProcText,
            AbandonedFreighterCaptLog,
            AbandonedFreighterCrewLog,
            AbandonedFreighterShop,
            CustomiseFreighter,
            LibraryVault,
            LibraryMainTerminal,
            LibraryMap,
            WeaponUpgrade,
            Pet,
            Creature,
            FreighterGalacticMap,
            RecipeStation,
            StationCore,
            NPC_Settlement_SpecialWorker,
            NPC_Settlement_Secondary,
            SettlementHub,
            SettlementBuildingSite,
            SettlementAdminTerminal,
            FriendlyDrone,
            DroneHive,
            RocketLocker,
            FrigateCaptain,
            PirateShop,
            NPC_PirateSecondary,
            NPC_FreighterBase_SquadronPilot,
            NPC_FreighterBase_FrigateCaptain,
            NPC_FreighterBase_Worker
        }
        [NMS(Size = 0x83, EnumType = typeof(LoopInteractionPuzzlesEnum))]
        /* 0x009A0 */ public bool[] LoopInteractionPuzzles;
        // size: 0x83
        public enum InteractionPuzzlesIndexTypesEnum {
            None,
            Shop,
            NPC,
            NPC_Secondary,
            NPC_Anomaly,
            NPC_Anomaly_Secondary,
            Ship,
            Outpost,
            SpaceStation,
            RadioTower,
            Monolith,
            Factory,
            AbandonedShip,
            Harvester,
            Observatory,
            TradingPost,
            DistressBeacon,
            Portal,
            Plaque,
            AtlasStation,
            AbandonedBuildings,
            WeaponTerminal,
            SuitTerminal,
            SignalScanner,
            Teleporter_Base,
            Teleporter_Station,
            ClaimBase,
            NPC_Freighter_Captain,
            NPC_HIRE_Weapons,
            NPC_HIRE_Weapons_Wait,
            NPC_HIRE_Farmer,
            NPC_HIRE_Farmer_Wait,
            NPC_HIRE_Builder,
            NPC_HIRE_Builder_Wait,
            NPC_HIRE_Vehicles,
            NPC_HIRE_Vehicles_Wait,
            MessageBeacon,
            NPC_HIRE_Scientist,
            NPC_HIRE_Scientist_Wait,
            NPC_Recruit,
            NPC_Freighter_Captain_Secondary,
            NPC_Recruit_Secondary,
            Vehicle,
            MessageModule,
            TechShop,
            VehicleRaceStart,
            BuildingShop,
            MissionGiver,
            HoloHub,
            HoloExplorer,
            HoloSceptic,
            HoloNoone,
            PortalRuneEntry,
            PortalActivate,
            CrashedFreighter,
            GraveInCave,
            GlitchyStoryBox,
            NetworkPlayer,
            NetworkMonument,
            AnomalyComputer,
            AtlasPlinth,
            Epilogue,
            GuildEnvoy,
            ManageFleet,
            ManageExpeditions,
            Frigate,
            CustomiseCharacter,
            CustomiseShip,
            CustomiseWeapon,
            CustomiseVehicle,
            ClaimBaseAnywhere,
            FleetNavigator,
            FleetCommandPost,
            StoryUtility,
            MPMissionGiver,
            SpecialsShop,
            WaterRuin,
            LocationScanner,
            ByteBeat,
            NPC_CrashSite,
            NPC_Scavenger,
            BaseGridPart,
            NPC_Freighter_Crew,
            NPC_Freighter_Crew_Owned,
            AbandonedShip_With_NPC,
            ShipPilot,
            NexusMilestones,
            NexusDailyMission,
            CreatureFeeder,
            ExoticExtra1,
            ExoticExtra2,
            ExoticExtra3,
            ExoticExtra4,
            ExoticExtra5,
            ExoticExtra6,
            MapShop,
            NPC_Closure,
            StorageContainer,
            Teleporter_Nexus,
            ShipSalvage,
            ByteBeatSwitch,
            AbandonedFreighterIntro,
            AbandonedFreighterEnd,
            AbandonedFreighterProcText,
            AbandonedFreighterCaptLog,
            AbandonedFreighterCrewLog,
            AbandonedFreighterShop,
            CustomiseFreighter,
            LibraryVault,
            LibraryMainTerminal,
            LibraryMap,
            WeaponUpgrade,
            Pet,
            Creature,
            FreighterGalacticMap,
            RecipeStation,
            StationCore,
            NPC_Settlement_SpecialWorker,
            NPC_Settlement_Secondary,
            SettlementHub,
            SettlementBuildingSite,
            SettlementAdminTerminal,
            FriendlyDrone,
            DroneHive,
            RocketLocker,
            FrigateCaptain,
            PirateShop,
            NPC_PirateSecondary,
            NPC_FreighterBase_SquadronPilot,
            NPC_FreighterBase_FrigateCaptain,
            NPC_FreighterBase_Worker
        }
        [NMS(Size = 0x83, EnumType = typeof(InteractionPuzzlesIndexTypesEnum))]
        /* 0x00A24 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        // size: 0x7
        public enum WeightingCurvesEnum {
            NoWeighting,
            MaxIsUncommon,
            MaxIsRare,
            MaxIsSuperRare,
            MinIsUncommon,
            MinIsRare,
            MinIsSuperRare
        }
        [NMS(Size = 0x7, EnumType = typeof(WeightingCurvesEnum))]
        /* 0x00C30 */ public TkCurveType[] WeightingCurves;
        /* 0x00C50 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x00C60 */ public NMSString0x80 RewardTable;
        /* 0x00CE0 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x00D60 */ public NMSString0x80 InventoryTable;
        /* 0x00DE0 */ public NMSString0x80 DamageTable;
        /* 0x00E60 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x00EE0 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x00F60 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x00FE0 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x01060 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        /* 0x010E0 */ public NMSString0x80 CostTable;
        /* 0x01160 */ public NMSString0x80 TradingCostTable;
        /* 0x011E0 */ public NMSString0x80 TradingClassDataTable;
        /* 0x01260 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x012E0 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x01360 */ public NMSString0x80 SettlementPerksTable;
        /* 0x013E0 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x01460 */ public NMSString0x80 CombatEffectsTable;
        /* 0x014E0 */ public NMSString0x80 TechBoxTable;
        /* 0x01560 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        // size: 0x7
        public enum ShipWeaponsEnum {
            Laser,
            Projectile,
            Shotgun,
            Minigun,
            Plasma,
            Missile,
            Rocket
        }
        [NMS(Size = 0x7, EnumType = typeof(ShipWeaponsEnum))]
        /* 0x01570 */ public GcShipWeaponData[] ShipWeapons;
        // size: 0x13
        public enum PlayerWeaponsEnum {
            Bolt,
            Shotgun,
            Burst,
            Rail,
            Cannon,
            Laser,
            Grenade,
            MineGrenade,
            Scope,
            FrontShield,
            Melee,
            TerrainEdit,
            SunLaser,
            Spawner,
            SpawnerAlt,
            SoulLaser,
            Flamethrower,
            StunGrenade,
            Stealth
        }
        [NMS(Size = 0x13, EnumType = typeof(PlayerWeaponsEnum))]
        /* 0x01730 */ public GcPlayerWeaponData[] PlayerWeapons;
        // size: 0x7
        public enum DefaultVehicleLoadoutEnum {
            Buggy,
            Bike,
            Truck,
            WheeledBike,
            Hovercraft,
            Submarine,
            Mech
        }
        [NMS(Size = 0x7, EnumType = typeof(DefaultVehicleLoadoutEnum))]
        /* 0x01860 */ public TkIdArray[] DefaultVehicleLoadout;
        // size: 0x9
        public enum FactionStandingIDsEnum {
            Gek,
            Korvax,
            Vykeen,
            TradeGuild,
            WarriorGuild,
            ExplorerGuild,
            Nexus,
            Pirates,
            None
        }
        [NMS(Size = 0x9, EnumType = typeof(FactionStandingIDsEnum))]
        /* 0x018D0 */ public NMSString0x10[] FactionStandingIDs;
        // size: 0x9
        public enum FactionNamesEnum {
            Gek,
            Korvax,
            Vykeen,
            TradeGuild,
            WarriorGuild,
            ExplorerGuild,
            Nexus,
            Pirates,
            None
        }
        [NMS(Size = 0x9, EnumType = typeof(FactionNamesEnum))]
        /* 0x01960 */ public NMSString0x20A[] FactionNames;
        // size: 0x9
        public enum FactionClientsEnum {
            Gek,
            Korvax,
            Vykeen,
            TradeGuild,
            WarriorGuild,
            ExplorerGuild,
            Nexus,
            Pirates,
            None
        }
        [NMS(Size = 0x9, EnumType = typeof(FactionClientsEnum))]
        /* 0x01A80 */ public GcNumberedTextList[] FactionClients;
        // size: 0xB
        public enum MissionNameFormatsEnum {
            SpaceCombat,
            GroundCombat,
            Research,
            MissingPerson,
            Repair,
            Cargo,
            Piracy,
            Photo,
            Feeding,
            Planting,
            Construction
        }
        [NMS(Size = 0xB, EnumType = typeof(MissionNameFormatsEnum))]
        /* 0x01BC4 */ public GcNumberedTextList[] MissionNameFormats;
        // size: 0xB
        public enum MissionNameAdjectivesEnum {
            SpaceCombat,
            GroundCombat,
            Research,
            MissingPerson,
            Repair,
            Cargo,
            Piracy,
            Photo,
            Feeding,
            Planting,
            Construction
        }
        [NMS(Size = 0xB, EnumType = typeof(MissionNameAdjectivesEnum))]
        /* 0x01D50 */ public GcNumberedTextList[] MissionNameAdjectives;
        // size: 0xB
        public enum MissionNameNounsEnum {
            SpaceCombat,
            GroundCombat,
            Research,
            MissingPerson,
            Repair,
            Cargo,
            Piracy,
            Photo,
            Feeding,
            Planting,
            Construction
        }
        [NMS(Size = 0xB, EnumType = typeof(MissionNameNounsEnum))]
        /* 0x01EDC */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0xB)]
        /* 0x02068 */ public TkIdArray[] MissionBoardRewardOptions;
        // size: 0x3
        public enum WeightedTextWeightsEnum {
            Common,
            Uncommon,
            Rare
        }
        [NMS(Size = 0x3, EnumType = typeof(WeightedTextWeightsEnum))]
        /* 0x02118 */ public float[] WeightedTextWeights;
        /* 0x02128 */ public GcRealityIconTable Icons;
        // size: 0x6
        public enum HazardColoursEnum {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation
        }
        [NMS(Size = 0x6, EnumType = typeof(HazardColoursEnum))]
        /* 0x07E40 */ public Colour[] HazardColours;
        // size: 0x3
        public enum RarityColoursEnum {
            Common,
            Uncommon,
            Rare
        }
        [NMS(Size = 0x3, EnumType = typeof(RarityColoursEnum))]
        /* 0x07EA0 */ public Colour[] RarityColours;
        // size: 0x9
        public enum SubstanceCategoryColoursEnum {
            Fuel,
            Metal,
            Catalyst,
            Stellar,
            Flora,
            Earth,
            Exotic,
            Special,
            BuildingPart
        }
        [NMS(Size = 0x9, EnumType = typeof(SubstanceCategoryColoursEnum))]
        /* 0x07ED0 */ public Colour[] SubstanceCategoryColours;
        // size: 0x9
        public enum SubstanceChargeIconsEnum {
            Fuel,
            Metal,
            Catalyst,
            Stellar,
            Flora,
            Earth,
            Exotic,
            Special,
            BuildingPart
        }
        [NMS(Size = 0x9, EnumType = typeof(SubstanceChargeIconsEnum))]
        /* 0x07F60 */ public TkTextureResource[] SubstanceChargeIcons;
        // size: 0xBD
        public enum StatCategoryIconsEnum {
            Unspecified,
            Weapon_Laser,
            Weapon_Laser_Damage,
            Weapon_Laser_Mining_Speed,
            Weapon_Laser_HeatTime,
            Weapon_Laser_Bounce,
            Weapon_Laser_ReloadTime,
            Weapon_Laser_Recoil,
            Weapon_Laser_Drain,
            Weapon_Laser_StrongLaser,
            Weapon_Laser_ChargeTime,
            Weapon_Laser_MiningBonus,
            Weapon_Projectile,
            Weapon_Projectile_Damage,
            Weapon_Projectile_Range,
            Weapon_Projectile_Rate,
            Weapon_Projectile_ClipSize,
            Weapon_Projectile_ReloadTime,
            Weapon_Projectile_Recoil,
            Weapon_Projectile_Bounce,
            Weapon_Projectile_Homing,
            Weapon_Projectile_Dispersion,
            Weapon_Projectile_BulletsPerShot,
            Weapon_Projectile_MinimumCharge,
            Weapon_Projectile_MaximumCharge,
            Weapon_Projectile_BurstCap,
            Weapon_Projectile_BurstCooldown,
            Weapon_ChargedProjectile,
            Weapon_ChargedProjectile_ChargeTime,
            Weapon_ChargedProjectile_CooldownDuration,
            Weapon_ChargedProjectile_Drain,
            Weapon_ChargedProjectile_ExtraSpeed,
            Weapon_Rail,
            Weapon_Shotgun,
            Weapon_Burst,
            Weapon_Flame,
            Weapon_Cannon,
            Weapon_Grenade,
            Weapon_Grenade_Damage,
            Weapon_Grenade_Radius,
            Weapon_Grenade_Speed,
            Weapon_Grenade_Bounce,
            Weapon_Grenade_Homing,
            Weapon_Grenade_Clusterbomb,
            Weapon_TerrainEdit,
            Weapon_SunLaser,
            Weapon_SoulLaser,
            Weapon_MineGrenade,
            Weapon_FrontShield,
            Weapon_Scope,
            Weapon_Spawner,
            Weapon_SpawnerAlt,
            Weapon_Melee,
            Weapon_StunGrenade,
            Weapon_Stealth,
            Weapon_Scan,
            Weapon_Scan_Radius,
            Weapon_Scan_Recharge_Time,
            Weapon_Scan_Types,
            Weapon_Scan_Binoculars,
            Weapon_Scan_Discovery_Creature,
            Weapon_Scan_Discovery_Flora,
            Weapon_Scan_Discovery_Mineral,
            Weapon_Scan_Secondary,
            Weapon_Scan_Terrain_Resource,
            Weapon_Scan_Surveying,
            Weapon_Stun,
            Weapon_Stun_Duration,
            Weapon_Stun_Damage_Multiplier,
            Weapon_FireDOT,
            Weapon_FireDOT_Duration,
            Weapon_FireDOT_DPS,
            Weapon_FireDOT_Damage_Multiplier,
            Suit_Armour_Health,
            Suit_Armour_Shield,
            Suit_Armour_Shield_Strength,
            Suit_Energy,
            Suit_Energy_Regen,
            Suit_Protection,
            Suit_Protection_Cold,
            Suit_Protection_Heat,
            Suit_Protection_Toxic,
            Suit_Protection_Radiation,
            Suit_Underwater,
            Suit_UnderwaterLifeSupport,
            Suit_DamageReduce_Cold,
            Suit_DamageReduce_Heat,
            Suit_DamageReduce_Toxic,
            Suit_DamageReduce_Radiation,
            Suit_Protection_HeatDrain,
            Suit_Protection_ColdDrain,
            Suit_Protection_ToxDrain,
            Suit_Protection_RadDrain,
            Suit_Protection_WaterDrain,
            Suit_Stamina_Strength,
            Suit_Stamina_Speed,
            Suit_Stamina_Recovery,
            Suit_Jetpack,
            Suit_Jetpack_Tank,
            Suit_Jetpack_Drain,
            Suit_Jetpack_Refill,
            Suit_Jetpack_Ignition,
            Suit_Jetpack_DoubleJump,
            Suit_Jetpack_WaterEfficiency,
            Suit_Jetpack_MidairRefill,
            Suit_Refiner,
            Suit_AutoTranslator,
            Suit_Utility,
            Suit_RocketLocker,
            Ship_Weapons_Guns,
            Ship_Weapons_Guns_Damage,
            Ship_Weapons_Guns_Rate,
            Ship_Weapons_Guns_HeatTime,
            Ship_Weapons_Guns_CoolTime,
            Ship_Weapons_Guns_Scale,
            Ship_Weapons_Guns_BulletsPerShot,
            Ship_Weapons_Guns_Dispersion,
            Ship_Weapons_Guns_Range,
            Ship_Weapons_Guns_Damage_Radius,
            Ship_Weapons_Lasers,
            Ship_Weapons_Lasers_Damage,
            Ship_Weapons_Lasers_HeatTime,
            Ship_Weapons_Missiles,
            Ship_Weapons_Missiles_NumPerShot,
            Ship_Weapons_Missiles_Speed,
            Ship_Weapons_Missiles_Damage,
            Ship_Weapons_Missiles_Size,
            Ship_Weapons_Shotgun,
            Ship_Weapons_MiniGun,
            Ship_Weapons_Plasma,
            Ship_Weapons_Rockets,
            Ship_Weapons_ShieldLeech,
            Ship_Armour_Shield,
            Ship_Armour_Shield_Strength,
            Ship_Armour_Health,
            Ship_Scan,
            Ship_Scan_EconomyFilter,
            Ship_Scan_ConflictFilter,
            Ship_Hyperdrive,
            Ship_Hyperdrive_JumpDistance,
            Ship_Hyperdrive_JumpsPerCell,
            Ship_Hyperdrive_QuickWarp,
            Ship_Launcher,
            Ship_Launcher_TakeOffCost,
            Ship_Launcher_AutoCharge,
            Ship_PulseDrive,
            Ship_PulseDrive_MiniJumpFuelSpending,
            Ship_PulseDrive_MiniJumpSpeed,
            Ship_Boost,
            Ship_Maneuverability,
            Ship_BoostManeuverability,
            Ship_LifeSupport,
            Ship_Drift,
            Ship_Teleport,
            Ship_CargoShield,
            Freighter_Hyperdrive,
            Freighter_Hyperdrive_JumpDistance,
            Freighter_Hyperdrive_JumpsPerCell,
            Freighter_MegaWarp,
            Freighter_Teleport,
            Freighter_Fleet_Boost,
            Freighter_Fleet_Speed,
            Freighter_Fleet_Fuel,
            Freighter_Fleet_Combat,
            Freighter_Fleet_Trade,
            Freighter_Fleet_Explore,
            Freighter_Fleet_Mine,
            Vehicle_Boost,
            Vehicle_Engine,
            Vehicle_Scan,
            Vehicle_EngineFuelUse,
            Vehicle_EngineTopSpeed,
            Vehicle_BoostSpeed,
            Vehicle_BoostTanks,
            Vehicle_Grip,
            Vehicle_SkidGrip,
            Vehicle_SubBoostSpeed,
            Vehicle_Laser,
            Vehicle_LaserDamage,
            Vehicle_LaserHeatTime,
            Vehicle_LaserStrongLaser,
            Vehicle_Gun,
            Vehicle_GunDamage,
            Vehicle_GunHeatTime,
            Vehicle_GunRate,
            Vehicle_StunGun,
            Vehicle_TerrainEdit,
            Vehicle_FuelRegen,
            Vehicle_AutoPilot
        }
        [NMS(Size = 0xBD, EnumType = typeof(StatCategoryIconsEnum))]
        /* 0x08404 */ public TkTextureResource[] StatCategoryIcons;
        // size: 0xBD
        public enum StatTechPackageIconsEnum {
            Unspecified,
            Weapon_Laser,
            Weapon_Laser_Damage,
            Weapon_Laser_Mining_Speed,
            Weapon_Laser_HeatTime,
            Weapon_Laser_Bounce,
            Weapon_Laser_ReloadTime,
            Weapon_Laser_Recoil,
            Weapon_Laser_Drain,
            Weapon_Laser_StrongLaser,
            Weapon_Laser_ChargeTime,
            Weapon_Laser_MiningBonus,
            Weapon_Projectile,
            Weapon_Projectile_Damage,
            Weapon_Projectile_Range,
            Weapon_Projectile_Rate,
            Weapon_Projectile_ClipSize,
            Weapon_Projectile_ReloadTime,
            Weapon_Projectile_Recoil,
            Weapon_Projectile_Bounce,
            Weapon_Projectile_Homing,
            Weapon_Projectile_Dispersion,
            Weapon_Projectile_BulletsPerShot,
            Weapon_Projectile_MinimumCharge,
            Weapon_Projectile_MaximumCharge,
            Weapon_Projectile_BurstCap,
            Weapon_Projectile_BurstCooldown,
            Weapon_ChargedProjectile,
            Weapon_ChargedProjectile_ChargeTime,
            Weapon_ChargedProjectile_CooldownDuration,
            Weapon_ChargedProjectile_Drain,
            Weapon_ChargedProjectile_ExtraSpeed,
            Weapon_Rail,
            Weapon_Shotgun,
            Weapon_Burst,
            Weapon_Flame,
            Weapon_Cannon,
            Weapon_Grenade,
            Weapon_Grenade_Damage,
            Weapon_Grenade_Radius,
            Weapon_Grenade_Speed,
            Weapon_Grenade_Bounce,
            Weapon_Grenade_Homing,
            Weapon_Grenade_Clusterbomb,
            Weapon_TerrainEdit,
            Weapon_SunLaser,
            Weapon_SoulLaser,
            Weapon_MineGrenade,
            Weapon_FrontShield,
            Weapon_Scope,
            Weapon_Spawner,
            Weapon_SpawnerAlt,
            Weapon_Melee,
            Weapon_StunGrenade,
            Weapon_Stealth,
            Weapon_Scan,
            Weapon_Scan_Radius,
            Weapon_Scan_Recharge_Time,
            Weapon_Scan_Types,
            Weapon_Scan_Binoculars,
            Weapon_Scan_Discovery_Creature,
            Weapon_Scan_Discovery_Flora,
            Weapon_Scan_Discovery_Mineral,
            Weapon_Scan_Secondary,
            Weapon_Scan_Terrain_Resource,
            Weapon_Scan_Surveying,
            Weapon_Stun,
            Weapon_Stun_Duration,
            Weapon_Stun_Damage_Multiplier,
            Weapon_FireDOT,
            Weapon_FireDOT_Duration,
            Weapon_FireDOT_DPS,
            Weapon_FireDOT_Damage_Multiplier,
            Suit_Armour_Health,
            Suit_Armour_Shield,
            Suit_Armour_Shield_Strength,
            Suit_Energy,
            Suit_Energy_Regen,
            Suit_Protection,
            Suit_Protection_Cold,
            Suit_Protection_Heat,
            Suit_Protection_Toxic,
            Suit_Protection_Radiation,
            Suit_Underwater,
            Suit_UnderwaterLifeSupport,
            Suit_DamageReduce_Cold,
            Suit_DamageReduce_Heat,
            Suit_DamageReduce_Toxic,
            Suit_DamageReduce_Radiation,
            Suit_Protection_HeatDrain,
            Suit_Protection_ColdDrain,
            Suit_Protection_ToxDrain,
            Suit_Protection_RadDrain,
            Suit_Protection_WaterDrain,
            Suit_Stamina_Strength,
            Suit_Stamina_Speed,
            Suit_Stamina_Recovery,
            Suit_Jetpack,
            Suit_Jetpack_Tank,
            Suit_Jetpack_Drain,
            Suit_Jetpack_Refill,
            Suit_Jetpack_Ignition,
            Suit_Jetpack_DoubleJump,
            Suit_Jetpack_WaterEfficiency,
            Suit_Jetpack_MidairRefill,
            Suit_Refiner,
            Suit_AutoTranslator,
            Suit_Utility,
            Suit_RocketLocker,
            Ship_Weapons_Guns,
            Ship_Weapons_Guns_Damage,
            Ship_Weapons_Guns_Rate,
            Ship_Weapons_Guns_HeatTime,
            Ship_Weapons_Guns_CoolTime,
            Ship_Weapons_Guns_Scale,
            Ship_Weapons_Guns_BulletsPerShot,
            Ship_Weapons_Guns_Dispersion,
            Ship_Weapons_Guns_Range,
            Ship_Weapons_Guns_Damage_Radius,
            Ship_Weapons_Lasers,
            Ship_Weapons_Lasers_Damage,
            Ship_Weapons_Lasers_HeatTime,
            Ship_Weapons_Missiles,
            Ship_Weapons_Missiles_NumPerShot,
            Ship_Weapons_Missiles_Speed,
            Ship_Weapons_Missiles_Damage,
            Ship_Weapons_Missiles_Size,
            Ship_Weapons_Shotgun,
            Ship_Weapons_MiniGun,
            Ship_Weapons_Plasma,
            Ship_Weapons_Rockets,
            Ship_Weapons_ShieldLeech,
            Ship_Armour_Shield,
            Ship_Armour_Shield_Strength,
            Ship_Armour_Health,
            Ship_Scan,
            Ship_Scan_EconomyFilter,
            Ship_Scan_ConflictFilter,
            Ship_Hyperdrive,
            Ship_Hyperdrive_JumpDistance,
            Ship_Hyperdrive_JumpsPerCell,
            Ship_Hyperdrive_QuickWarp,
            Ship_Launcher,
            Ship_Launcher_TakeOffCost,
            Ship_Launcher_AutoCharge,
            Ship_PulseDrive,
            Ship_PulseDrive_MiniJumpFuelSpending,
            Ship_PulseDrive_MiniJumpSpeed,
            Ship_Boost,
            Ship_Maneuverability,
            Ship_BoostManeuverability,
            Ship_LifeSupport,
            Ship_Drift,
            Ship_Teleport,
            Ship_CargoShield,
            Freighter_Hyperdrive,
            Freighter_Hyperdrive_JumpDistance,
            Freighter_Hyperdrive_JumpsPerCell,
            Freighter_MegaWarp,
            Freighter_Teleport,
            Freighter_Fleet_Boost,
            Freighter_Fleet_Speed,
            Freighter_Fleet_Fuel,
            Freighter_Fleet_Combat,
            Freighter_Fleet_Trade,
            Freighter_Fleet_Explore,
            Freighter_Fleet_Mine,
            Vehicle_Boost,
            Vehicle_Engine,
            Vehicle_Scan,
            Vehicle_EngineFuelUse,
            Vehicle_EngineTopSpeed,
            Vehicle_BoostSpeed,
            Vehicle_BoostTanks,
            Vehicle_Grip,
            Vehicle_SkidGrip,
            Vehicle_SubBoostSpeed,
            Vehicle_Laser,
            Vehicle_LaserDamage,
            Vehicle_LaserHeatTime,
            Vehicle_LaserStrongLaser,
            Vehicle_Gun,
            Vehicle_GunDamage,
            Vehicle_GunHeatTime,
            Vehicle_GunRate,
            Vehicle_StunGun,
            Vehicle_TerrainEdit,
            Vehicle_FuelRegen,
            Vehicle_AutoPilot
        }
        [NMS(Size = 0xBD, EnumType = typeof(StatTechPackageIconsEnum))]
        /* 0x0E578 */ public TkTextureResource[] StatTechPackageIcons;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle
        }
        [NMS(Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x146F0 */ public GcStats[] Stats;
        /* 0x14740 */ public GcTechList StationTechShops;
        // size: 0x10
        public enum PlanetTechShopsEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(PlanetTechShopsEnum))]
        /* 0x14750 */ public GcTechList[] PlanetTechShops;
        /* 0x14850 */ public GcTradeSettings TradeSettings;
        /* 0x15A30 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0x15A40 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x15A60 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x15A80 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x15AA0 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x15AC0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x15AE0 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0x15B00 */ public List<int> SuitUpgradePrices;
        /* 0x15B10 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x15B20 */ public List<int> SuitCargoUpgradePrices;
        /* 0x15B30 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x15B40 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 0x5)]
        /* 0x15B50 */ public float[] NormalisedPriceLimits;
        /* 0x15B68 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0x15B78 */ public List<GcIDPair> FreighterBaseItemPairs;
        // size: 0x5
        public enum CataloguesEnum {
            MaterialsAndItems,
            CraftingAndTechnology,
            Buildables,
            Recipes,
            Collections
        }
        [NMS(Size = 0x5, EnumType = typeof(CataloguesEnum))]
        /* 0x15B88 */ public NMSString0x80[] Catalogues;
    }
}
