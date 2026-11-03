namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35FC49A3D4F24FAC, NameHash = 0xAC16D315)]
    public class GcWarpAction : NMSTemplate
    {
        // size: 0x2
        public enum WarpTypeEnum : uint {
            BlackHole,
            SpacePOI,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WarpTypeEnum WarpType;
    }
}
