namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D86CADD1E49AD2, NameHash = 0x8179391B845D50D7)]
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        // size: 0x4
        public enum ClassProbabilitiesEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(ClassProbabilitiesEnum))]
        /* 0x0 */ public float[] ClassProbabilities;
    }
}
