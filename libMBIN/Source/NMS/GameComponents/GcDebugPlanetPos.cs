namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3785C0AEAA2AE223, NameHash = 0x9A59306B)]
    public class GcDebugPlanetPos : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public bool OverridePosition;
    }
}
