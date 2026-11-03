namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBB6C772DBA38F5C7, NameHash = 0x436682ED)]
    public class TkLSystemGlobalVariation : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFilename Model;
        [NMS(Index = 2)]
        /* 0x10 */ public int Variations;
        [NMS(Index = 0)]
        /* 0x14 */ public NMSString0x20 Name;
    }
}
