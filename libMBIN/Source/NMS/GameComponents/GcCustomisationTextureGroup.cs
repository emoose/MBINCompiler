namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F66ACACFFDC8C32, NameHash = 0xAA9036F)]
    public class GcCustomisationTextureGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Title;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 GroupID;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 TextureOptionGroup;
        [NMS(Index = 3)]
        /* 0x40 */ public bool ShowDefaultOptionAsCross;
    }
}
