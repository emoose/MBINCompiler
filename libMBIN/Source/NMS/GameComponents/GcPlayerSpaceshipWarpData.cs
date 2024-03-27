using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31AE5D12112FF00, NameHash = 0x69AE13F58EC1B23A)]
    public class GcPlayerSpaceshipWarpData : NMSTemplate
    {
        /* 0x00 */ public float EntryTime;
        /* 0x04 */ public TkCurveType EntryTunnelCurve;
        /* 0x08 */ public float TravelTunnelTime;
        /* 0x0C */ public float ExitTime;
        /* 0x10 */ public TkCurveType ExitTunnelCurve;
    }
}
