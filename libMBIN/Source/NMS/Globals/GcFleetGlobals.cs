using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x33D9367C22FCB796, NameHash = 0xCD2E438C)]
    public class GcFleetGlobals : NMSTemplate
    {
        [NMS(Index = 129)]
        /* 0x0000 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        [NMS(Index = 130)]
        /* 0x0050 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        [NMS(Index = 131)]
        /* 0x00A0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        [NMS(Index = 128)]
        /* 0x00F0 */ public GcScanEffectData FrigateHologramScanEffect;
        [NMS(Index = 127)]
        /* 0x0140 */ public GcScanEffectData FrigateScanEffect;
        [NMS(Index = 0)]
        /* 0x0190 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        [NMS(Index = 1)]
        /* 0x01A0 */ public Vector3f PirateFreighterCustomiserSunAngleAdjust;
        [NMS(Index = 124)]
        /* 0x01B0 */ public GcFrigateStatsByClass FrigateInitialStats;
        [NMS(Index = 123)]
        /* 0x0628 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        [NMS(Index = 97)]
        /* 0x0998 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Index = 55, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0AF8 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        [NMS(Index = 126)]
        /* 0x0C00 */ public GcFrigateTraitIcons NegativeTraitIcons;
        [NMS(Index = 125)]
        /* 0x0CB0 */ public GcFrigateTraitIcons TraitIcons;
        [NMS(Index = 2)]
        /* 0x0D60 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        [NMS(Index = 114)]
        /* 0x0D80 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        [NMS(Index = 77)]
        /* 0x0DA0 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        [NMS(Index = 78)]
        /* 0x0DC0 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        [NMS(Index = 19)]
        /* 0x0DE0 */ public NMSString0x20A FleetCommunicationOSDMessage;
        [NMS(Index = 115)]
        /* 0x0E00 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        [NMS(Index = 116)]
        /* 0x0E20 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        [NMS(Index = 82)]
        /* 0x0E40 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Index = 81)]
        /* 0x0E60 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        [NMS(Index = 79)]
        /* 0x0E80 */ public NMSString0x20A NeedFrigatesPuzzleID;
        [NMS(Index = 80)]
        /* 0x0EA0 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        [NMS(Index = 75)]
        /* 0x0EC0 */ public NMSString0x20A NormandyActivePuzzleID;
        [NMS(Index = 76)]
        /* 0x0EE0 */ public NMSString0x20A NormandyDebriefPuzzleID;
        [NMS(Index = 83)]
        /* 0x0F00 */ public NMSString0x20A SelectExpeditionPuzzleID;
        [NMS(Index = 73)]
        /* 0x0F20 */ public NMSString0x20A TerminalActivePuzzleID;
        [NMS(Index = 72)]
        /* 0x0F40 */ public NMSString0x20A TerminalDamagePuzzleID;
        [NMS(Index = 74)]
        /* 0x0F60 */ public NMSString0x20A TerminalDebriefPuzzleID;
        [NMS(Index = 71)]
        /* 0x0F80 */ public NMSString0x20A TerminalInterventionPuzzleID;
        [NMS(Index = 70)]
        /* 0x0FA0 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        [NMS(Index = 54)]
        /* 0x0FC0 */ public GcNumberedTextList FrigateBadMoods;
        [NMS(Index = 52)]
        /* 0x0FD8 */ public GcNumberedTextList FrigateDamageDescriptions;
        [NMS(Index = 56)]
        /* 0x0FF0 */ public GcNumberedTextList FrigateExtraNotes;
        [NMS(Index = 53)]
        /* 0x1008 */ public GcNumberedTextList FrigateGoodMoods;
        [NMS(Index = 15)]
        /* 0x1020 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        [NMS(Index = 118)]
        /* 0x1030 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        [NMS(Index = 144)]
        /* 0x1040 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        [NMS(Index = 143)]
        /* 0x1050 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        [NMS(Index = 117)]
        /* 0x1060 */ public List<int> DifficultyModifier;
        [NMS(Index = 137)]
        /* 0x1070 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        [NMS(Index = 135)]
        /* 0x1080 */ public List<int> ExpeditionRankBoundaries;
        [NMS(Index = 96)]
        /* 0x1090 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        [NMS(Index = 145)]
        /* 0x10A0 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        [NMS(Index = 133)]
        /* 0x10B0 */ public List<GcFilename> FrigateHologramModels;
        [NMS(Index = 138)]
        /* 0x10C0 */ public List<GcFilename> FrigateInteriorsToCache;
        [NMS(Index = 136)]
        /* 0x10D0 */ public List<int> FrigateLevelVictoriesRequired;
        [NMS(Index = 134)]
        /* 0x10E0 */ public List<GcFilename> FrigatePlanetModels;
        [NMS(Index = 142)]
        /* 0x10F0 */ public List<NMSString0x10> GhostShipFrigateTraits;
        [NMS(Index = 141)]
        /* 0x1100 */ public List<NMSString0x10> NormandyTraits;
        [NMS(Index = 98)]
        /* 0x1110 */ public List<GcExpeditionPowerup> Powerups;
        [NMS(Index = 30)]
        /* 0x1120 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        [NMS(Index = 132)]
        /* 0x1130 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Index = 120)]
        /* 0x1194 */ public GcFrigateClassCost FrigateBaseCost;
        [NMS(Index = 121)]
        /* 0x11C0 */ public GcFrigateClassCost FrigateCostVariance;
        [NMS(Index = 119)]
        /* 0x11EC */ public GcExpeditionDurationValues ExpeditionDurations;
        [NMS(Index = 17)]
        /* 0x1200 */ public GcInteractionDof FleetInteractionDepthOfField;
        [NMS(Index = 122)]
        /* 0x1214 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        [NMS(Index = 49)]
        /* 0x1224 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        [NMS(Index = 28)]
        /* 0x122C */ public float CameraPauseAfterStartingExpedition;
        [NMS(Index = 12)]
        /* 0x1230 */ public float CombatDefenderSpawnDelay;
        [NMS(Index = 10)]
        /* 0x1234 */ public float CombatFrigateSpawnAngle;
        [NMS(Index = 9)]
        /* 0x1238 */ public float CombatFrigateSpawnMinRange;
        [NMS(Index = 11)]
        /* 0x123C */ public float CombatNotificationTime;
        [NMS(Index = 14)]
        /* 0x1240 */ public float CombatSpawnDelay;
        [NMS(Index = 45)]
        /* 0x1244 */ public float DamagedListEntryPulseRate;
        [NMS(Index = 66)]
        /* 0x1248 */ public float DespawnDelay;
        [NMS(Index = 67)]
        /* 0x124C */ public float DespawnDelayIncreasePerFrigate;
        [NMS(Index = 104)]
        /* 0x1250 */ public float DifficultyMultiplierForBalancedExpeditions;
        [NMS(Index = 105)]
        /* 0x1254 */ public float DifficultyMultiplierForNonPrimaryEvents;
        [NMS(Index = 8)]
        /* 0x1258 */ public float DistanceForPurchaseReset;
        [NMS(Index = 7)]
        /* 0x125C */ public float DistanceForSingleShipFlybyCommsReset;
        [NMS(Index = 86)]
        /* 0x1260 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        [NMS(Index = 85)]
        /* 0x1264 */ public int ExpeditionDifficultyVariance;
        [NMS(Index = 16)]
        /* 0x1268 */ public int ExplorationPointsRequiredForScan;
        [NMS(Index = 101)]
        /* 0x126C */ public int FirstEventIndexWhichCanBeIntervention;
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
        [NMS(Index = 40)]
        /* 0x1270 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        [NMS(Index = 41)]
        /* 0x1274 */ public int ForcedSequentialEventsStartingIndex;
        [NMS(Index = 99)]
        /* 0x1278 */ public int FreighterTokenMinimumSpend;
        [NMS(Index = 24)]
        /* 0x127C */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        [NMS(Index = 68)]
        /* 0x1280 */ public float FrigatesPerSecondForInstantSpawn;
        [NMS(Index = 69)]
        /* 0x1284 */ public float HologramSwapSpeed;
        [NMS(Index = 43)]
        /* 0x1288 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        [NMS(Index = 93)]
        /* 0x128C */ public int LightYearsPerExpeditionEvent;
        [NMS(Index = 92)]
        /* 0x1290 */ public int LightYearsPerExpeditionEvent_Easy;
        [NMS(Index = 47)]
        /* 0x1294 */ public int LowDamageNumberOfExpeditions;
        [NMS(Index = 103)]
        /* 0x1298 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        [NMS(Index = 88)]
        /* 0x129C */ public int MaxExpeditionStatValue;
        [NMS(Index = 23)]
        /* 0x12A0 */ public float MaxFrigateDistanceFromFreighter;
        [NMS(Index = 21)]
        /* 0x12A4 */ public int MaxFrigateStatValue;
        [NMS(Index = 108)]
        /* 0x12A8 */ public int MaxGapBetweenExpeditionLogEntries;
        [NMS(Index = 26)]
        /* 0x12AC */ public int MaximumSpeedDecrease;
        [NMS(Index = 27)]
        /* 0x12B0 */ public int MaximumSpeedIncrease;
        [NMS(Index = 146)]
        /* 0x12B4 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
        [NMS(Index = 3)]
        /* 0x12B8 */ public float MaxPurchaseDistance;
        [NMS(Index = 87)]
        /* 0x12BC */ public int MinExpeditionStatValue;
        [NMS(Index = 22)]
        /* 0x12C0 */ public float MinFrigateDistanceFromFreighter;
        [NMS(Index = 20)]
        /* 0x12C4 */ public int MinFrigateStatValue;
        [NMS(Index = 107)]
        /* 0x12C8 */ public int MinGapBetweenExpeditionLogEntries;
        [NMS(Index = 42)]
        /* 0x12CC */ public int NextDebriefDescriptionOffset;
        [NMS(Index = 46)]
        /* 0x12D0 */ public float NonUrgentDamagedListEntryAlpha;
        [NMS(Index = 140)]
        /* 0x12D4 */ public int NormandyDamageEvents;
        [NMS(Index = 139)]
        /* 0x12D8 */ public int NormandyFailures;
        [NMS(Index = 84)]
        /* 0x12DC */ public int NumberOfExpeditionChoices;
        [NMS(Index = 89)]
        /* 0x12E0 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        [NMS(Index = 34)]
        /* 0x12E4 */ public int NumberOfShipsInInitialFleet;
        [NMS(Index = 94)]
        /* 0x12E8 */ public int NumberOfUAChangesPerExpeditionEvent;
        [NMS(Index = 37)]
        /* 0x12EC */ public int OverrideExpeditionSecondsPerDay;
        [NMS(Index = 25)]
        /* 0x12F0 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        [NMS(Index = 50)]
        /* 0x12F4 */ public int PercentChanceOfGenericEventDescription;
        [NMS(Index = 100)]
        /* 0x12F8 */ public int PercentChanceOfInterventionEvent;
        [NMS(Index = 51)]
        /* 0x12FC */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        [NMS(Index = 18)]
        /* 0x1300 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Index = 13)]
        /* 0x1304 */ public float PostCombatSpawnDelay;
        [NMS(Index = 60)]
        /* 0x1308 */ public float PostFreighterWarpSpawnDelayForFleetFrigates;
        [NMS(Index = 59)]
        /* 0x130C */ public float PreFreighterWarpDepawnDelayForFleetFrigates;
        [NMS(Index = 57)]
        /* 0x1310 */ public float RadiusRequiredForFrigateSpawn;
        [NMS(Index = 48)]
        /* 0x1314 */ public int RampDamageNumberOfExpeditions;
        [NMS(Index = 4)]
        /* 0x1318 */ public float SingleShipFlybyDistance;
        [NMS(Index = 6)]
        /* 0x131C */ public float SingleShipFlybyHeightOffset;
        [NMS(Index = 5)]
        /* 0x1320 */ public float SingleShipFlybyMaxAngle;
        [NMS(Index = 61)]
        /* 0x1324 */ public float SpawnDelayForFleetFrigates;
        [NMS(Index = 58)]
        /* 0x1328 */ public float SpawnDelayForNewFrigates;
        [NMS(Index = 62)]
        /* 0x132C */ public float SpawnDelayForReturningFrigates;
        [NMS(Index = 65)]
        /* 0x1330 */ public float SpawnDelayIncreasePerFrigate;
        [NMS(Index = 64)]
        /* 0x1334 */ public float SpawnDelayRandomMax;
        [NMS(Index = 63)]
        /* 0x1338 */ public float SpawnDelayRandomMin;
        [NMS(Index = 106)]
        /* 0x133C */ public int StatPointsAwardedForLevelUp;
        [NMS(Index = 112)]
        /* 0x1340 */ public float TimeBeforeDebriefLogsStart;
        [NMS(Index = 33)]
        /* 0x1344 */ public float TimeBeforeHidingHangar;
        [NMS(Index = 44)]
        /* 0x1348 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        [NMS(Index = 102)]
        /* 0x134C */ public float TimeBeforePlayerAlertedToInterventionEvent;
        [NMS(Index = 32)]
        /* 0x1350 */ public float TimeBeforeShowingHangar;
        [NMS(Index = 109)]
        /* 0x1354 */ public float TimeBetweenDebriefLettersAppearing;
        [NMS(Index = 111)]
        /* 0x1358 */ public float TimeBetweenDebriefLogsAppearing;
        [NMS(Index = 110)]
        /* 0x135C */ public float TimeBetweenDebriefLogSectionsAppearing;
        [NMS(Index = 95)]
        /* 0x1360 */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Index = 91)]
        /* 0x1364 */ public int TimeTakenForExpeditionEvent;
        [NMS(Index = 90)]
        /* 0x1368 */ public int TimeTakenForExpeditionEvent_Easy;
        [NMS(Index = 29)]
        /* 0x136C */ public float UITraitLinesAngle;
        [NMS(Index = 31, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1370 */ public NMSString0x20[] RacialTermForCaptain;
        [NMS(Index = 39)]
        /* 0x1490 */ public bool DisablePlayerFleets;
        [NMS(Index = 36)]
        /* 0x1491 */ public bool ExpeditionsCompleteInstantly;
        [NMS(Index = 35)]
        /* 0x1492 */ public bool NewFrigatesStartDamaged;
        [NMS(Index = 113)]
        /* 0x1493 */ public bool ShowMissingRewardDescriptions;
        [NMS(Index = 38)]
        /* 0x1494 */ public bool ShowSeeds;
    }
}
