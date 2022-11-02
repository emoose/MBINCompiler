namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D23D8A6DBE17443, NameHash = 0x748F2F6EDE9F5F18)]
    public class GcBuildingOverrideData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public Vector3f Position;
        /* 0x20 */ public int Index;
    }
}
