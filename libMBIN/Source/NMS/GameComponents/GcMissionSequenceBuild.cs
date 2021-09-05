using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x138, GUID = 0xAC86B8EC4236F1D9, NameHash = 0xB9769DB00B6A3E69)]
    public class GcMissionSequenceBuild : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 Part;
        /* 0x090 */ public bool TeachIfNotKnown;
        /* 0x098 */ public GcBuildingPartSearchType Type;
        /* 0x0B8 */ public NMSString0x80 DebugText;
    }
}
