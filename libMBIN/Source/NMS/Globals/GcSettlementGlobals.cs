using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50A0, GUID = 0x2139515D5061A383, NameHash = 0x8652A1B779227539)]
    public class GcSettlementGlobals : NMSTemplate
    {
        /* 0x0000 */ public ulong BuildingUpgradeTimeInSeconds;
        /* 0x0008 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        /* 0x0010 */ public int MaxNPCPopulation;
        /* 0x0014 */ public bool DebugForceShowHiddenPerks;
        /* 0x0018 */ public float SettlementEntryMessageDistance;
        /* 0x0020 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        /* 0x0030 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0038 */ public ulong[] SettlementBuildingTimes;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x01D0 */ public GcSettlementBuildingCost[]  SettlementBuildingCosts;
        /* 0x3B30 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x3B40 */ public GcSettlementStatChangeArray[] SettlementBuildingStatRewards;
        /* 0x3E70 */ public NMSString0x10 SettlementCostGek;
        /* 0x3E80 */ public NMSString0x10 SettlementCostKorvax;
        /* 0x3E90 */ public NMSString0x10 SettlementCostVykeen;
        /* 0x3EA0 */ public int MaxPerksCount;
        /* 0x3EA4 */ public int MinInitialPositivePerksCount;
        /* 0x3EA8 */ public int MaxInitialPositivePerksCount;
        /* 0x3EAC */ public int MinInitialNegativePerksCount;
        /* 0x3EB0 */ public int MaxInitialNegativePerksCount;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3EB4 */ public int[] StatsMinValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3ED0 */ public int[] StatsMaxValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3EEC */ public int[] InitialStatsMinValues;
        /* 0x3F08 */ public int InitialBuildingCountMin;
        /* 0x3F0C */ public int InitialBuildingCountMax;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F10 */ public int[] InitialStatsMaxValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F2C */ public bool[] StatIsGoodWhenPositive;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F34 */ public float[] NormalisedStatBadThresholds;
        [NMS(Size = 0x7)]
        /* 0x3F50 */ public float[] NormalisedStatGoodThresholds;
        /* 0x3F70 */ public Colour PositiveStatColour;
        /* 0x3F80 */ public Colour NegativeStatColour;
        /* 0x3F90 */ public ulong ProductionSlotTimerOffsetInSeconds;
        /* 0x3F98 */ public ulong ProductionCycleDurationInSeconds;
        /* 0x3FA0 */ public ulong AlertCycleDurationInSeconds;
        /* 0x3FA8 */ public int MaxProductionSlotUnits;
        /* 0x3FAC */ public int ProductUnitsPerCycleRateModifier;
        /* 0x3FB0 */ public int SubstanceUnitsPerCycleRateModifier;
        /* 0x3FB4 */ public int InitialDebtCycles;
        /* 0x3FB8 */ public int DailyDebtPaymentModifier;
        /* 0x3FBC */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3FC0 */ public int[] StatProductivityContributionModifiers;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3FDC */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3FE8 */ public NMSString0x10[] PolicyPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4058 */ public NMSString0x10[] ResearchPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x40C8 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4138 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        /* 0x42C0 */ public List<NMSString0x10> GekProductionElements;
        /* 0x42D0 */ public List<NMSString0x10> KorvaxProductionElements;
        /* 0x42E0 */ public List<NMSString0x10> VykeenProductionElements;
        /* 0x42F0 */ public List<NMSString0x10> PoorProductionElements;
        /* 0x4300 */ public List<NMSString0x10> NeutralProductionElements;
        /* 0x4310 */ public List<NMSString0x10> RichProductionElements;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4320 */ public NMSString0x20[] JudgementUpdateTitles;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4400 */ public NMSString0x20[] JudgementUpdateMainText;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x44E0 */ public NMSString0x20[] JudgementUpdateSubtitles;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x45C0 */ public NMSString0x20[] PositiveStatChangeOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x46A0 */ public NMSString0x20[] NegativeStatChangeOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4780 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x47F0 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4860 */ public NMSString0x20[] PositiveFakePerkOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4940 */ public NMSString0x20[] NegativeFakePerkOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4A20 */ public NMSString0x20[] ProcPerkDescriptions;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4B00 */ public NMSString0x20[] ShortPolicyLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4BE0 */ public NMSString0x20[] LongPolicyLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4CC0 */ public NMSString0x20[] ShortResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4DA0 */ public NMSString0x20[] LongResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4E80 */ public NMSString0x20[] ShortAltResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4F60 */ public NMSString0x20[] LongAltResearchLocIDs;
        /* 0x5040 */ public List<GcSettlementGiftDetails> GekGifts;
        /* 0x5050 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        /* 0x5060 */ public List<GcSettlementGiftDetails> VykeenGifts;
        /* 0x5070 */ public List<GcSettlementGiftDetails> Gifts;
        /* 0x5080 */ public List<NMSString0x10> TechGiftPerks;
        /* 0x5090 */ public List<GcSettlementJobDetails> JobTypes;
    }
}
