namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50538964135E2380, NameHash = 0x1FA80ABD4B6B665)]
    public class GcInventoryClassCostMultiplier : NMSTemplate
    {
        // size: 0x4
        public enum MultiplierEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(MultiplierEnum))]
        /* 0x0 */ public float[] Multiplier;
    }
}
