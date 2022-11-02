namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1FA8D1F5E4F82180, NameHash = 0xCB6432BD8E0191A0)]
    public class GcAccessibleOverride_Layout : NMSTemplate
    {
        // size: 0x5
        public enum AccessibleOverride_LayoutEnum {
            PosX,
            PosY,
            LayerWidth,
            LayerHeight,
            MaxWidth
        }
        /* 0x0 */ public AccessibleOverride_LayoutEnum AccessibleOverride_Layout;
        /* 0x4 */ public float FloatValue;
    }
}
