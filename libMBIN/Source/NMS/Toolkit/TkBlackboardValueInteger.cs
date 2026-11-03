namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8C1340F742503CA2, NameHash = 0x7270FE99)]
    public class TkBlackboardValueInteger : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x10 */ public int Value;
    }
}
