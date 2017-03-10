namespace MBINCompiler.Models.Structs
{
    public class GcScanEventData : NMSTemplate // 0xE0 bytes
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string NextOption;

        /* 0x20 */ public int TriggerEventStartType;
        public string[] TriggerEventStartTypeValues()
        {
            return new[] { "None", "Special", "Discovered", "Timer", "ObjectScan", "LeaveBuilding" };
        }

        /* 0x24 */ public int TriggerEventEndType;
        public string[] TriggerEventEndTypeValues()
        {
            return new[] { "None", "Proximity", "Interact", "EnterBuilding", "TimedInteract" };
        }

        /* 0x28 */ public int TriggerEventPriority;
        public string[] TriggerEventPriorityValues()
        {
            return new[] { "Regular", "High" };
        }

        /* 0x2C */ public float MessagesStartTime;
        /* 0x30 */ public float MessagesMessageTime;
        /* 0x34 */ public float MessagesMessageDisplayTime;
        /* 0x38 */ public GcAudioWwiseEvents MessagesAkEvent;
        /* 0x3C */ public float MessagesIconTime;
        /* 0x40 */ public float MessagesTooltipTime;
        /* 0x44 */ public bool MessagesTooltipRepeats;
        /* 0x45 */ public bool MessagesShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x46 */ public string MessagesOSDMessage;
        [NMS(Size = 0x20)]
        /* 0x66 */ public string MessagesTooltipMessage;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x86 */ public byte[] Padding86;

        /* 0x88 */ public int TargetBuildingLocation;
        public string[] TargetBuildingLocationValues()
        {
            return new[] { "Nearest", "Random", "RandomOnNearPlanet", "RandomOnFarPlanet" };
        }
        /* 0x8C */ public int TargetBuildingType;
        public string[] TargetBuildingTypeValues()
        {
            return new[] { "Any", "AnyShelter", "BuildingClass", "Specific", "SpaceStation", "SpaceAnomaly", "Freighter", "SpaceStationHire", "ExternalPlanetBase", "PlanetBaseTerminal"};
        }

        /* 0x90 */ public GcBuildingClassification TargetBuildingClassification;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x94 */ public byte[] Padding94;

        /* 0xA0 */ public Vector4f TargetSpecificBuildingLoc;
        [NMS(Size = 0x10)]
        /* 0xB0 */ public string TargetForceInteraction;
        /* 0xC0 */ public GcInteractionType TargetInterationType;
		/* 0xC4 */ public bool ForceRestartInteraction;
		[NMS(Size = 0x10)]
		/* 0xC8 */ public string HasReward;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] PaddingD8;
    }
}