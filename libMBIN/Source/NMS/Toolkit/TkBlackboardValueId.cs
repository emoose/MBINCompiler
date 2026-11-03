namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB18C6A1060744497, NameHash = 0xE681D534)]
    public class TkBlackboardValueId : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Value;
    }
}
