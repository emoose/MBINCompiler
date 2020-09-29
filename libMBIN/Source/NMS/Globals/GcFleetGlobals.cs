using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x2470, GUID = 0x0DE9B2EF02F090A8)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        [NMS(Size = 0x20)]
        /* 0x0010 */ public string CivilianMPMissionGiverPuzzle;
        /* 0x0030 */ public float MaxPurchaseDistance;
        /* 0x0034 */ public float DistanceForPurchaseReset;
        /* 0x0038 */ public float CombatFrigateSpawnMinRange;
        /* 0x003C */ public float CombatFrigateSpawnAngle;
        /* 0x0040 */ public float CombatNotificationTime;
        /* 0x0044 */ public float CombatDefenderSpawnDelay;
        /* 0x0048 */ public float PostCombatSpawnDelay;
        /* 0x004C */ public float CombatSpawnDelay;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0050 */ public float[] CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x0060 */ public int ExplorationPointsRequiredForScan;
        /* 0x0064 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x0078 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x007C */ public byte[] Padding7C;
        [NMS(Size = 0x20)]
        /* 0x0080 */ public string FleetCommunicationOSDMessage;
        /* 0x00A0 */ public int MinFrigateStatValue;
        /* 0x00A4 */ public int MaxFrigateStatValue;
        /* 0x00A8 */ public float MinFrigateDistanceFromFreighter;
        /* 0x00AC */ public float MaxFrigateDistanceFromFreighter;
        /* 0x00B0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0x00B4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0x00B8 */ public int MaximumSpeedDecrease;
        /* 0x00BC */ public int MaximumSpeedIncrease;
        /* 0x00C0 */ public float CameraPauseAfterStartingExpedition;
        /* 0x00C4 */ public float UITraitLinesAngle;
        [NMS(Size = 0x5, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x00C8 */ public TkLODDistances[] UITraitLineLengths;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x012C */ public NMSString0x20[] RacialTermForCaptain;
        /* 0x022C */ public float TimeBeforeShowingHangar;
        /* 0x0230 */ public float TimeBeforeHidingHangar;
        /* 0x0234 */ public int NumberOfShipsInInitialFleet;
        /* 0x0238 */ public bool NewFrigatesStartDamaged;
        /* 0x0239 */ public bool ExpeditionsCompleteInstantly;
        /* 0x023A */ public bool ShowSeeds;
        /* 0x023B */ public bool DisablePlayerFleets;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x023C */ public byte[] Padding23C;
        [NMS(Size = 0x20)]
        /* 0x0240 */ public string DebugInterventionEvent;
        public enum ForceDebriefEntryTypeEnum { None, PrimarySuccess, PrimaryFailure, PrimaryDamage,
            SecondarySuccess, SecondaryFailure, SecondaryDamage, GenericSuccess, GenericFailure };
        /* 0x0260 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x0264 */ public int ForcedSequentialEventsStartingIndex;
        /* 0x0268 */ public int NextDebriefDescriptionOffset;
        /* 0x026C */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x0270 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x0274 */ public float DamagedListEntryPulseRate;
        /* 0x0278 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x027C */ public int LowDamageNumberOfExpeditions;
        /* 0x0280 */ public int RampDamageNumberOfExpeditions;
        /* 0x0284 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x028C */ public int PercentChanceOfGenericEventDescription;
        /* 0x0290 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x0294 */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x02B8 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x02DC */ public GcNumberedTextList FrigateBadMoods;
        /* 0x0300 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x0324 */ public float RadiusRequiredForFrigateSpawn;
        /* 0x0328 */ public float SpawnDelayForNewFrigates;
        /* 0x032C */ public float SpawnDelayForFleetFrigates;
        /* 0x0330 */ public float SpawnDelayForReturningFrigates;
        /* 0x0334 */ public float SpawnDelayRandomMin;
        /* 0x0338 */ public float SpawnDelayRandomMax;
        /* 0x033C */ public float SpawnDelayIncreasePerFrigate;
        /* 0x0340 */ public float DespawnDelay;
        /* 0x0344 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x0348 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x034C */ public float HologramSwapSpeed;
        [NMS(Size = 0x20)]
        /* 0x0350 */ public string TerminalNeedsAssignmentPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0370 */ public string TerminalInterventionPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0390 */ public string TerminalDamagePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x03B0 */ public string TerminalActivePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x03D0 */ public string TerminalDebriefPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x03F0 */ public string NeedFrigatesPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0410 */ public string NewExpeditionsAvailablePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0430 */ public string NeedExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0450 */ public string NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0470 */ public string SelectExpeditionPuzzleID;
        /* 0x0490 */ public int NumberOfExpeditionChoices;
        /* 0x0494 */ public int ExpeditionDifficultyVariance;
        /* 0x0498 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x049C */ public int MinExpeditionStatValue;
        /* 0x04A0 */ public int MaxExpeditionStatValue;
        /* 0x04A4 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x04A8 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x04AC */ public int TimeTakenForExpeditionEvent;
        /* 0x04B0 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x04B4 */ public int LightYearsPerExpeditionEvent;
        /* 0x04B8 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x04BC */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Size = 0x3)]
        /* 0x04C0 */ public GcExpeditionPaymentToken[] FreighterTokenProductIDs;
        /* 0x0508 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Size = 0x5)]
        /* 0x05A8 */ public GcExpeditionPowerup[] Powerups;
        /* 0x0760 */ public int FreighterTokenMinimumSpend;
        /* 0x0764 */ public int PercentChanceOfInterventionEvent;
        /* 0x0768 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x076C */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x0770 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x0774 */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x0778 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x077C */ public int StatPointsAwardedForLevelUp;
        /* 0x0780 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x0784 */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x0788 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x078C */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x0790 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x0794 */ public float TimeBeforeDebriefLogsStart;
        /* 0x0798 */ public bool ShowMissingRewardDescriptions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x0799 */ public byte[] Padding799;
        [NMS(Size = 0x20)]
        /* 0x07A0 */ public string CommunicatorDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x07C0 */ public string FrigateDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x07E0 */ public string FrigatePurchasePuzzleTableEntry;
        [NMS(Size = 0x4)]
        /* 0x0800 */ public int[] DifficultyModifier;
        [NMS(Size = 0x5)]
        /* 0x0810 */ public GcExpeditionDebriefPunctuation[] DebriefPunctuationList;
        /* 0x08C4 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x08D8 */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x08EC */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x0900 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        /* 0x0910 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x0C30 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x0E10 */ public GcFrigateTraitIcons TraitIcons;
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
        /* 0x1C84 */ public NMSString0x80[] FrigatePlanetModels;
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
