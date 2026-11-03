namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4F746C94FF965E1B, NameHash = 0xD546A03E)]
    public class TkBlackboardValueFloat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x10 */ public float Value;
    }
}
