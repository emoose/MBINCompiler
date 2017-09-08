namespace libMBIN.Models.Structs
{
    public class GcScanEventData : NMSTemplate // 0x1D8 bytes
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool AlwaysShow;

        /* 0x048 */ public int EventStartType;
        public string[] EventStartTypeValues()
        {
            return new[] { "None", "Special", "Discovered", "Timer", "ObjectScan", "LeaveBuilding" };
        }
        /* 0x04C */ public int EventEndType;
        public string[] EventEndTypeValues()
        {
            return new[] { "None", "Proximity", "Interact", "EnterBuilding", "TimedInteract" };
        }
        /* 0x050 */ public int EventPriority;
        public string[] EventPriorityValues()
        {
            return new[] { "Regular", "High" };
        }
        /* 0x054 */ public int BuildingLocation;
        public string[] BuildingLocationValues()
        {
            return new[] { "Nearest", "AllNearest", "Random", "RandomOnNearPlanet", "RandomOnFarPlanet" };
        }
        /* 0x058 */ public int BuildingType;
        public string[] BuildingTypeValues()
        {
            return new[] { "Any", "AnyShelter", "BuildingClass", "SpaceStation", "SpaceAnomaly",
                           "Atlas", "Freighter", "ExternalPlanetBase", "PlanetBaseTerminal" };
        }
        /* 0x05C */ public GcBuildingClassification BuildingClass;

        /* 0x060 */ public int SolarSystemLocation;
        public string[] SolarSystemLocationValues()
        {
            return new[] { "Local", "Near", "LocalOrNear"};
        }

        /* 0x064 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x080 */ public bool ForceRestartInteraction;
        [NMS(Size = 07, Ignore = true)]
        /* 0x081 */ public byte[] Padding81;
        [NMS(Size = 0x10)]
        /* 0x088 */ public string HasReward;
        [NMS(Size = 0x20)]
        /* 0x098 */ public string NextOption;
        /* 0x0B8 */ public GcScanEventTriggers TriggerActions;
        [NMS(Size = 0x20)]
        /* 0x0D8 */ public string OSDMessage;
        [NMS(Size = 0x20)]
        /* 0x0F8 */ public string MarkerLabel;
        /* 0x118 */ public TkTextureResource Markericon;
        /* 0x19C */ public float StartTime;
        /* 0x1A0 */ public float MessageTime;
        /* 0x1A4 */ public float MessageDisplayTime;
        /* 0x1A8 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x1AC */ public float IconTime;
        /* 0x1B0 */ public float TooltipTime;
        /* 0x1B4 */ public bool TooltipRepeats;
        /* 0x1B5 */ public bool ShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x1B6 */ public string TooltipMessage;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1D6 */ public byte[] EndPadding;
    }
}