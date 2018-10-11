using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x138, Alignment = 0x8, GUID = 0x59B90F78441D5EDF)]
    public class GcMissionSequenceBuild : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Part;
        /* 0x090 */ public bool TeachIfNotKnown;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x091 */ public byte[] Padding91;
        /* 0x098 */ public GcBuildingPartSearchType Type;
        [NMS(Size = 0x80)]
        /* 0x0B8 */ public string DebugText;
    }
}
