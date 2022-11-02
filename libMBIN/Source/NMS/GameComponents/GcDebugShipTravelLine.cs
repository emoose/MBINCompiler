namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B7BE7540882F6A9, NameHash = 0x639D09D542659F2F)]
    public class GcDebugShipTravelLine : NMSTemplate
    {
        /* 0x00 */ public Vector3f Origin;
        /* 0x10 */ public Vector3f Dir;
        /* 0x20 */ public float Length;
        /* 0x24 */ public float InfluenceRange;
    }
}
