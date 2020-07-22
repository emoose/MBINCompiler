using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x2470, GUID = 0xDE9B2EF02F090A8)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string CivilianMPMissionGiverPuzzle;
        /* 0x30 */ public float MaxPurchaseDistance;
        /* 0x34 */ public float DistanceForPurchaseReset;
        /* 0x38 */ public float CombatFrigateSpawnMinRange;
        /* 0x3C */ public float CombatFrigateSpawnAngle;
        /* 0x40 */ public float CombatNotificationTime;
        /* 0x44 */ public float CombatDefenderSpawnDelay;
        /* 0x48 */ public float PostCombatSpawnDelay;
        /* 0x4C */ public float CombatSpawnDelay;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x50 */ public float[] CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x60 */ public int ExplorationPointsRequiredForScan;
        /* 0x64 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x78 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x7C */ public byte[] Padding7C;
        [NMS(Size = 0x20)]
        /* 0x80 */ public string FleetCommunicationOSDMessage;
        /* 0xA0 */ public int MinFrigateStatValue;
        /* 0xA4 */ public int MaxFrigateStatValue;
        /* 0xA8 */ public float MinFrigateDistanceFromFreighter;
        /* 0xAC */ public float MaxFrigateDistanceFromFreighter;
        /* 0xB0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0xB4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0xB8 */ public int MaximumSpeedDecrease;
        /* 0xBC */ public int MaximumSpeedIncrease;
        /* 0xC0 */ public float CameraPauseAfterStartingExpedition;
        /* 0xC4 */ public float UITraitLinesAngle;
        [NMS(Size = 0x5, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0xC8 */ public GcFrigateUITraitLines[] UITraitLineLengths;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x12C */ public NMSString0x20[] RacialTermForCaptain;
        /* 0x22C */ public float TimeBeforeShowingHangar;
        /* 0x230 */ public float TimeBeforeHidingHangar;
        /* 0x234 */ public int NumberOfShipsInInitialFleet;
        /* 0x238 */ public bool NewFrigatesStartDamaged;
        /* 0x239 */ public bool ExpeditionsCompleteInstantly;
        /* 0x23A */ public bool ShowSeeds;
        /* 0x23B */ public bool DisablePlayerFleets;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x23C */ public byte[] Padding23C;
        [NMS(Size = 0x20)]
        /* 0x240 */ public string DebugInterventionEvent;
        public enum ForceDebriefEntryTypeEnum { None, PrimarySuccess, PrimaryFailure, PrimaryDamage,
            SecondarySuccess, SecondaryFailure, SecondaryDamage, GenericSuccess, GenericFailure };
        /* 0x260 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x264 */ public int ForcedSequentialEventsStartingIndex;
        /* 0x268 */ public float NextDebriefDescriptionOffset;
        /* 0x26C */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x270 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x274 */ public float DamagedListEntryPulseRate;
        /* 0x278 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x27C */ public int LowDamageNumberOfExpeditions;
        /* 0x280 */ public int RampDamageNumberOfExpeditions;
        /* 0x284 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x28C */ public int PercentChanceOfGenericEventDescription;
        /* 0x290 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x294 */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x2B8 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x2DC */ public GcNumberedTextList FrigateBadMoods;
        /* 0x300 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x324 */ public float RadiusRequiredForFrigateSpawn;
        /* 0x328 */ public float SpawnDelayForNewFrigates;
        /* 0x32C */ public float SpawnDelayForFleetFrigates;
        /* 0x330 */ public float SpawnDelayForReturningFrigates;
        /* 0x334 */ public float SpawnDelayRandomMin;
        /* 0x338 */ public float SpawnDelayRandomMax;
        /* 0x33C */ public float SpawnDelayIncreasePerFrigate;
        /* 0x340 */ public float DespawnDelay;
        /* 0x344 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x348 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x34C */ public float HologramSwapSpeed;
        [NMS(Size = 0x20)]
        /* 0x350 */ public string TerminalNeedsAssignmentPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x370 */ public string TerminalInterventionPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x390 */ public string TerminalDamagePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3B0 */ public string TerminalActivePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3D0 */ public string TerminalDebriefPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3F0 */ public string NeedFrigatesPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x410 */ public string NewExpeditionsAvailablePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x430 */ public string NeedExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x450 */ public string NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x470 */ public string SelectExpeditionPuzzleID;
        /* 0x490 */ public int NumberOfExpeditionChoices;
        /* 0x494 */ public int ExpeditionDifficultyVariance;
        /* 0x498 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x49C */ public int MinExpeditionStatValue;
        /* 0x4A0 */ public int MaxExpeditionStatValue;
        /* 0x4A4 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x4A8 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x4AC */ public int TimeTakenForExpeditionEvent;
        /* 0x4B0 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x4B4 */ public int LightYearsPerExpeditionEvent;
        /* 0x4B8 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x4BC */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Size = 0x3)]
        /* 0x4C0 */ public GcExpeditionPaymentToken[] FreighterTokenProductIDs;
        /* 0x508 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Size = 0x5)]
        /* 0x5A8 */ public GcExpeditionPowerup[] Powerups;
        /* 0x760 */ public int FreighterTokenMinimumSpend;
        /* 0x764 */ public float PercentChanceOfInterventionEvent;
        /* 0x768 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x76C */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x770 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x774 */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x778 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x77C */ public int StatPointsAwardedForLevelUp;
        /* 0x780 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x784 */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x788 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x78C */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x790 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x794 */ public float TimeBeforeDebriefLogsStart;
        /* 0x798 */ public bool ShowMissingRewardDescriptions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x799 */ public byte[] Padding799;
        [NMS(Size = 0x20)]
        /* 0x7A0 */ public string CommunicatorDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x7C0 */ public string FrigateDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x7E0 */ public string FrigatePurchasePuzzleTableEntry;
        [NMS(Size = 0x4)]
        /* 0x800 */ public int[] DifficultyModifier;
        [NMS(Size = 0x5)]
        /* 0x810 */ public GcExpeditionDebriefPunctuation[] DebriefPunctuationList;
        /* 0x8C4 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x8D8 */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x8EC */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x900 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        /* 0x910 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0xC30 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0xE10 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x1310 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x1810 */ public GcScanEffectData FrigateScanEffect;
        /* 0x1860 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x18B0 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x1900 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x1950 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x19A0 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Size = 0x5, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x1A04 */ public NMSString0x80[] FrigateHologramModels;
        [NMS(Size = 0x5, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x1C84 */ public NMSString0x80[] FrigateLODModels;
        [NMS(Size = 0x4)]
        /* 0x1F04 */ public int[] ExpeditionRankBoundaries;
        [NMS(Size = 0xA)]
        /* 0x1F14 */ public int[] FrigateLevelVictoriesRequired;
        [NMS(Size = 0x5)]
        /* 0x1F3C */ public GcExpeditionDifficultyKeyframe[] ExpeditionDifficultyKeyframes;
        [NMS(Size = 0xA)]
        /* 0x1F64 */ public NMSString0x80[] FrigateInteriorsToCache;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2464 */ public byte[] EndPadding;
    }
}
