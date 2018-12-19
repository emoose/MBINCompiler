using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x208, Alignment = 0x8, GUID = 0x49A9C567F1869B0D)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool ForceOverridesAll;
        /* 0x047 */ public bool AlwaysShow;
        /* 0x048 */ public bool NeverShow;
        /* 0x049 */ public bool IsCommunityPortalOverride;
        /* 0x04A */ public bool ClearForcedInteractionOnCompletion;

        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
		/* 0x04C */ public EventStartTypeEnum EventStartType;
		public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
		/* 0x050 */ public EventEndTypeEnum EventEndType;
		public enum EventPriorityEnum { Regular, High }
		/* 0x054 */ public EventPriorityEnum EventPriority;

        /* 0x058 */ public bool CanEndFromOutsideMission;
        /* 0x059 */ public bool DisableMultiplayerSync;

        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet }
		/* 0x05C */ public BuildingLocationEnum BuildingLocation;
		public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas, Freighter, FreighterBase,
            ExternalPlanetBase, PlanetBaseTerminal, Expedition, TutorialShelter, MPMissionFreighter }
		/* 0x060 */ public BuildingTypeEnum BuildingType;
        /* 0x064 */ public GcBuildingClassification BuildingClass;
        /* 0x068 */ public bool AllowFriendBases;

		public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList }
		/* 0x06C */ public SolarSystemLocationEnum SolarSystemLocation;

        /* 0x070 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x0A0 */ public bool ForceRestartInteraction;
        [NMS(Size = 7, Ignore = true)]
        /* 0x0A1 */ public byte[] PaddingA1;
        [NMS(Size = 0x10)]
        /* 0x0A8 */ public string HasReward;
        [NMS(Size = 0x20)]
        /* 0x0B8 */ public string NextOption;
        /* 0x0D8 */ public GcScanEventTriggers TriggerActions;
        /* 0x0F8 */ public List<NMSString0x100> UAsList;
        [NMS(Size = 0x20)]
        /* 0x108 */ public string OSDMessage;
        [NMS(Size = 0x20)]
        /* 0x128 */ public string MarkerLabel;
        /* 0x148 */ public TkTextureResource MarkerIcon;
        /* 0x1CC */ public float StartTime;
        /* 0x1D0 */ public float MessageTime;
        /* 0x1D4 */ public float MessageDisplayTime;
        /* 0x1D8 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x1DC */ public float IconTime;
        /* 0x1E0 */ public float TooltipTime;
        /* 0x1E4 */ public bool TooltipRepeats;
        /* 0x1E5 */ public bool ShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x1E6 */ public string TooltipMessage;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x206 */ public byte[] EndPadding;
    }
}