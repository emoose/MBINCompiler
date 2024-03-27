namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8AEBEF11092A0AA6, NameHash = 0xA4F2D5595864317D)]
    public class TkVolumeTriggerType : NMSTemplate
    {
        // size: 0x12
        public enum VolumeTriggerTypeEnum : uint {
            Open,
            GenericInterior,
            GenericGlassInterior,
            Corridor,
            SmallRoom,
            LargeRoom,
            OpenCovered,
            HazardProtection,
            FieldBoundary,
            Custom_Biodome,
            Portal,
            VehicleBoost,
            NexusPlaza,
            NexusCommunityHub,
            NexusHangar,
            RaceObstacle,
            HazardProtectionCold,
            SpaceStorm,
        }
        /* 0x0 */ public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
