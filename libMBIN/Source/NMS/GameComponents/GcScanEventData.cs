using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2423E20F73CBEE6, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Name;
        /* 0x020 */ public NMSString0x20A ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public GcAlienRace RequireInteractionRace;
        /* 0x048 */ public GcAlienRace OverrideInteractionRace;
        /* 0x050 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        /* 0x070 */ public bool ForceBroken;
        /* 0x071 */ public bool ForceFixed;
        /* 0x072 */ public bool ForceOverridesAll;
        /* 0x078 */ public NMSString0x10 ForceOverrideEncounter;
        /* 0x088 */ public bool IsCommunityPortalOverride;
        /* 0x089 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x08C */ public float BuildingPreventionRadius;
        /* 0x090 */ public bool UseMissionTradingDataOverride;
        /* 0x091 */ public bool AlwaysShow;
        /* 0x092 */ public bool NeverShow;
        /* 0x093 */ public bool ShowOnlyIfSequenceTarget;
        /* 0x098 */ public NMSString0x20A PlanetLabelText;
        /* 0x0B8 */ public float SurveyDistance;
        /* 0x0C0 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        /* 0x0E0 */ public EventStartTypeEnum EventStartType;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        /* 0x0E4 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        /* 0x0E8 */ public EventPriorityEnum EventPriority;
        /* 0x0EC */ public bool CanEndFromOutsideMission;
        /* 0x0ED */ public bool DisableMultiplayerSync;
        /* 0x0EE */ public bool BlockStartedOnUseEvents;
        /* 0x0EF */ public bool ReplaceEventIfAlreadyActive;
        // size: 0x7
        public enum BuildingLocationEnum : uint {
            Nearest,
            AllNearest,
            Random,
            RandomOnNearPlanet,
            RandomOnFarPlanet,
            PlanetSearch,
            PlayerSettlement,
        }
        /* 0x0F0 */ public BuildingLocationEnum BuildingLocation;
        // size: 0x18
        public enum BuildingTypeEnum : uint {
            Any,
            AnyShelter,
            AnyNPC,
            BuildingClass,
            SpaceStation,
            SpaceAnomaly,
            Atlas,
            Freighter,
            FreighterBase,
            ExternalPlanetBase,
            PlanetBaseTerminal,
            Expedition,
            TutorialShelter,
            MPMissionFreighter,
            Nexus,
            InitialDistressSignal,
            SpaceMarker,
            NexusEggMachine,
            PhotoTarget,
            SettlementConstruction,
            UnownedSettlement,
            NPC_HideOut,
            FriendlyDrone,
            AnyRobotSite,
        }
        /* 0x0F4 */ public BuildingTypeEnum BuildingType;
        /* 0x0F8 */ public GcBuildingClassification BuildingClass;
        /* 0x0FC */ public bool AllowFriendsBases;
        /* 0x0FD */ public bool ForceWideRandom;
        /* 0x0FE */ public bool MustFindSystem;
        /* 0x0FF */ public bool AllowOverriddenBuildings;
        /* 0x100 */ public bool TargetMustMatchMissionSeed;
        // size: 0x6
        public enum SolarSystemLocationEnum : uint {
            Local,
            Near,
            LocalOrNear,
            NearWithNoExpeditions,
            FromList,
            SeasonParty,
        }
        /* 0x104 */ public SolarSystemLocationEnum SolarSystemLocation;
        /* 0x108 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x180 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x1F8 */ public bool ForceRestartInteraction;
        /* 0x200 */ public NMSString0x10 HasReward;
        /* 0x210 */ public NMSString0x20A NextOption;
        /* 0x230 */ public GcScanEventTriggers TriggerActions;
        /* 0x250 */ public List<NMSString0x100> UAsList;
        /* 0x260 */ public GcTechnologyCategory TechShopType;
        /* 0x264 */ public NMSString0x20 OSDMessage;
        /* 0x284 */ public NMSString0x20 InterstellarOSDMessage;
        /* 0x2A4 */ public NMSString0x20 MarkerLabel;
        /* 0x2C4 */ public TkTextureResource MarkerIcon;
        /* 0x348 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        /* 0x34C */ public float StartTime;
        /* 0x350 */ public float MessageTime;
        /* 0x354 */ public float MessageDisplayTime;
        /* 0x358 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x35C */ public float IconTime;
        /* 0x360 */ public float TooltipTime;
        /* 0x364 */ public bool TooltipRepeats;
        /* 0x365 */ public bool ShowEndTooltip;
        /* 0x366 */ public NMSString0x20 TooltipMessage;
        /* 0x388 */ public NMSString0x10 MissionMessageOnInteract;
        /* 0x398 */ public GcResourceElement ResourceOverride;
    }
}
