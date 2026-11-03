namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE392FA4337CD6E3F, NameHash = 0x5AD86084)]
    public class GcCreatureFilename : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcFilename ExtraFilename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcFilename Filename;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
    }
}
