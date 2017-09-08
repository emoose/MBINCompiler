namespace libMBIN.Models.Structs
{
    public class GcPlayerMissionProgress : NMSTemplate // 0x148 bytes
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Mission;
        /* 0x010 */ public int Progress;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x014 */ public byte[] Padding14;
        /* 0x018 */ public ulong Seed;
        /* 0x020 */ public ulong Data;
        [NMS(Size = 0xC)]
        /* 0x028 */ public GcPlayerMissionParticipant[] Participants;

    }
}
