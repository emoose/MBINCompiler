namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F25FD89485C41CA, NameHash = 0x8179391B845D50D7)]
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public float[] ClassProbabilities;
    }
}
