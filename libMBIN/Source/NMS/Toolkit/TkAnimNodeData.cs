namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x201D028F2C6CBDB7, NameHash = 0x6E19250A34E2CE86)]
    public class TkAnimNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x40 Node;
        /* 0x40 */ public bool CanCompress;
        /* 0x44 */ public int RotIndex;
        /* 0x48 */ public int TransIndex;
        /* 0x4C */ public int ScaleIndex;
    }
}
