using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFF35AB6E4A1B63E, NameHash = 0x886C03C3F3987F4)]
    public class GcAtlasDiscovery : NMSTemplate
    {
        /* 0x000 */ public GcAtlasDownloadType PackageType;
        /* 0x004 */ public GcDiscoveryOwner Owner;
        /* 0x108 */ public GcAtlasDiscoveryData Data;
        /* 0x150 */ public GcAtlasDiscoveryMetadata Metadata;
        /* 0x1D0 */ public GcAtlasMessage MessageData;
        /* 0x290 */ public NMSString0x40 RID;
        /* 0x2D0 */ public NMSString0x20 PTK;
    }
}
