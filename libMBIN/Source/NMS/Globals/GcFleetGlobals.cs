using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x25388A3CBD9F7658, NameHash = 0xB032629C37506E6A)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        /* 0x0010 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        /* 0x0030 */ public float MaxPurchaseDistance;
        /* 0x0034 */ public float SingleShipFlybyDistance;
        /* 0x0038 */ public float SingleShipFlybyMaxAngle;
        /* 0x003C */ public float SingleShipFlybyHeightOffset;
        /* 0x0040 */ public float DistanceForSingleShipFlybyCommsReset;
        /* 0x0044 */ public float DistanceForPurchaseReset;
        /* 0x0048 */ public float CombatFrigateSpawnMinRange;
        /* 0x004C */ public float CombatFrigateSpawnAngle;
        /* 0x0050 */ public float CombatNotificationTime;
        /* 0x0054 */ public float CombatDefenderSpawnDelay;
        /* 0x0058 */ public float PostCombatSpawnDelay;
        /* 0x005C */ public float CombatSpawnDelay;
        /* 0x0060 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x0070 */ public int ExplorationPointsRequiredForScan;
        /* 0x0074 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x0088 */ public int PercentChangeOfFrigateBeingPurchasable;
        /* 0x0090 */ public NMSString0x20A FleetCommunicationOSDMessage;
        /* 0x00B0 */ public int MinFrigateStatValue;
        /* 0x00B4 */ public int MaxFrigateStatValue;
        /* 0x00B8 */ public float MinFrigateDistanceFromFreighter;
        /* 0x00BC */ public float MaxFrigateDistanceFromFreighter;
        /* 0x00C0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0x00C4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0x00C8 */ public int MaximumSpeedDecrease;
        /* 0x00CC */ public int MaximumSpeedIncrease;
        /* 0x00D0 */ public float CameraPauseAfterStartingExpedition;
        /* 0x00D4 */ public float UITraitLinesAngle;
        /* 0x00D8 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00E8 */ public NMSString0x20[] RacialTermForCaptain;
        /* 0x0208 */ public float TimeBeforeShowingHangar;
        /* 0x020C */ public float TimeBeforeHidingHangar;
        /* 0x0210 */ public int NumberOfShipsInInitialFleet;
        /* 0x0214 */ public bool NewFrigatesStartDamaged;
        /* 0x0215 */ public bool ExpeditionsCompleteInstantly;
        /* 0x0216 */ public bool ShowSeeds;
        /* 0x0217 */ public bool DisablePlayerFleets;
        /* 0x0218 */ public NMSString0x20A DebugInterventionEvent;
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
        /* 0x0238 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x023C */ public int ForcedSequentialEventsStartingIndex;
        /* 0x0240 */ public int NextDebriefDescriptionOffset;
        /* 0x0244 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x0248 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x024C */ public float DamagedListEntryPulseRate;
        /* 0x0250 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x0254 */ public int LowDamageNumberOfExpeditions;
        /* 0x0258 */ public int RampDamageNumberOfExpeditions;
        /* 0x025C */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x0264 */ public int PercentChanceOfGenericEventDescription;
        /* 0x0268 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x026C */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x0290 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x02B4 */ public GcNumberedTextList FrigateBadMoods;
        [NMS(Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x02D8 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        /* 0x0464 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x0488 */ public float RadiusRequiredForFrigateSpawn;
        /* 0x048C */ public float SpawnDelayForNewFrigates;
        /* 0x0490 */ public float SpawnDelayForFleetFrigates;
        /* 0x0494 */ public float SpawnDelayForReturningFrigates;
        /* 0x0498 */ public float SpawnDelayRandomMin;
        /* 0x049C */ public float SpawnDelayRandomMax;
        /* 0x04A0 */ public float SpawnDelayIncreasePerFrigate;
        /* 0x04A4 */ public float DespawnDelay;
        /* 0x04A8 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x04AC */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x04B0 */ public float HologramSwapSpeed;
        /* 0x04B8 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        /* 0x04D8 */ public NMSString0x20A TerminalInterventionPuzzleID;
        /* 0x04F8 */ public NMSString0x20A TerminalDamagePuzzleID;
        /* 0x0518 */ public NMSString0x20A TerminalActivePuzzleID;
        /* 0x0538 */ public NMSString0x20A TerminalDebriefPuzzleID;
        /* 0x0558 */ public NMSString0x20A NormandyActivePuzzleID;
        /* 0x0578 */ public NMSString0x20A NormandyDebriefPuzzleID;
        /* 0x0598 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        /* 0x05B8 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        /* 0x05D8 */ public NMSString0x20A NeedFrigatesPuzzleID;
        /* 0x05F8 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        /* 0x0618 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        /* 0x0638 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        /* 0x0658 */ public NMSString0x20A SelectExpeditionPuzzleID;
        /* 0x0678 */ public int NumberOfExpeditionChoices;
        /* 0x067C */ public int ExpeditionDifficultyVariance;
        /* 0x0680 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x0684 */ public int MinExpeditionStatValue;
        /* 0x0688 */ public int MaxExpeditionStatValue;
        /* 0x068C */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x0690 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x0694 */ public int TimeTakenForExpeditionEvent;
        /* 0x0698 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x069C */ public int LightYearsPerExpeditionEvent;
        /* 0x06A0 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x06A4 */ public int TimeBetweenPassiveIncomeTicks;
        /* 0x06A8 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        /* 0x06B8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        /* 0x07D8 */ public List<GcExpeditionPowerup> Powerups;
        /* 0x07E8 */ public int FreighterTokenMinimumSpend;
        /* 0x07EC */ public int PercentChanceOfInterventionEvent;
        /* 0x07F0 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x07F4 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x07F8 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x07FC */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x0800 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x0804 */ public int StatPointsAwardedForLevelUp;
        /* 0x0808 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x080C */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x0810 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x0814 */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x0818 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x081C */ public float TimeBeforeDebriefLogsStart;
        /* 0x0820 */ public bool ShowMissingRewardDescriptions;
        /* 0x0828 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        /* 0x0848 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        /* 0x0868 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        /* 0x0888 */ public List<int> DifficultyModifier;
        /* 0x0898 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        /* 0x08A8 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x08BC */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x08E0 */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x0904 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        /* 0x0918 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x0C88 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x1030 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x15B0 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x1B30 */ public GcScanEffectData FrigateScanEffect;
        /* 0x1B80 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x1BD0 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x1C20 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x1C70 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x1CC0 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        /* 0x1D28 */ public List<NMSString0x80> FrigateHologramModels;
        /* 0x1D38 */ public List<NMSString0x80> FrigatePlanetModels;
        /* 0x1D48 */ public List<int> ExpeditionRankBoundaries;
        /* 0x1D58 */ public List<int> FrigateLevelVictoriesRequired;
        /* 0x1D68 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        /* 0x1D78 */ public List<NMSString0x80> FrigateInteriorsToCache;
        /* 0x1D88 */ public int NormandyFailures;
        /* 0x1D8C */ public int NormandyDamageEvents;
        /* 0x1D90 */ public List<NMSString0x10> NormandyTraits;
        /* 0x1DA0 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        /* 0x1DB0 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        /* 0x1DC0 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        /* 0x1DD0 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
    }
}
