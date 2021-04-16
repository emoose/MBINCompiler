using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x128, GUID = 0x79130D4322C4512F, NameHash = 0x32B3DC82536846ED)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public ulong Time;
        /* 0x088 */ public float Randomness;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x08C */ public byte[] Padding8C;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string DisplayStat;
        /* 0x0A0 */ public bool StatFromNow;
        [NMS(Size = 0x80)]
        /* 0x0A1 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x121 */ public byte[] EndPadding;
    }
}
