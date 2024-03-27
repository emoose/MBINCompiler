namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x631C63205D55D63D, NameHash = 0xF0C0C2FEA5315F36)]
    public class GcHotActionMenuTypes : NMSTemplate
    {
        // size: 0x3
        public enum HotActionMenuTypesEnum : uint {
            OnFoot,
            InShip,
            InExocraft,
        }
        /* 0x0 */ public HotActionMenuTypesEnum HotActionMenuTypes;
    }
}
