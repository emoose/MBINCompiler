using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0180E4DCDD03EC2, NameHash = 0xB9769DB00B6A3E69)]
    public class GcMissionSequenceBuild : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Part;
        /* 0x90 */ public bool TakePartFromSeasonData;
        /* 0x91 */ public bool TeachIfNotKnown;
        /* 0x98 */ public GcBuildingPartSearchType Type;
        /* 0xB8 */ public NMSString0x80 DebugText;
    }
}
