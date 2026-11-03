namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4A1C51C8B4940096, NameHash = 0x5381C745)]
    public class TkBlackboardValueBool : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x10 */ public bool Value;
    }
}
