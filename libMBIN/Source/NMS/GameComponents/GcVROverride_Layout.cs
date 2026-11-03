namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3080F0BAC921F284, NameHash = 0xCCB2C3D8)]
    public class GcVROverride_Layout : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float FloatValue;
        // size: 0x5
        public enum VROverride_LayoutEnum : uint {
            PosX,
            PosY,
            LayerWidth,
            LayerHeight,
            MaxWidth,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public VROverride_LayoutEnum VROverride_Layout;
    }
}
