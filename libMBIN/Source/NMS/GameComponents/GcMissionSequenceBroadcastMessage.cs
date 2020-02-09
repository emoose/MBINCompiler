using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, Alignment = 0x8, GUID = 0x3DBB581AA4B68F25, NameHash = 0x60741FB7E840229E)]
    public class GcMissionSequenceBroadcastMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string DebugText;
        [NMS(Size = 0x10)]
        /* 0x80 */ public string MessageID;
        /* 0x90 */ public bool Seeded;
        /* 0x91 */ public bool Multiplayer;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x92 */ public byte[] EndPadding;
    }
}
