namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB20046015D38F91, NameHash = 0xED643334)]
    public class GcProtectedLocation : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Location;
        [NMS(Index = 1)]
        /* 0x10 */ public float Radius;
    }
}
