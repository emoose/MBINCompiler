namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAB43426BB6135EF9, NameHash = 0xA6F481EC)]
    public class TkIdSceneFilename : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFilename Filename;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
    }
}
