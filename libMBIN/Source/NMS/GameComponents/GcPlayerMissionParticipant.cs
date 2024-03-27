using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEFEC4DF3E984447, NameHash = 0xB223E7785971518B)]
    public class GcPlayerMissionParticipant : NMSTemplate
    {
        /* 0x00 */ public ulong UA;
        /* 0x08 */ public GcSeed BuildingSeed;
        /* 0x20 */ public Vector3f BuildingLocation;
        /* 0x30 */ public GcPlayerMissionParticipantType ParticipantType;
    }
}
