namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x615B0D74AE6210D3, NameHash = 0xE692EE8E366F900)]
    public class GcNPCNavSubgraphNodeTypeConnectivity : NMSTemplate
    {
        /* 0x0 */ public float InternalConnection;
        /* 0x4 */ public float ExternalConnection;
        /* 0x8 */ public float PathToPOI;
        /* 0xC */ public float ConnectionToPOI;
    }
}
