namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC81F0C0124210EB8, NameHash = 0xEBF3EA11)]
    public class TkNGuiLayoutListData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcFilename Default;
        [NMS(Index = 1)]
        /* 0x10 */ public GcFilename Filename;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x80 Name;
        [NMS(Index = 3)]
        /* 0xA0 */ public bool Autosave;
        [NMS(Index = 4)]
        /* 0xA1 */ public bool CanBeDeleted;
    }
}
