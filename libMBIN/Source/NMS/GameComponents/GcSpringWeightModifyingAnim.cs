namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF4D82E2C323E475, NameHash = 0xF58121A9)]
    public class GcSpringWeightModifyingAnim : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public float DesiredWeight;
        [NMS(Index = 2)]
        /* 0x14 */ public bool IncludeBlendOut;
    }
}
