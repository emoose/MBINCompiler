namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0959B82BA453EF8, NameHash = 0xCA58D35FFFB37091)]
    public class GcUniqueIdData : NMSTemplate
    {
        // size: 0x3
        public enum UniqueIdTypeEnum : uint {
            Invalid,
            Deterministic,
            UserSpawned,
        }
        /* 0x00 */ public UniqueIdTypeEnum UniqueIdType;
        /* 0x08 */ public ulong DeterministicSeed;
        /* 0x10 */ public uint Iteration;
        /* 0x14 */ public NMSString0x40 OnlineID;
        /* 0x54 */ public NMSString0x20 PlatformID;
    }
}
