namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7713CC35A6610ED, NameHash = 0xC514DD27)]
    public class GcEasyRagdollSetUpBodyDimensions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Centre;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector3f Size;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20 Joint;
    }
}
