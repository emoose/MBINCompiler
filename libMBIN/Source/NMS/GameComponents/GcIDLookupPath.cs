namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5F4E0F38AFC127D, NameHash = 0x76EA6E6A)]
    public class GcIDLookupPath : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A Id;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x800 Path;
        [NMS(Index = 6)]
        /* 0x820 */ public NMSString0x80 DescriptionField;
        [NMS(Index = 7)]
        /* 0x8A0 */ public NMSString0x80 ImageField;
        [NMS(Index = 4)]
        /* 0x920 */ public NMSString0x80 NameField;
        [NMS(Index = 5)]
        /* 0x9A0 */ public NMSString0x80 SubTitleField;
        [NMS(Index = 3)]
        /* 0xA20 */ public bool ExportToGame;
        [NMS(Index = 2)]
        /* 0xA21 */ public bool GlobalSort;
    }
}
