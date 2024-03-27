namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42BCA060447AA539, NameHash = 0xEFA8947B437770B8)]
    public class GcSyncBufferSaveData : NMSTemplate
    {
        /* 0x00 */ public ulong SpaceAddress;
        /* 0x08 */ public NMSString0x40 OwnerOnlineId;
        /* 0x48 */ public NMSString0x20 OwnerPlatformId;
        /* 0x68 */ public uint BufferVersion;
        /* 0x6C */ public uint ItemsCount;
    }
}
