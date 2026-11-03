namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BB9FF5D0E2494A1, NameHash = 0xC1985610)]
    public class GcExpeditionDebriefPunctuation : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Delay;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x20 Punctuation;
    }
}
