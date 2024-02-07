using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x2E94A133F3A54F29, NameHash = 0xB032629C37506E6A)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        /* 0x0010 */ public Vector3f PirateFreighterCustomiserSunAngleAdjust;
        /* 0x0020 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        /* 0x0040 */ public float MaxPurchaseDistance;
        /* 0x0044 */ public float SingleShipFlybyDistance;
        /* 0x0048 */ public float SingleShipFlybyMaxAngle;
        /* 0x004C */ public float SingleShipFlybyHeightOffset;
        /* 0x0050 */ public float DistanceForSingleShipFlybyCommsReset;
        /* 0x0054 */ public float DistanceForPurchaseReset;
        /* 0x0058 */ public float CombatFrigateSpawnMinRange;
        /* 0x005C */ public float CombatFrigateSpawnAngle;
        /* 0x0060 */ public float CombatNotificationTime;
        /* 0x0064 */ public float CombatDefenderSpawnDelay;
        /* 0x0068 */ public float PostCombatSpawnDelay;
        /* 0x006C */ public float CombatSpawnDelay;
        /* 0x0070 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x0080 */ public int ExplorationPointsRequiredForScan;
        /* 0x0084 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x0098 */ public int PercentChangeOfFrigateBeingPurchasable;
        /* 0x00A0 */ public NMSString0x20A FleetCommunicationOSDMessage;
        /* 0x00C0 */ public int MinFrigateStatValue;
        /* 0x00C4 */ public int MaxFrigateStatValue;
        /* 0x00C8 */ public float MinFrigateDistanceFromFreighter;
        /* 0x00CC */ public float MaxFrigateDistanceFromFreighter;
        /* 0x00D0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0x00D4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0x00D8 */ public int MaximumSpeedDecrease;
        /* 0x00DC */ public int MaximumSpeedIncrease;
        /* 0x00E0 */ public float CameraPauseAfterStartingExpedition;
        /* 0x00E4 */ public float UITraitLinesAngle;
        /* 0x00E8 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00F8 */ public NMSString0x20[] RacialTermForCaptain;
        /* 0x0218 */ public float TimeBeforeShowingHangar;
        /* 0x021C */ public float TimeBeforeHidingHangar;
        /* 0x0220 */ public int NumberOfShipsInInitialFleet;
        /* 0x0224 */ public bool NewFrigatesStartDamaged;
        /* 0x0225 */ public bool ExpeditionsCompleteInstantly;
        /* 0x0226 */ public bool ShowSeeds;
        /* 0x0227 */ public bool DisablePlayerFleets;
        /* 0x0228 */ public NMSString0x20A DebugInterventionEvent;
        // size: 0xB
        public enum ForceDebriefEntryTypeEnum : uint {
            None,
            PrimarySuccess,
            WhaleSuccess,
            PrimaryFailure,
            PrimaryDamage,
            SecondarySuccess,
            SecondaryFailure,
            SecondaryDamage,
            GenericSuccess,
            GenericFailure,
            WhaleFailure,
        }
        /* 0x0248 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x024C */ public int ForcedSequentialEventsStartingIndex;
        /* 0x0250 */ public int NextDebriefDescriptionOffset;
        /* 0x0254 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x0258 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x025C */ public float DamagedListEntryPulseRate;
        /* 0x0260 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x0264 */ public int LowDamageNumberOfExpeditions;
        /* 0x0268 */ public int RampDamageNumberOfExpeditions;
        /* 0x026C */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x0274 */ public int PercentChanceOfGenericEventDescription;
        /* 0x0278 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x027C */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x02A0 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x02C4 */ public GcNumberedTextList FrigateBadMoods;
        [NMS(Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x02E8 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        /* 0x0474 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x0498 */ public float RadiusRequiredForFrigateSpawn;
        /* 0x049C */ public float SpawnDelayForNewFrigates;
        /* 0x04A0 */ public float SpawnDelayForFleetFrigates;
        /* 0x04A4 */ public float SpawnDelayForReturningFrigates;
        /* 0x04A8 */ public float SpawnDelayRandomMin;
        /* 0x04AC */ public float SpawnDelayRandomMax;
        /* 0x04B0 */ public float SpawnDelayIncreasePerFrigate;
        /* 0x04B4 */ public float DespawnDelay;
        /* 0x04B8 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x04BC */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x04C0 */ public float HologramSwapSpeed;
        /* 0x04C8 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        /* 0x04E8 */ public NMSString0x20A TerminalInterventionPuzzleID;
        /* 0x0508 */ public NMSString0x20A TerminalDamagePuzzleID;
        /* 0x0528 */ public NMSString0x20A TerminalActivePuzzleID;
        /* 0x0548 */ public NMSString0x20A TerminalDebriefPuzzleID;
        /* 0x0568 */ public NMSString0x20A NormandyActivePuzzleID;
        /* 0x0588 */ public NMSString0x20A NormandyDebriefPuzzleID;
        /* 0x05A8 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        /* 0x05C8 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        /* 0x05E8 */ public NMSString0x20A NeedFrigatesPuzzleID;
        /* 0x0608 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        /* 0x0628 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        /* 0x0648 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        /* 0x0668 */ public NMSString0x20A SelectExpeditionPuzzleID;
        /* 0x0688 */ public int NumberOfExpeditionChoices;
        /* 0x068C */ public int ExpeditionDifficultyVariance;
        /* 0x0690 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x0694 */ public int MinExpeditionStatValue;
        /* 0x0698 */ public int MaxExpeditionStatValue;
        /* 0x069C */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x06A0 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x06A4 */ public int TimeTakenForExpeditionEvent;
        /* 0x06A8 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x06AC */ public int LightYearsPerExpeditionEvent;
        /* 0x06B0 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x06B4 */ public int TimeBetweenPassiveIncomeTicks;
        /* 0x06B8 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        /* 0x06C8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        /* 0x07E8 */ public List<GcExpeditionPowerup> Powerups;
        /* 0x07F8 */ public int FreighterTokenMinimumSpend;
        /* 0x07FC */ public int PercentChanceOfInterventionEvent;
        /* 0x0800 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x0804 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x0808 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x080C */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x0810 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x0814 */ public int StatPointsAwardedForLevelUp;
        /* 0x0818 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x081C */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x0820 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x0824 */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x0828 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x082C */ public float TimeBeforeDebriefLogsStart;
        /* 0x0830 */ public bool ShowMissingRewardDescriptions;
        /* 0x0838 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        /* 0x0858 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        /* 0x0878 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        /* 0x0898 */ public List<int> DifficultyModifier;
        /* 0x08A8 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        /* 0x08B8 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x08CC */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x08F0 */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x0914 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        /* 0x0928 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x0C98 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x1040 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x15C0 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x1B40 */ public GcScanEffectData FrigateScanEffect;
        /* 0x1B90 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x1BE0 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x1C30 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x1C80 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x1CD0 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        /* 0x1D38 */ public List<NMSString0x80> FrigateHologramModels;
        /* 0x1D48 */ public List<NMSString0x80> FrigatePlanetModels;
        /* 0x1D58 */ public List<int> ExpeditionRankBoundaries;
        /* 0x1D68 */ public List<int> FrigateLevelVictoriesRequired;
        /* 0x1D78 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        /* 0x1D88 */ public List<NMSString0x80> FrigateInteriorsToCache;
        /* 0x1D98 */ public int NormandyFailures;
        /* 0x1D9C */ public int NormandyDamageEvents;
        /* 0x1DA0 */ public List<NMSString0x10> NormandyTraits;
        /* 0x1DB0 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        /* 0x1DC0 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        /* 0x1DD0 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        /* 0x1DE0 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
    }
}
