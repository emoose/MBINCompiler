using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF1770CDE36D84D74, NameHash = 0x5DDE5C2B)]
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public float[] ClassProbabilities;
    }
}
