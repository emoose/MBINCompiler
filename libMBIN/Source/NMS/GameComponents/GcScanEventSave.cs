using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0xCFD3945861E17CAA, NameHash = 0x434C17159AF37265)]
    public class GcScanEventSave : NMSTemplate
    {
        /* 0x00 */ public int Table;
        /* 0x08 */ public NMSString0x20A Event;
        /* 0x28 */ public ulong GalacticAddress;
        /* 0x30 */ public GcSeed BuildingSeed;
        /* 0x40 */ public Vector3f BuildingLocation;
        /* 0x50 */ public GcBuildingClassification BuildingClass;
        /* 0x54 */ public float Time;
        /* 0x58 */ public NMSString0x10 MissionID;
        /* 0x68 */ public ulong MissionSeed;
        /* 0x70 */ public GcPlayerMissionParticipantType ParticipantType;
    }
}
