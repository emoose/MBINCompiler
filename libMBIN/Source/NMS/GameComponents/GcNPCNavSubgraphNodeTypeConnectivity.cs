namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44F0FC2319F7575, NameHash = 0x168C0B06)]
    public class GcNPCNavSubgraphNodeTypeConnectivity : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public float ConnectionToPOI;
        [NMS(Index = 1)]
        /* 0x4 */ public float ExternalConnection;
        [NMS(Index = 0)]
        /* 0x8 */ public float InternalConnection;
        [NMS(Index = 2)]
        /* 0xC */ public float PathToPOI;
    }
}
