using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x5DF4C2715B3155C3, NameHash = 0x8652A1B779227539)]
    public class GcSettlementGlobals : NMSTemplate
    {
        /* 0x0000 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        /* 0x0010 */ public ulong BuildingUpgradeTimeInSeconds;
        /* 0x0018 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        /* 0x0020 */ public int JudgementWaitTimeMin;
        /* 0x0024 */ public int JudgementWaitTimeMax;
        /* 0x0028 */ public float BuildingJudgementPriorityChance;
        /* 0x002C */ public float VisitorJudgementSelector;
        /* 0x0030 */ public float PolicyJudgementSelector;
        /* 0x0034 */ public float RequestJudgementSelector;
        /* 0x0038 */ public float ConflictJudgementSelector;
        /* 0x003C */ public int MaxNPCPopulation;
        /* 0x0040 */ public bool DebugForceShowHiddenPerks;
        /* 0x0044 */ public float SettlementEntryMessageDistance;
        /* 0x0048 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        /* 0x0058 */ public float SettlementMiniExpeditionSuccessChance;
        // size: 0x34
        public enum SettlementBuildingTimesEnum {
            None,
            TerrainResource,
            Shelter,
            Abandoned,
            Terminal,
            Shop,
            Outpost,
            Waypoint,
            Beacon,
            RadioTower,
            Observatory,
            Depot,
            Factory,
            Harvester,
            Plaque,
            Monolith,
            Portal,
            Ruin,
            Debris,
            DamagedMachine,
            DistressSignal,
            LandingPad,
            Base,
            MissionTower,
            CrashedFreighter,
            GraveInCave,
            StoryGlitch,
            TreasureRuins,
            GameStartSpawn,
            WaterCrashedFreighter,
            WaterTreasureRuins,
            WaterAbandoned,
            WaterDistressSignal,
            NPCDistressSignal,
            NPCDebris,
            LargeBuilding,
            Settlement_Hub,
            Settlement_LandingZone,
            Settlement_Bar,
            Settlement_Tower,
            Settlement_Market,
            Settlement_Small,
            Settlement_SmallIndustrial,
            Settlement_Medium,
            Settlement_Large,
            Settlement_Monument,
            Settlement_SheriffsOffice,
            Settlement_Double,
            Settlement_Farm,
            Settlement_Factory,
            Settlement_Clump,
            DroneHive
        }
        [NMS(Size = 0x34, EnumType = typeof(SettlementBuildingTimesEnum))]
        /* 0x0060 */ public ulong[] SettlementBuildingTimes;
        // size: 0x34
        public enum SettlementBuildingCostsEnum {
            None,
            TerrainResource,
            Shelter,
            Abandoned,
            Terminal,
            Shop,
            Outpost,
            Waypoint,
            Beacon,
            RadioTower,
            Observatory,
            Depot,
            Factory,
            Harvester,
            Plaque,
            Monolith,
            Portal,
            Ruin,
            Debris,
            DamagedMachine,
            DistressSignal,
            LandingPad,
            Base,
            MissionTower,
            CrashedFreighter,
            GraveInCave,
            StoryGlitch,
            TreasureRuins,
            GameStartSpawn,
            WaterCrashedFreighter,
            WaterTreasureRuins,
            WaterAbandoned,
            WaterDistressSignal,
            NPCDistressSignal,
            NPCDebris,
            LargeBuilding,
            Settlement_Hub,
            Settlement_LandingZone,
            Settlement_Bar,
            Settlement_Tower,
            Settlement_Market,
            Settlement_Small,
            Settlement_SmallIndustrial,
            Settlement_Medium,
            Settlement_Large,
            Settlement_Monument,
            Settlement_SheriffsOffice,
            Settlement_Double,
            Settlement_Farm,
            Settlement_Factory,
            Settlement_Clump,
            DroneHive
        }
        [NMS(Size = 0x34, EnumType = typeof(SettlementBuildingCostsEnum))]
        /* 0x0200 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        /* 0x3C80 */ public List<GcSettlementJudgementData> Judgements;
        /* 0x3C90 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        // size: 0x34
        public enum SettlementBuildingStatRewardsEnum {
            None,
            TerrainResource,
            Shelter,
            Abandoned,
            Terminal,
            Shop,
            Outpost,
            Waypoint,
            Beacon,
            RadioTower,
            Observatory,
            Depot,
            Factory,
            Harvester,
            Plaque,
            Monolith,
            Portal,
            Ruin,
            Debris,
            DamagedMachine,
            DistressSignal,
            LandingPad,
            Base,
            MissionTower,
            CrashedFreighter,
            GraveInCave,
            StoryGlitch,
            TreasureRuins,
            GameStartSpawn,
            WaterCrashedFreighter,
            WaterTreasureRuins,
            WaterAbandoned,
            WaterDistressSignal,
            NPCDistressSignal,
            NPCDebris,
            LargeBuilding,
            Settlement_Hub,
            Settlement_LandingZone,
            Settlement_Bar,
            Settlement_Tower,
            Settlement_Market,
            Settlement_Small,
            Settlement_SmallIndustrial,
            Settlement_Medium,
            Settlement_Large,
            Settlement_Monument,
            Settlement_SheriffsOffice,
            Settlement_Double,
            Settlement_Farm,
            Settlement_Factory,
            Settlement_Clump,
            DroneHive
        }
        [NMS(Size = 0x34, EnumType = typeof(SettlementBuildingStatRewardsEnum))]
        /* 0x3CA0 */ public GcSettlementStatChangeArray[] SettlementBuildingStatRewards;
        /* 0x3FE0 */ public NMSString0x10 SettlementCostGek;
        /* 0x3FF0 */ public NMSString0x10 SettlementCostKorvax;
        /* 0x4000 */ public NMSString0x10 SettlementCostVykeen;
        /* 0x4010 */ public int MaxPerksCount;
        /* 0x4014 */ public int MinInitialPositivePerksCount;
        /* 0x4018 */ public int MaxInitialPositivePerksCount;
        /* 0x401C */ public int MinInitialNegativePerksCount;
        /* 0x4020 */ public int MaxInitialNegativePerksCount;
        // size: 0x7
        public enum StatsMinValuesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(StatsMinValuesEnum))]
        /* 0x4024 */ public int[] StatsMinValues;
        // size: 0x7
        public enum StatsMaxValuesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(StatsMaxValuesEnum))]
        /* 0x4040 */ public int[] StatsMaxValues;
        // size: 0x7
        public enum InitialStatsMinValuesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(InitialStatsMinValuesEnum))]
        /* 0x405C */ public int[] InitialStatsMinValues;
        /* 0x4078 */ public int InitialBuildingCountMin;
        /* 0x407C */ public int InitialBuildingCountMax;
        // size: 0x7
        public enum InitialStatsMaxValuesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(InitialStatsMaxValuesEnum))]
        /* 0x4080 */ public int[] InitialStatsMaxValues;
        // size: 0x7
        public enum StatIsGoodWhenPositiveEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(StatIsGoodWhenPositiveEnum))]
        /* 0x409C */ public bool[] StatIsGoodWhenPositive;
        // size: 0x7
        public enum NormalisedStatBadThresholdsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(NormalisedStatBadThresholdsEnum))]
        /* 0x40A4 */ public float[] NormalisedStatBadThresholds;
        // size: 0x7
        public enum NormalisedStatGoodThresholdsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(NormalisedStatGoodThresholdsEnum))]
        /* 0x40C0 */ public float[] NormalisedStatGoodThresholds;
        /* 0x40E0 */ public Colour PositiveStatColour;
        /* 0x40F0 */ public Colour NegativeStatColour;
        /* 0x4100 */ public ulong ProductionSlotTimerOffsetInSeconds;
        /* 0x4108 */ public ulong ProductionCycleDurationInSeconds;
        /* 0x4110 */ public ulong AlertCycleDurationInSeconds;
        /* 0x4118 */ public int MaxProductionSlotUnits;
        /* 0x411C */ public int ProductUnitsPerCycleRateModifier;
        /* 0x4120 */ public int SubstanceUnitsPerCycleRateModifier;
        /* 0x4124 */ public int InitialDebtCycles;
        /* 0x4128 */ public int DailyDebtPaymentModifier;
        /* 0x412C */ public int AlertUnitsPerCycleRateModifier;
        // size: 0x7
        public enum StatProductivityContributionModifiersEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(StatProductivityContributionModifiersEnum))]
        /* 0x4130 */ public int[] StatProductivityContributionModifiers;
        // size: 0x7
        public enum StatProductionIsNegativeWhenBadEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(StatProductionIsNegativeWhenBadEnum))]
        /* 0x414C */ public bool[] StatProductionIsNegativeWhenBad;
        // size: 0x7
        public enum PolicyPerksEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(PolicyPerksEnum))]
        /* 0x4158 */ public NMSString0x10[] PolicyPerks;
        // size: 0x7
        public enum ResearchPerksEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(ResearchPerksEnum))]
        /* 0x41C8 */ public NMSString0x10[] ResearchPerks;
        // size: 0x7
        public enum AltResearchPerksEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(AltResearchPerksEnum))]
        /* 0x4238 */ public NMSString0x10[] AltResearchPerks;
        // size: 0x7
        public enum PerkStatStrengthValuesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(PerkStatStrengthValuesEnum))]
        /* 0x42A8 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        /* 0x4430 */ public List<NMSString0x10> GekProductionElements;
        /* 0x4440 */ public List<NMSString0x10> KorvaxProductionElements;
        /* 0x4450 */ public List<NMSString0x10> VykeenProductionElements;
        /* 0x4460 */ public List<NMSString0x10> PoorProductionElements;
        /* 0x4470 */ public List<NMSString0x10> NeutralProductionElements;
        /* 0x4480 */ public List<NMSString0x10> RichProductionElements;
        // size: 0x7
        public enum JudgementUpdateTitlesEnum {
            None,
            StrangerVisit,
            Policy,
            NewBuilding,
            BuildingChoice,
            Conflict,
            Request
        }
        [NMS(Size = 0x7, EnumType = typeof(JudgementUpdateTitlesEnum))]
        /* 0x4490 */ public NMSString0x20A[] JudgementUpdateTitles;
        // size: 0x7
        public enum JudgementUpdateMainTextEnum {
            None,
            StrangerVisit,
            Policy,
            NewBuilding,
            BuildingChoice,
            Conflict,
            Request
        }
        [NMS(Size = 0x7, EnumType = typeof(JudgementUpdateMainTextEnum))]
        /* 0x4570 */ public NMSString0x20A[] JudgementUpdateMainText;
        // size: 0x7
        public enum JudgementUpdateSubtitlesEnum {
            None,
            StrangerVisit,
            Policy,
            NewBuilding,
            BuildingChoice,
            Conflict,
            Request
        }
        [NMS(Size = 0x7, EnumType = typeof(JudgementUpdateSubtitlesEnum))]
        /* 0x4650 */ public NMSString0x20A[] JudgementUpdateSubtitles;
        // size: 0x7
        public enum PositiveStatChangeOSDLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(PositiveStatChangeOSDLocIDsEnum))]
        /* 0x4730 */ public NMSString0x20A[] PositiveStatChangeOSDLocIDs;
        // size: 0x7
        public enum NegativeStatChangeOSDLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(NegativeStatChangeOSDLocIDsEnum))]
        /* 0x4810 */ public NMSString0x20A[] NegativeStatChangeOSDLocIDs;
        // size: 0x7
        public enum PositiveStatChangeSubstancesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(PositiveStatChangeSubstancesEnum))]
        /* 0x48F0 */ public NMSString0x10[] PositiveStatChangeSubstances;
        // size: 0x7
        public enum NegativeStatChangeSubstancesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(NegativeStatChangeSubstancesEnum))]
        /* 0x4960 */ public NMSString0x10[] NegativeStatChangeSubstances;
        // size: 0x7
        public enum PositiveFakePerkOSDLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(PositiveFakePerkOSDLocIDsEnum))]
        /* 0x49D0 */ public NMSString0x20A[] PositiveFakePerkOSDLocIDs;
        // size: 0x7
        public enum NegativeFakePerkOSDLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(NegativeFakePerkOSDLocIDsEnum))]
        /* 0x4AB0 */ public NMSString0x20A[] NegativeFakePerkOSDLocIDs;
        // size: 0x7
        public enum ProcPerkDescriptionsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(ProcPerkDescriptionsEnum))]
        /* 0x4B90 */ public NMSString0x20A[] ProcPerkDescriptions;
        // size: 0x7
        public enum ShortPolicyLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(ShortPolicyLocIDsEnum))]
        /* 0x4C70 */ public NMSString0x20A[] ShortPolicyLocIDs;
        // size: 0x7
        public enum LongPolicyLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(LongPolicyLocIDsEnum))]
        /* 0x4D50 */ public NMSString0x20A[] LongPolicyLocIDs;
        // size: 0x7
        public enum ShortResearchLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(ShortResearchLocIDsEnum))]
        /* 0x4E30 */ public NMSString0x20A[] ShortResearchLocIDs;
        // size: 0x7
        public enum LongResearchLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(LongResearchLocIDsEnum))]
        /* 0x4F10 */ public NMSString0x20A[] LongResearchLocIDs;
        // size: 0x7
        public enum ShortAltResearchLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(ShortAltResearchLocIDsEnum))]
        /* 0x4FF0 */ public NMSString0x20A[] ShortAltResearchLocIDs;
        // size: 0x7
        public enum LongAltResearchLocIDsEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(LongAltResearchLocIDsEnum))]
        /* 0x50D0 */ public NMSString0x20A[] LongAltResearchLocIDs;
        /* 0x51B0 */ public List<GcSettlementGiftDetails> GekGifts;
        /* 0x51C0 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        /* 0x51D0 */ public List<GcSettlementGiftDetails> VykeenGifts;
        /* 0x51E0 */ public List<GcSettlementGiftDetails> Gifts;
        /* 0x51F0 */ public List<NMSString0x10> TechGiftPerks;
        /* 0x5200 */ public List<GcSettlementJobDetails> JobTypes;
    }
}
