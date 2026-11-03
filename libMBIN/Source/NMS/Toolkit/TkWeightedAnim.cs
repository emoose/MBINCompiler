namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x41B63C0A2E88C9F8, NameHash = 0xCD4224A0)]
    public class TkWeightedAnim : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public float Weight;
    }
}
