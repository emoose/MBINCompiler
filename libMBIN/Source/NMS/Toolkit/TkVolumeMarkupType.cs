namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1C5F63D64B085215, NameHash = 0x504B467A)]
    public class TkVolumeMarkupType : NMSTemplate
    {
        // size: 0x1
        public enum VolumeMarkupTypeEnum : uint {
            NavMeshGenerationBounds,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VolumeMarkupTypeEnum VolumeMarkupType;
    }
}
