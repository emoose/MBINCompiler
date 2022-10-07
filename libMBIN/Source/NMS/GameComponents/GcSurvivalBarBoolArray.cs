namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6337CC882E875AD3, NameHash = 0xF323538389A223A0)]
    public class GcSurvivalBarBoolArray : NMSTemplate
    {
        // size: 0x3
        public enum ValuesEnum {
            Health,
            Hazard,
            Energy
        }
        [NMS(Size = 0x3, EnumType = typeof(ValuesEnum))]
        /* 0x0 */ public bool[] Values;
    }
}
