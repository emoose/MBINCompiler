using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0xF5CF46F34D184154, NameHash = 0x32B3DC82536846ED)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Message;
        /* 0x80 */ public ulong Time;
        /* 0x88 */ public float Randomness;
        [NMS(Size = 0x80)]
        /* 0x8C */ public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10C */ public byte[] EndPadding;
    }
}
