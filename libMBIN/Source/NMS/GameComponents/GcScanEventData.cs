using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x5F0, GUID = 0x7A3940B6BBE694A6, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Name;
        /* 0x020 */ public NMSString0x20A ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool ForceOverridesAll;
        /* 0x048 */ public NMSString0x10 ForceOverrideEncounter;
        /* 0x058 */ public bool IsCommunityPortalOverride;
        /* 0x059 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x05C */ public float BuildingPreventionRadius;
        /* 0x060 */ public bool AlwaysShow;
        /* 0x061 */ public bool NeverShow;
        /* 0x068 */ public NMSString0x20A PlanetLabelText;
        /* 0x088 */ public float SurveyDistance;
        /* 0x090 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        // size: 0x6
        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
        /* 0x0B0 */ public EventStartTypeEnum EventStartType;
        // size: 0x5
        public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
        /* 0x0B4 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum { Regular, High }
        /* 0x0B8 */ public EventPriorityEnum EventPriority;
        /* 0x0BC */ public bool CanEndFromOutsideMission;
        /* 0x0BD */ public bool DisableMultiplayerSync;
        /* 0x0BE */ public bool ReplaceEventIfAlreadyActive;
        // size: 0x7
        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet, PlanetSearch,
            PlayerSettlement
        }
        /* 0x0C0 */ public BuildingLocationEnum BuildingLocation;
        // size: 0x17
        public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas,
            Freighter, FreighterBase, ExternalPlanetBase, PlanetBaseTerminal, Expedition,
            TutorialShelter, MPMissionFreighter, Nexus, InitialDistressSignal,
            SpaceMarker, NexusEggMachine, PhotoTarget, SettlementConstruction,
            UnownedSettlement, NPC_HideOut, FriendlyDrone
        }
        /* 0x0C4 */ public BuildingTypeEnum BuildingType;
        /* 0x0C8 */ public GcBuildingClassification BuildingClass;
        /* 0x0CC */ public bool AllowFriendsBases;
        /* 0x0CD */ public bool ForceWideRandom;
        /* 0x0CE */ public bool MustFindSystem;
        /* 0x0CF */ public bool AllowOverriddenBuildings;
        // size: 0x6
        public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList, SeasonParty }
        /* 0x0D0 */ public SolarSystemLocationEnum SolarSystemLocation;
        /* 0x0D8 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x148 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x1B8 */ public bool ForceRestartInteraction;
        /* 0x1C0 */ public NMSString0x10 HasReward;
        /* 0x1D0 */ public NMSString0x20A NextOption;
        /* 0x1F0 */ public GcScanEventTriggers TriggerActions;
        /* 0x210 */ public List<NMSString0x100> UAsList;
        /* 0x220 */ public GcTechnologyCategory TechShopType;
        /* 0x224 */ public NMSString0x20 OSDMessage;
        /* 0x244 */ public NMSString0x20 InterstellarOSDMessage;
        /* 0x264 */ public NMSString0x20 MarkerLabel;
        /* 0x284 */ public TkTextureResource MarkerIcon;
        /* 0x308 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        /* 0x30C */ public float StartTime;
        /* 0x310 */ public float MessageTime;
        /* 0x314 */ public float MessageDisplayTime;
        /* 0x318 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x31C */ public float IconTime;
        /* 0x320 */ public float TooltipTime;
        /* 0x324 */ public bool TooltipRepeats;
        /* 0x325 */ public bool ShowEndTooltip;
        /* 0x326 */ public NMSString0x20 TooltipMessage;
        /* 0x348 */ public GcResourceElement ResourceOverride;
    }
}
