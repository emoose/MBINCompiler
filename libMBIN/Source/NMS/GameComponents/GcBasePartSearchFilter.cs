using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB54F48788B089139, NameHash = 0x471C446618668C68)]
    public class GcBasePartSearchFilter : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IsSpecificID;
        /* 0x10 */ public bool PartIsOnline;
        /* 0x11 */ public bool PartIsNotOnline;
        /* 0x12 */ public bool PartIsVision;
        /* 0x13 */ public bool PartIsNotVision;
        /* 0x14 */ public bool ApplyGridFilter;
        /* 0x18 */ public GcBaseGridSearchFilter BaseGridFilter;
    }
}
