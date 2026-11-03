namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4A609A2FA678EDF2, NameHash = 0xB10C6CBF)]
    public class TkSceneBoneRemapping : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x80 FromBone;
        [NMS(Index = 1)]
        /* 0x80 */ public NMSString0x80 ToBone;
    }
}
