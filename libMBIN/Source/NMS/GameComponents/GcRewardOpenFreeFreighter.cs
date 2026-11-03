namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x697DAEFE5AD830C0, NameHash = 0x8485DC51)]
    public class GcRewardOpenFreeFreighter : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A NextInteractionIfBought;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A NextInteractionIfNotBought;
        [NMS(Index = 0)]
        /* 0x40 */ public bool ReinteractWhenBought;
    }
}
