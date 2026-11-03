namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75F3BF37E7AE6A42, NameHash = 0x86EBD41F)]
    public class GcAccessibleOverride_Layout : NMSTemplate
    {
        // size: 0x5
        public enum AccessibleOverride_LayoutEnum : uint {
            PosX,
            PosY,
            LayerWidth,
            LayerHeight,
            MaxWidth,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AccessibleOverride_LayoutEnum AccessibleOverride_Layout;
        [NMS(Index = 1)]
        /* 0x4 */ public float FloatValue;
    }
}
