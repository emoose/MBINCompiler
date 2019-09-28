using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0xEDA96D246A6671D9)]
    public class GcFleetGlobals : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x0 */ public string CivilianMPMissionGiverPuzzle;
        /* 0x20 */ public float MaxPurchaseDistance;
        /* 0x24 */ public float DistanceForPurchaseReset;
        /* 0x28 */ public float CombatFrigateSpawnMinRange;
        /* 0x2C */ public float CombatFrigateSpawnAngle;
        /* 0x30 */ public float CombatNotificationTime;
        /* 0x34 */ public float CombatDefenderSpawnDelay;
        /* 0x38 */ public float PostCombatSpawnDelay;
        /* 0x3C */ public float CombatSpawnDelay;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x40 */ public float[] CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x50 */ public int ExplorationPointsRequiredForScan;
        /* 0x54 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x68 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6C */ public byte[] Padding6C;
        [NMS(Size = 0x20)]
        /* 0x70 */ public string FleetCommunicationOSDMessage;
        /* 0x90 */ public int MinFrigateStatValue;
        /* 0x94 */ public int MaxFrigateStatValue;
        /* 0x98 */ public float MinFrigateDistanceFromFreighter;
        /* 0x9C */ public float MaxFrigateDistanceFromFreighter;
        /* 0xA0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0xA4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0xA8 */ public int MaximumSpeedDecrease;
        /* 0xAC */ public int MaximumSpeedIncrease;
        /* 0xB0 */ public float CameraPauseAfterStartingExpedition;
        /* 0xB4 */ public float UITraitLinesAngle;
        [NMS(Size = 0x5, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0xB8 */ public GcFrigateUITraitLines[] UITraitLineLengths;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x11C */ public NMSString0x20[] RacialTermForCaptain;
        /* 0x21C */ public float TimeBeforeShowingHangar;
        /* 0x220 */ public float TimeBeforeHidingHangar;
        /* 0x224 */ public int NumberOfShipsInInitialFleet;

        // Not sure where to place the following chunk as they are all zeros... Going to put at the front but some experimentation may be needed...
        /* 0x228 */ public bool NewFrigatesStartDamaged;
        /* 0x229 */ public bool ExpeditionsCompleteInstantly;
        /* 0x22A */ public bool ShowSeeds;
        /* 0x22B */ public bool DisablePlayerFleets;
        /* 0x22C */ public float ForceDebriefEntryType;
        /* 0x230 */ public int ForcedSequentialEventsStartingIndex;
        /* 0x234 */ public float NextDebriefDescriptionOffset;
        /* 0x238 */ public float Unknown0x238;
        /* 0x23C */ public float Unknown0x23C;
        /* 0x240 */ public float Unknown0x240;
        /* 0x244 */ public float Unknown0x244;
        /* 0x248 */ public float Unknown0x248;
        /* 0x24C */ public float Unknown0x24C;
        /* 0x250 */ public float Unknown0x250;
        /* 0x254 */ public float Unknown0x254;
        /* 0x258 */ public float Unknown0x258;
        // End of unknown chunk...

        /* 0x25C */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x260 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x264 */ public float DamagedListEntryPulseRate;
        /* 0x268 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x26C */ public float LowDamageNumberOfExpeditions;
        /* 0x270 */ public int RampDamageNumberOfExpeditions;
        /* 0x274 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x27C */ public int PercentChanceOfGenericEventDescription;
        /* 0x280 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x284 */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x2A8 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x2CC */ public GcNumberedTextList FrigateBadMoods;
        /* 0x2F0 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x314 */ public float RadiusRequiredForFrigateSpawn;
        /* 0x318 */ public float SpawnDelayForNewFrigates;
        /* 0x31C */ public float SpawnDelayForFleetFrigates;
        /* 0x320 */ public float SpawnDelayForReturningFrigates;
        /* 0x324 */ public float SpawnDelayRandomMin;
        /* 0x328 */ public float SpawnDelayRandomMax;
        /* 0x32C */ public float SpawnDelayIncreasePerFrigate;
        /* 0x330 */ public float DespawnDelay;
        /* 0x334 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x338 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x33C */ public float HologramSwapSpeed;
        [NMS(Size = 0x20)]
        /* 0x340 */ public string TerminalNeedsAssignmentPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x360 */ public string TerminalInterventionPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x380 */ public string TerminalDamagePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3A0 */ public string TerminalActivePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3C0 */ public string TerminalDebriefPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3E0 */ public string NeedFrigatesPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x400 */ public string NewExpeditionsAvailablePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x420 */ public string NeedExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x440 */ public string NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x460 */ public string SelectExpeditionPuzzleID;
        /* 0x480 */ public int NumberOfExpeditionChoices;
        /* 0x484 */ public int ExpeditionDifficultyVariance;
        /* 0x488 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x48C */ public int MinExpeditionStatValue;
        /* 0x490 */ public int MaxExpeditionStatValue;
        /* 0x494 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x498 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x49C */ public int TimeTakenForExpeditionEvent;
        /* 0x4A0 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x4A4 */ public int LightYearsPerExpeditionEvent;
        /* 0x4A8 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x4AC */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Size = 0x3)]
        /* 0x4B0 */ public GcExpeditionPaymentToken[] FreighterTokenProductIDs;
        /* 0x4F8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Size = 0x5)]
        /* 0x598 */ public GcExpeditionPowerup[] Powerups;
        /* 0x750 */ public int FreighterTokenMinimumSpend;
        /* 0x754 */ public float PercentChanceOfInterventionEvent;
        /* 0x758 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x75C */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x760 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x764 */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x768 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x76C */ public int StatPointsAwardedForLevelUp;
        /* 0x770 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x774 */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x778 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x77C */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x780 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x784 */ public float TimeBeforeDebriefLogsStart;
        /* 0x788 */ public bool ShowMissingRewardDescriptions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x789 */ public byte[] Padding789;
        [NMS(Size = 0x20)]
        /* 0x790 */ public string CommunicatorDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x7B0 */ public string FrigateDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x7D0 */ public string FrigatePurchasePuzzleTableEntry;
        [NMS(Size = 0x4)]
        /* 0x7F0 */ public int[] DifficultyModifier;
        [NMS(Size = 0x5)]
        /* 0x800 */ public GcExpeditionDebriefPunctuation[] DebriefPunctuationList;
        /* 0x8B4 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x8C8 */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x8DC */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x8F0 */ public Vector4f FrigateCostMultiplier;
        /* 0x900 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0xC20 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0xE00 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x1300 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x1800 */ public GcScanEffectData FrigateScanEffect;
        /* 0x1850 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x18A0 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x18F0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x1940 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Size = 0x5, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x19A4 */ public NMSString0x80[] FrigateHologramModels;
        [NMS(Size = 0x5, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x1C24 */ public NMSString0x80[] FrigateLODModels;
        [NMS(Size = 0x4)]
        /* 0x1EA4 */ public int[] ExpeditionRankBoundaries;
        [NMS(Size = 0xA)]
        /* 0x1EB4 */ public int[] FrigateLevelVictoriesRequired;
        [NMS(Size = 0x5)]
        /* 0x1EDC */ public GcExpeditionDifficultyKeyframe[] ExpeditionDifficultyKeyframes;
        [NMS(Size = 0xA)]
        /* 0x1F04 */ public NMSString0x80[] FrigateInteriorsToCache;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}
