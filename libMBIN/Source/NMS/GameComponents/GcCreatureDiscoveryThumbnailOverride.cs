namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4934EE4DB49CE7A, NameHash = 0xEAA1BACF)]
    public class GcCreatureDiscoveryThumbnailOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f DiscoveryUIOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20A ContainsDescriptor;
        [NMS(Index = 1)]
        /* 0x30 */ public float DiscoveryUIScaler;
    }
}
