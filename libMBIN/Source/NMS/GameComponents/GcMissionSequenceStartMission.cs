using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x98, GUID = 0x53DA614048F0E999, NameHash = 0x5BB6B87A77237F5E)]
    public class GcMissionSequenceStartMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public bool MakeCurrent;
        /* 0x11 */ public bool Restart;
        /* 0x12 */ public bool Forced;
        /* 0x13 */ public NMSString0x80 DebugText;
    }
}
