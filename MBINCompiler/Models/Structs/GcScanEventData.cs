namespace MBINCompiler.Models.Structs
{
    public class GcScanEventData : NMSTemplate // 0xD0 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        [NMS(Size = 0x10)]
        public string NextOption;

        public int TriggerEventStartType;
        public string[] TriggerEventStartTypeValues()
        {
            return new[] { "None", "Special", "Discovered", "Timer", "ObjectScan", "LeaveBuilding" };
        }

        public int TriggerEventEndType;
        public string[] TriggerEventEndTypeValues()
        {
            return new[] { "None", "Proximity", "Interact", "EnterBuilding" };
        }

        public int TriggerEventPriority;
        public string[] TriggerEventPriorityValues()
        {
            return new[] { "Regular", "High" };
        }

        public float MessagesStartTime;
        public float MessagesMessageTime;
        public float MessagesMessageDisplayTime;
        public GcAudioWwiseEvents MessagesAkEvent;
        public float MessagesIconTime;
        public float MessagesTooltipTime;
        public bool MessagesTooltipRepeats;
        public bool MessagesShowEndTooltip;
        [NMS(Size = 0x20)]
        public string MessagesOSDMessage;
        [NMS(Size = 0x20)]
        public string MessagesTooltipMessage;
        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding86;

        public int TargetBuildingLocation;
        public string[] TargetBuildingLocationValues()
        {
            return new[] { "Nearest", "Random", "RandomOnNearPlanet", "RandomOnFarPlanet" };
        }
        public int TargetBuildingType;
        public string[] TargetBuildingTypeValues()
        {
            return new[] { "Any", "AnyShelter", "BuildingClass", "Specific", "SpaceStation", "SpaceAnomaly", "Freighter", "SpaceStation"};
        }

        public GcBuildingClassification TargetBuildingClassification;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding94;

        public Vector4f TargetSpecificBuildingLoc;
        [NMS(Size = 0x10)]
        public string TargetForceInteraction;
        public GcInteractionType TargetInterationType;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] PaddingC4;
    }
}
